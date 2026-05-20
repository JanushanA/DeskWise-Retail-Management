using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;

using System.Windows.Forms;

using DeskWise.Models;

using DeskWise.Services;



namespace DeskWise.Forms

{

    // Create or view a Purchase Order. Items are added from the product catalog and

    // editable for quantity + cost per unit. Totals refresh as the user edits.

    public partial class PurchaseOrderForm : Form

    {

        private readonly PurchaseOrder _purchaseOrder;

        private readonly bool _isNew;

        private BindingList<PurchaseOrderItem> _items;



        // existing null = create mode; otherwise load the given PO for view/edit.

        public PurchaseOrderForm(PurchaseOrder existing)

        {

            InitializeComponent();

            _isNew = (existing == null);

            _purchaseOrder = existing ?? new PurchaseOrder

            {

                CreatedBy = AppState.CurrentUser != null ? AppState.CurrentUser.Username : "system",

                Status = "Draft"

            };

            _items = new BindingList<PurchaseOrderItem>(_purchaseOrder.Items);

        }



        // Wire up dropdowns, grid, and header fields once the form is shown.

        private void PurchaseOrderForm_Load(object sender, EventArgs e)

        {

            // Bind supplier dropdown

            cmbSupplier.DataSource = SupplierService.All.ToList();

            cmbSupplier.DisplayMember = "Name";

            cmbSupplier.ValueMember = "Id";



            // Bind status dropdown

            cmbStatus.Items.AddRange(new object[] { "Draft", "Sent", "Pending", "Received", "Cancelled" });



            SetupItemsGrid();



            if (!_isNew)

            {

                this.Text = "Purchase Order — " + _purchaseOrder.Id;

                lblPoId.Text = _purchaseOrder.Id;

                cmbSupplier.SelectedValue = _purchaseOrder.SupplierId;

                dtpExpected.Value = _purchaseOrder.ExpectedDelivery;

                cmbStatus.SelectedItem = _purchaseOrder.Status ?? "Draft";

                txtNotes.Text = _purchaseOrder.Notes;

            }

            else

            {

                this.Text = "Create Purchase Order";

                lblPoId.Text = "(new)";

                dtpExpected.Value = DateTime.Now.AddDays(7);

                cmbStatus.SelectedItem = "Draft";

            }



            dgvItems.DataSource = _items;

            RecalculateTotal();

        }



        // Define line-item columns and hook grid edit/remove handlers.

        private void SetupItemsGrid()

        {

            dgvItems.AutoGenerateColumns = false;

            dgvItems.Columns.Clear();



            dgvItems.Columns.Add(new DataGridViewTextBoxColumn

            { DataPropertyName = "ProductName", HeaderText = "Product", Width = 240, ReadOnly = true });

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn

            { DataPropertyName = "QuantityOrdered", HeaderText = "Qty", Width = 70 });

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn

            { DataPropertyName = "CostPerUnit", HeaderText = "Cost", Width = 90, DefaultCellStyle = { Format = "C2" } });

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn

            { DataPropertyName = "Subtotal", HeaderText = "Subtotal", Width = 100, ReadOnly = true, DefaultCellStyle = { Format = "C2" } });

            DataGridViewButtonColumn removeCol = new DataGridViewButtonColumn

            { HeaderText = "", Text = "X", UseColumnTextForButtonValue = true, Width = 40, Name = "colRemove" };

            dgvItems.Columns.Add(removeCol);



            dgvItems.RowHeadersVisible = false;

            dgvItems.AllowUserToAddRows = false;

            dgvItems.CellEndEdit += DgvItems_CellEndEdit;

            dgvItems.CellContentClick += DgvItems_CellContentClick;

        }



        // Clamp invalid numeric edits so totals stay correct.

        private void DgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0 || e.RowIndex >= _items.Count) return;

            PurchaseOrderItem lineItem = _items[e.RowIndex];

            if (lineItem.QuantityOrdered < 1) lineItem.QuantityOrdered = 1;

            if (lineItem.CostPerUnit < 0) lineItem.CostPerUnit = 0;

            dgvItems.Refresh();

            RecalculateTotal();

        }



        // Remove a line item when the user clicks the X button column.

        private void DgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0) return;

            if (dgvItems.Columns[e.ColumnIndex].Name == "colRemove")

            {

                _items.RemoveAt(e.RowIndex);

                RecalculateTotal();

            }

        }



        // Open the product picker and add or increment a line on the PO.

        private void btnAddItem_Click(object sender, EventArgs e)

        {

            if (ProductService.All.Count == 0)

            {

                MessageBox.Show("No products in catalog.", "Empty",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }



            using (ProductPickerForm picker = new ProductPickerForm())

            {

                if (picker.ShowDialog(this) != DialogResult.OK || picker.SelectedProduct == null)

                {

                    return;

                }



                Product pickedProduct = picker.SelectedProduct;

                PurchaseOrderItem existingLine = _items.FirstOrDefault(line => line.ProductId == pickedProduct.Id);

                if (existingLine != null)

                {

                    existingLine.QuantityOrdered++;

                    dgvItems.Refresh();

                }

                else

                {

                    _items.Add(new PurchaseOrderItem

                    {

                        ProductId = pickedProduct.Id,

                        ProductName = pickedProduct.Name,

                        QuantityOrdered = 1,

                        CostPerUnit = pickedProduct.CostPrice

                    });

                }

                RecalculateTotal();

            }

        }



        // Sum line subtotals and update the total label.

        private void RecalculateTotal()

        {

            decimal total = _items.Sum(lineItem => lineItem.Subtotal);

            lblTotal.Text = "Total: " + total.ToString("C2");

        }



        // Validate header fields and line items, then persist the purchase order.

        private void btnSave_Click(object sender, EventArgs e)

        {

            // ---- Validation ----

            if (cmbSupplier.SelectedValue == null)

            {

                MessageBox.Show("Please choose a supplier.", "Missing Supplier",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            if (_items.Count == 0)

            {

                MessageBox.Show("Add at least one item.", "Empty Order",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            // ---- Save ----

            Supplier selectedSupplier = cmbSupplier.SelectedItem as Supplier;

            _purchaseOrder.SupplierId = selectedSupplier.Id;

            _purchaseOrder.SupplierName = selectedSupplier.Name;

            _purchaseOrder.ExpectedDelivery = dtpExpected.Value;

            _purchaseOrder.Status = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "Draft";

            _purchaseOrder.Notes = txtNotes.Text;

            _purchaseOrder.Items = _items.ToList();



            if (_isNew) PurchaseOrderService.Add(_purchaseOrder);

            else PurchaseOrderService.Update(_purchaseOrder);



            this.DialogResult = DialogResult.OK;

            this.Close();

        }



        // Close without saving changes.

        private void btnCancel_Click(object sender, EventArgs e)

        {

            this.DialogResult = DialogResult.Cancel;

            this.Close();

        }

    }

}


