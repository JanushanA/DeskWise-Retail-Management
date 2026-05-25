using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DeskWise;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Order History screen. KPI cards across the top, filter row, then a grid of
    // completed/refunded/pending orders. Action buttons handle reprint, refund, and duplicate.

    public partial class OrderHistoryControl : UserControl
    {

        // Initializes order history grid and filter controls

        public OrderHistoryControl()
        {
            InitializeComponent();
        }

        // Sets up grid, filters, role permissions, and initial KPI bind on load

        private void OrderHistoryControl_Load(object sender, EventArgs e)
        {
            TextBoxHelper.SetSearchPlaceholder(txtSearch);
            SetupGrid();
            PopulateFilters();
            ApplyRolePermissions();
            ApplyFilter();
            BindKpis();
        }

        // Defines order list columns and status cell formatting

        private void SetupGrid()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderId",       HeaderText = "Order ID", Width = 90 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName",  HeaderText = "Customer", Width = 180 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Date",          HeaderText = "Date",     Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" } });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Total",         HeaderText = "Total",    Width = 90,  DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PaymentMethod", HeaderText = "Payment",  Width = 100 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status",        HeaderText = "Status",   Width = 100 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EmployeeUsername", HeaderText = "Staff", Width = 100 });
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;
            dgvOrders.CellFormatting += DgvOrders_CellFormatting;
        }

        // Fills status and payment filter dropdowns and default date range

        private void PopulateFilters()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "All", "Completed", "Pending", "Refunded", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
            cmbPayment.Items.Clear();
            cmbPayment.Items.AddRange(new object[] { "All", "Cash", "Card", "Split Pay", "Store Credit" });
            cmbPayment.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Today.AddDays(-365);
            dtpTo.Value = DateTime.Today;
        }

        // Enables refund button only for Manager and Admin roles

        private void ApplyRolePermissions()
        {
            bool canRefund = AppState.IsManager;
            btnRefund.Enabled = canRefund;
        }

        // Colours status column by order state (Completed, Refunded, Pending)

        private void DgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvOrders.Columns[e.ColumnIndex].DataPropertyName != "Status") return;
            string status = (e.Value ?? string.Empty).ToString();
            switch (status)
            {
                case "Completed":
                    e.CellStyle.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    break;
                case "Refunded":
                    e.CellStyle.ForeColor = Color.FromArgb(153, 27, 27);
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    break;
                case "Pending":
                    e.CellStyle.ForeColor = Color.FromArgb(202, 138, 4);
                    break;
            }
        }

        // Searches orders by text, date range, status, and payment method

        private void ApplyFilter()
        {
            string query = txtSearch.Text;
            DateTime from = dtpFrom.Value.Date;
            DateTime to   = dtpTo.Value.Date;
            string status = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "All";
            string payment = cmbPayment.SelectedItem != null ? cmbPayment.SelectedItem.ToString() : "All";
            List<Order> results = OrderService.Search(query, from, to, status, payment);
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = results;
        }

        // Updates KPI labels with order counts by status

        private void BindKpis()
        {
            int total = OrderService.All.Count;
            int completed = OrderService.All.Count(order => order.Status == "Completed");
            int pending = OrderService.All.Count(order => order.Status == "Pending");
            int refunded = OrderService.All.Count(order => order.Status == "Refunded");
            lblKpiTotal.Text     = total.ToString();
            lblKpiCompleted.Text = completed.ToString();
            lblKpiPending.Text   = pending.ToString();
            lblKpiRefunded.Text  = refunded.ToString();
        }

        // Applies current filter criteria to the order grid

        private void btnApply_Click(object sender, EventArgs e) { ApplyFilter(); }

        // Clears filters to defaults and refreshes the grid

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            cmbStatus.SelectedIndex = 0;
            cmbPayment.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Today.AddDays(-365);
            dtpTo.Value = DateTime.Today;
            ApplyFilter();
        }

        // Returns order bound to the selected grid row

        private Order SelectedOrder()
        {
            if (dgvOrders.CurrentRow == null) return null;
            return dgvOrders.CurrentRow.DataBoundItem as Order;
        }

        // Opens saved receipt file for selected order, regenerating if missing

        private void btnReprint_Click(object sender, EventArgs e)
        {
            Order selectedOrder = SelectedOrder();
            if (selectedOrder == null)
            {
                MessageBox.Show("Select an order first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string path = ReceiptService.GetReceiptPath(selectedOrder.OrderId);
                if (!File.Exists(path))
                {
                    path = ReceiptService.SaveToFile(selectedOrder);
                }
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the receipt: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Marks selected order as refunded after confirmation (managers only)

        private void btnRefund_Click(object sender, EventArgs e)
        {
            Order selectedOrder = SelectedOrder();
            if (selectedOrder == null) { return; }
            if (selectedOrder.Status == "Refunded")
            {
                MessageBox.Show("This order is already refunded.", "Already Refunded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult confirmRefund = MessageBox.Show("Refund order " + selectedOrder.OrderId + " ($" + selectedOrder.Total.ToString("F2") + ")?",
                "Confirm Refund", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmRefund != DialogResult.Yes) return;
            OrderService.Refund(selectedOrder.OrderId);
            ApplyFilter();
            BindKpis();
            MessageBox.Show("Order refunded.", "Refunded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Copies selected order into AppState.PendingOrder and opens Order Builder

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            Order selectedOrder = SelectedOrder();
            if (selectedOrder == null) { return; }
            Order copy = new Order
            {
                CustomerId = selectedOrder.CustomerId,
                CustomerName = selectedOrder.CustomerName,
                Discount = selectedOrder.Discount,
                PaymentMethod = selectedOrder.PaymentMethod
            };
            foreach (OrderItem sourceLine in selectedOrder.Items)
            {
                copy.Items.Add(new OrderItem
                {
                    ProductId = sourceLine.ProductId,
                    ProductName = sourceLine.ProductName,
                    Quantity = sourceLine.Quantity,
                    UnitPrice = sourceLine.UnitPrice,
                    Discount = sourceLine.Discount
                });
            }
            AppState.PendingOrder = copy;
            MainShellForm main = this.FindForm() as MainShellForm;
            if (main != null) main.LoadScreen(new OrderBuilderControl());
        }

        // Shows receipt-style order details in a message box

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            Order selectedOrder = SelectedOrder();
            if (selectedOrder == null)
            {
                MessageBox.Show("Select an order first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string details = ReceiptService.Build(selectedOrder);
            MessageBox.Show(details, "Order " + selectedOrder.OrderId, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        // Reapplies filter when search text changes

        private void txtSearch_TextChanged(object sender, EventArgs e) { ApplyFilter(); }

        // Reapplies filter when status dropdown changes

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { ApplyFilter(); }

        // Reapplies filter when payment dropdown changes

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e) { ApplyFilter(); }
    }
}
