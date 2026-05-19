using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DeskWise;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Final step of the sales pipeline. Reads AppState.PendingOrder, shows totals
    // and a live receipt preview, then commits the sale through OrderService.Complete.

    public partial class CheckoutControl : UserControl
    {

        private Order _pending;

        private bool _completed;

        // Initializes checkout summary grid and payment controls

        public CheckoutControl()
        {
            InitializeComponent();
        }

        // Loads pending order from AppState or returns to builder if cart is empty

        private void CheckoutControl_Load(object sender, EventArgs e)
        {
            _pending = AppState.PendingOrder;

            // If somebody opened Checkout directly without a pending order, bounce them back.
            if (_pending == null || _pending.Items == null || _pending.Items.Count == 0)
            {
                MessageBox.Show("No order is ready for checkout. Build an order first.",
                    "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnToBuilder();
                return;
            }
            SetupGrid();
            BindOrderToGrid();
            UpdateCustomerLabel();
            RecalculateAndShow();
            RefreshReceiptPreview();
        }

        // Defines read-only line-item columns for the order summary grid

        private void SetupGrid()
        {
            dgvSummary.AutoGenerateColumns = false;
            dgvSummary.Columns.Clear();
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product",  Width = 240 });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity",    HeaderText = "Qty",      Width = 60 });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice",   HeaderText = "Price",    Width = 90, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal",    HeaderText = "Subtotal", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvSummary.AllowUserToAddRows = false;
        }

        // Binds pending order line items to the summary grid

        private void BindOrderToGrid()
        {
            dgvSummary.DataSource = null;
            dgvSummary.DataSource = _pending.Items;
        }

        // Shows customer name or walk-in label on the checkout header

        private void UpdateCustomerLabel()
        {
            lblCustomerName.Text = string.IsNullOrWhiteSpace(_pending.CustomerName)
                ? "Walk-in Customer"
                : _pending.CustomerName;
        }

        // Recalculates tax and totals from settings, then updates summary labels

        private void RecalculateAndShow()
        {
            _pending.RecalculateTotals(SettingsService.Current.TaxRate);
            lblSubtotal.Text = _pending.Subtotal.ToString("C2");
            lblDiscount.Text = _pending.Discount.ToString("C2");
            lblTax.Text      = _pending.Tax.ToString("C2");
            lblTotal.Text    = _pending.Total.ToString("C2");
        }

        // Returns the payment method selected by radio buttons

        private string SelectedPaymentMethod()
        {
            if (rbCard.Checked) return "Card";
            if (rbSplit.Checked) return "Split Pay";
            if (rbStoreCredit.Checked) return "Store Credit";
            return "Cash";
        }

        // Builds receipt text preview with payment method and staff name filled in

        private void RefreshReceiptPreview()
        {
            _pending.PaymentMethod = SelectedPaymentMethod();

            // Stamp a preview-only id so the preview looks complete before we commit.
            if (string.IsNullOrEmpty(_pending.OrderId)) _pending.OrderId = "PREVIEW";
            if (string.IsNullOrEmpty(_pending.EmployeeUsername))
            {
                _pending.EmployeeUsername = AppState.CurrentUser != null ? AppState.CurrentUser.Username : "unknown";
            }
            txtReceipt.Text = ReceiptService.Build(_pending);
        }

        // Completes the sale, saves receipt file, and locks confirm until user leaves

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_pending == null || _pending.Items.Count == 0)
            {
                MessageBox.Show("There is nothing to confirm.", "Empty Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _pending.PaymentMethod = SelectedPaymentMethod();

            // Reset the preview id - OrderService.Complete generates the real one.
            if (_pending.OrderId == "PREVIEW") _pending.OrderId = string.Empty;
            try
            {
                string staff = AppState.CurrentUser != null ? AppState.CurrentUser.Username : "unknown";
                Order completed = OrderService.Complete(_pending, staff, SettingsService.Current.TaxRate);
                string path = ReceiptService.SaveToFile(completed);
                _pending = completed;
                _completed = true;
                AppState.PendingOrder = null;

                // Reflect the saved order in the preview (now with a real order id and totals).
                txtReceipt.Text = ReceiptService.Build(completed);
                lblSubtotal.Text = completed.Subtotal.ToString("C2");
                lblDiscount.Text = completed.Discount.ToString("C2");
                lblTax.Text      = completed.Tax.ToString("C2");
                lblTotal.Text    = completed.Total.ToString("C2");
                MessageBox.Show("Sale completed.\r\nOrder: " + completed.OrderId +
                                "\r\nReceipt saved to:\r\n" + path,
                    "Sale Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConfirm.Enabled = false;
                btnCancel.Text = "Back to Order Builder";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Cannot Complete Sale",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Opens saved receipt file, or writes a temp preview file if sale not yet completed

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_completed)
                {

                    // Save a preview to a temp file so the user can open it.
                    string previewPath = Path.Combine(FileService.ReceiptsDirectory, "PREVIEW.txt");
                    FileService.EnsureDirectory(FileService.ReceiptsDirectory);
                    FileService.WriteText(previewPath, txtReceipt.Text);
                    Process.Start(previewPath);
                    return;
                }
                string saved = Path.Combine(FileService.ReceiptsDirectory, _pending.OrderId + ".txt");
                if (File.Exists(saved)) Process.Start(saved);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the receipt: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Cancels in-progress checkout or navigates back after a completed sale

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!_completed)
            {
                DialogResult confirmCancel = MessageBox.Show("Cancel this transaction and return to the Order Builder?",
                    "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmCancel != DialogResult.Yes) return;
            }
            ReturnToBuilder();
        }

        // Loads Order Builder screen in the main shell

        private void ReturnToBuilder()
        {
            MainShellForm main = this.FindForm() as MainShellForm;
            if (main != null) main.LoadScreen(new OrderBuilderControl());
        }
    }
}
