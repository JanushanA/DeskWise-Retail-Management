using System;
using System.Linq;
using System.Windows.Forms;
using DeskWise.Forms;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Purchase Orders screen: list + filter POs, create new POs, mark received,
    // and an auto-reorder helper for low-stock products.

    public partial class PurchaseOrdersControl : UserControl
    {

        // Initializes PO grid, filters, and reorder suggestion panel

        public PurchaseOrdersControl()
        {
            InitializeComponent();
        }

        // Sets up grid, filters, role limits, and loads PO list and KPIs on load

        private void PurchaseOrdersControl_Load(object sender, EventArgs e)
        {
            TextBoxHelper.SetSearchPlaceholder(txtSearch);
            SetupGrid();
            PopulateFilters();
            ApplyRoleRestrictions();
            RefreshGrid();
            BindKpis();
            RefreshReorderSuggestions();
        }

        // Configures purchase order list columns and status formatting

        private void SetupGrid()
        {
            dgvPos.AutoGenerateColumns = false;
            dgvPos.Columns.Clear();
            dgvPos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id",               HeaderText = "PO ID",     Width = 110 });
            dgvPos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SupplierName",     HeaderText = "Supplier",  Width = 180 });
            dgvPos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DateCreated",      HeaderText = "Created",   Width = 120, DefaultCellStyle = { Format = "yyyy-MM-dd" } });
            dgvPos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ExpectedDelivery", HeaderText = "Expected",  Width = 120, DefaultCellStyle = { Format = "yyyy-MM-dd" } });
            dgvPos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalCost",        HeaderText = "Total",     Width = 110, DefaultCellStyle = { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvPos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status",           HeaderText = "Status",    Width = 100 });
            dgvPos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CreatedBy",        HeaderText = "Created By", Width = 110 });
            dgvPos.ReadOnly = true;
            dgvPos.RowHeadersVisible = false;
            dgvPos.AllowUserToAddRows = false;
            dgvPos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPos.MultiSelect = false;
            dgvPos.CellFormatting += DgvPos_CellFormatting;
        }

        // Colours PO status column by workflow state

        private void DgvPos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPos.Columns[e.ColumnIndex].DataPropertyName != "Status") return;
            string status = e.Value as string;
            switch (status)
            {
                case "Received":  e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(21, 128, 61);  break;
                case "Sent":      e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);  break;
                case "Pending":   e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(202, 138, 4);  break;
                case "Cancelled": e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);  break;
                default:          e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);  break;
            }
        }

        // Fills PO status filter dropdown

        private void PopulateFilters()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "All", "Draft", "Sent", "Pending", "Received", "Cancelled" });
            cmbStatus.SelectedItem = "All";
        }

        // Restricts create, receive, delete, and auto-PO to Admin and Manager

        private void ApplyRoleRestrictions()
        {
            User currentUser = AppState.CurrentUser;
            bool canManage = currentUser != null && (currentUser.Role == "Admin" || currentUser.Role == "Manager");
            btnCreate.Enabled = canManage;
            btnMarkReceived.Enabled = canManage;
            btnDelete.Enabled = canManage;
            btnGeneratePo.Enabled = canManage;
        }

        // Searches POs by text and status filter, then binds grid

        private void RefreshGrid()
        {
            string status = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "All";
            var results = PurchaseOrderService.Search(txtSearch.Text, status);
            dgvPos.DataSource = null;
            dgvPos.DataSource = results;
        }

        // Updates PO count KPI labels by status

        private void BindKpis()
        {
            lblKpiTotal.Text     = PurchaseOrderService.All.Count.ToString();
            lblKpiDraft.Text     = PurchaseOrderService.CountByStatus("Draft").ToString();
            lblKpiSent.Text      = PurchaseOrderService.CountByStatus("Sent").ToString();
            lblKpiPending.Text   = PurchaseOrderService.CountByStatus("Pending").ToString();
            lblKpiReceived.Text  = PurchaseOrderService.CountByStatus("Received").ToString();
            lblKpiCancelled.Text = PurchaseOrderService.CountByStatus("Cancelled").ToString();
        }

        // Binds low-stock product list to reorder suggestion grid

        private void RefreshReorderSuggestions()
        {
            var lowStock = ProductService.GetLowStock();
            dgvReorder.AutoGenerateColumns = false;
            if (dgvReorder.Columns.Count == 0)
            {
                dgvReorder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name",       HeaderText = "Product",      Width = 220 });
                dgvReorder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category",   HeaderText = "Category",     Width = 110 });
                dgvReorder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity",   HeaderText = "On Hand",      Width = 75 });
                dgvReorder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReorderLevel", HeaderText = "Reorder Lvl", Width = 90 });
            }
            dgvReorder.RowHeadersVisible = false;
            dgvReorder.ReadOnly = true;
            dgvReorder.AllowUserToAddRows = false;
            dgvReorder.DataSource = null;
            dgvReorder.DataSource = lowStock;
            lblReorderCount.Text = lowStock.Count + " item(s) recommended for reorder";
        }

        // Returns PO from current grid row selection

        private PurchaseOrder SelectedPurchaseOrder()
        {
            if (dgvPos.CurrentRow == null) return null;
            return dgvPos.CurrentRow.DataBoundItem as PurchaseOrder;
        }

        // Refreshes PO grid when search text changes

        private void txtSearch_TextChanged(object sender, EventArgs e) { RefreshGrid(); }

        // Refreshes PO grid when status filter changes

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { RefreshGrid(); }

        // Opens blank purchase order form and refreshes lists on save

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (PurchaseOrderForm editDialog = new PurchaseOrderForm(null))
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    RefreshGrid();
                    BindKpis();
                    RefreshReorderSuggestions();
                }
            }
        }

        // Opens purchase order form in view/edit mode for selected row

        private void btnView_Click(object sender, EventArgs e)
        {
            PurchaseOrder selectedPurchaseOrder = SelectedPurchaseOrder();
            if (selectedPurchaseOrder == null) return;
            using (PurchaseOrderForm editDialog = new PurchaseOrderForm(selectedPurchaseOrder))
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    RefreshGrid();
                    BindKpis();
                }
            }
        }

        // Marks selected PO as received and updates inventory stock

        private void btnMarkReceived_Click(object sender, EventArgs e)
        {
            PurchaseOrder selectedPurchaseOrder = SelectedPurchaseOrder();
            if (selectedPurchaseOrder == null)
            {
                MessageBox.Show("Select a purchase order first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (selectedPurchaseOrder.Status == "Received")
            {
                MessageBox.Show("This PO is already marked received.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult confirmReceive = MessageBox.Show(
                "Mark " + selectedPurchaseOrder.Id + " as received? Stock will be added to inventory.",
                "Confirm Receive", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmReceive != DialogResult.Yes) return;
            PurchaseOrderService.MarkReceived(selectedPurchaseOrder.Id);
            MessageBox.Show("Stock updated.", "Received",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshGrid();
            BindKpis();
            RefreshReorderSuggestions();
        }

        // Deletes selected PO if not already received

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PurchaseOrder selectedPurchaseOrder = SelectedPurchaseOrder();
            if (selectedPurchaseOrder == null) return;
            if (selectedPurchaseOrder.Status == "Received")
            {
                MessageBox.Show("Cannot delete a received PO.", "Blocked",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirmDelete = MessageBox.Show("Delete " + selectedPurchaseOrder.Id + "?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDelete != DialogResult.Yes) return;
            PurchaseOrderService.Delete(selectedPurchaseOrder.Id);
            RefreshGrid();
            BindKpis();
        }

        // Creates draft POs grouped by supplier for all low-stock products with suppliers

        private void btnGeneratePo_Click(object sender, EventArgs e)
        {
            var lowStock = ProductService.GetLowStock();
            if (lowStock.Count == 0)
            {
                MessageBox.Show("No low-stock items to reorder.", "Nothing to do",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Group low-stock products by supplier so we create one PO per supplier.
            var groups = lowStock
                .Where(product => product.SupplierId > 0)
                .GroupBy(product => product.SupplierId)
                .ToList();
            if (groups.Count == 0)
            {
                MessageBox.Show("Low-stock products have no supplier linked. Edit them to add suppliers first.",
                    "No Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int created = 0;
            string staff = AppState.CurrentUser != null ? AppState.CurrentUser.Username : "system";
            foreach (var supplierGroup in groups)
            {
                Supplier supplier = SupplierService.GetById(supplierGroup.Key);
                if (supplier == null) continue;
                PurchaseOrder newPurchaseOrder = new PurchaseOrder();
                newPurchaseOrder.SupplierId = supplier.Id;
                newPurchaseOrder.SupplierName = supplier.Name;
                newPurchaseOrder.CreatedBy = staff;
                newPurchaseOrder.Status = "Draft";
                newPurchaseOrder.Notes = "Auto-generated from low-stock recommendation.";
                foreach (Product product in supplierGroup)
                {
                    int suggestedQuantity = Math.Max(1, (product.ReorderLevel * 2) - product.Quantity);
                    newPurchaseOrder.Items.Add(new PurchaseOrderItem
                    {
                        ProductId = product.Id,
                        ProductName = product.Name,
                        QuantityOrdered = suggestedQuantity,
                        CostPerUnit = product.CostPrice
                    });
                }
                PurchaseOrderService.Add(newPurchaseOrder);
                created++;
            }
            MessageBox.Show(created + " purchase order(s) generated as Draft. Review and send.",
                "POs Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshGrid();
            BindKpis();
        }
    }
}
