using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeskWise.Forms;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Inventory list with search, filters, KPIs, and product editing.
    // - 4 KPI cards across the top: Total Items / In Stock / Low Stock / Out of Stock.
    // - Search + Category + Status filters drive ProductService.Search.
    // - DataGridView shows the current filter; status cell is colour-coded.
    // - Add / Edit / Delete / Export all go via ProductService through ValidationService.

    public partial class InventoryControl : UserControl
    {

        private List<Product> _shown = new List<Product>();

        // Initializes inventory grid, filters, and toolbar

        public InventoryControl()
        {
            InitializeComponent();
        }

        // Sets up grid columns, filter dropdowns, role limits, and first data load

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            SetupGrid();
            PopulateFilterDropdowns();
            ApplyRoleRestrictions();
            RefreshAll();
        }

        // Builds inventory grid columns in code for predictable layout and status colouring

        private void SetupGrid()
        {
            dgvInventory.AutoGenerateColumns = false;
            dgvInventory.Columns.Clear();
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id",            HeaderText = "ID",       Width = 60 });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name",          HeaderText = "Name",     Width = 180 });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category",      HeaderText = "Category", Width = 110 });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SKU",           HeaderText = "SKU",      Width = 100 });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SalePrice",     HeaderText = "Price",    Width = 80, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity",      HeaderText = "Qty",      Width = 60 });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReorderLevel",  HeaderText = "Reorder",  Width = 70 });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StatusDisplay", HeaderText = "Status",   Width = 110 });
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvInventory.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvInventory.ColumnHeadersDefaultCellStyle.BackColor;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.CellFormatting += DgvInventory_CellFormatting;
            dgvInventory.CellDoubleClick += (sender, args) => { if (args.RowIndex >= 0) EditSelectedProduct(); };
        }

        // Applies background and text colours to the status column by stock level

        private void DgvInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewColumn col = dgvInventory.Columns[e.ColumnIndex];
            if (col.DataPropertyName != "StatusDisplay") return;
            string status = e.Value != null ? e.Value.ToString() : "";
            switch (status)
            {
                case "Out of Stock":
                    e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                    e.CellStyle.ForeColor = Color.FromArgb(153, 27, 27);
                    break;
                case "Low Stock":
                    e.CellStyle.BackColor = Color.FromArgb(254, 243, 199);
                    e.CellStyle.ForeColor = Color.FromArgb(146, 64, 14);
                    break;
                default:
                    e.CellStyle.BackColor = Color.FromArgb(220, 252, 231);
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                    break;
            }
        }

        // Loads category and status filter dropdown options

        private void PopulateFilterDropdowns()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All Categories");
            foreach (string cat in ProductService.GetCategories())
            {
                cmbCategory.Items.Add(cat);
            }
            cmbCategory.SelectedIndex = 0;
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "All Statuses", "In Stock", "Low Stock", "Out of Stock" });
            cmbStatus.SelectedIndex = 0;
        }

        // Disables add/edit/delete for Employee role (read-only inventory)

        private void ApplyRoleRestrictions()
        {
            User currentUser = AppState.CurrentUser;
            bool isEmployeeOnly = currentUser != null && currentUser.Role == "Employee";
            if (isEmployeeOnly)
            {
                btnAddProduct.Enabled = false;
                btnEditProduct.Enabled = false;
                btnDeleteProduct.Enabled = false;
            }
        }

        // Updates KPI cards and reapplies search/category/status filters

        private void RefreshAll()
        {
            UpdateKpis();
            ApplyFilters();
        }

        // Fills stock KPI labels from full product catalogue counts

        private void UpdateKpis()
        {
            IReadOnlyList<Product> all = ProductService.All;
            lblTotalItemsValue.Text = all.Count.ToString();
            lblInStockValue.Text    = all.Count(product => product.Status == StockStatus.InStock).ToString();
            lblLowStockValue.Text   = all.Count(product => product.Status == StockStatus.LowStock).ToString();
            lblOutStockValue.Text   = all.Count(product => product.Status == StockStatus.OutOfStock).ToString();
        }

        // Runs ProductService.Search with current filters and binds results to grid

        private void ApplyFilters()
        {
            string category = cmbCategory.SelectedItem != null ? cmbCategory.SelectedItem.ToString() : "All Categories";
            string status = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "All Statuses";
            _shown = ProductService.Search(txtSearch.Text, category, status);
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = _shown;
        }

        // Returns product from current grid row selection

        private Product GetSelectedProduct()
        {
            if (dgvInventory.CurrentRow == null) return null;
            return dgvInventory.CurrentRow.DataBoundItem as Product;
        }

        // Reapplies filters when search text changes

        private void txtSearch_TextChanged(object sender, EventArgs e) { ApplyFilters(); }

        // Reapplies filters when category changes

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { ApplyFilters(); }

        // Reapplies filters when status changes

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { ApplyFilters(); }

        // Opens blank product edit form and refreshes list on save

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (ProductEditForm editDialog = new ProductEditForm())
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    PopulateFilterDropdowns();
                    RefreshAll();
                }
            }
        }

        // Opens edit form for selected product

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditSelectedProduct();
        }

        // Validates selection and opens product edit dialog

        private void EditSelectedProduct()
        {
            Product selectedProduct = GetSelectedProduct();
            if (selectedProduct == null)
            {
                MessageBox.Show("Select a product first.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (ProductEditForm editDialog = new ProductEditForm(selectedProduct))
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    PopulateFilterDropdowns();
                    RefreshAll();
                }
            }
        }

        // Deletes selected product after confirmation

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = GetSelectedProduct();
            if (selectedProduct == null)
            {
                MessageBox.Show("Select a product first.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult confirm = MessageBox.Show("Delete " + selectedProduct.Name + "?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;
            ProductService.Delete(selectedProduct.Id);
            RefreshAll();
        }

        // Writes currently filtered products to a CSV file chosen by the user

        private void btnExportInventory_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV file (*.csv)|*.csv";
                saveDialog.FileName = "inventory_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";
                if (saveDialog.ShowDialog() != DialogResult.OK) return;
                try
                {
                    StringBuilder csvContent = new StringBuilder();
                    csvContent.AppendLine("ID,Name,Category,SKU,Price,Quantity,Reorder,Status");
                    foreach (Product product in _shown)
                    {
                        csvContent.AppendLine(string.Format("{0},\"{1}\",\"{2}\",{3},{4},{5},{6},{7}",
                            product.Id, product.Name, product.Category, product.SKU, product.SalePrice, product.Quantity, product.ReorderLevel, product.StatusDisplay));
                    }
                    File.WriteAllText(saveDialog.FileName, csvContent.ToString());
                    MessageBox.Show("Exported " + _shown.Count + " items.", "Export Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not write export: " + ex.Message, "Export Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
