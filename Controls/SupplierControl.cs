using System.Linq;
using System.Windows.Forms;
using DeskWise.Forms;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Supplier management: searchable grid plus a profile panel for the selected supplier.

    public partial class SupplierControl : UserControl
    {

        // Initializes supplier grid and profile panel

        public SupplierControl()
        {
            InitializeComponent();
        }

        // Sets up grid, role limits, and loads supplier list on first display

        private void SupplierControl_Load(object sender, System.EventArgs e)
        {
            SetupGrid();
            ApplyRoleRestrictions();
            RefreshGrid();
        }

        // Configures supplier list columns and selection handlers

        private void SetupGrid()
        {
            dgvSuppliers.AutoGenerateColumns = false;
            dgvSuppliers.Columns.Clear();
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 60 });
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Name", Width = 200 });
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ContactName", HeaderText = "Contact", Width = 140 });
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "Phone", Width = 130 });
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email", Width = 180 });
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersVisible = false;
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.SelectionChanged += (sender, args) => UpdateProfile();
            dgvSuppliers.CellDoubleClick += (sender, args) => { if (args.RowIndex >= 0) EditSelected(); };
        }

        // Disables add/edit/delete for Employee role (view-only)

        private void ApplyRoleRestrictions()
        {
            User currentUser = AppState.CurrentUser;
            bool isEmployeeOnly = currentUser != null && currentUser.Role == "Employee";
            btnAdd.Enabled = !isEmployeeOnly;
            btnEdit.Enabled = !isEmployeeOnly;
            btnDelete.Enabled = !isEmployeeOnly;
        }

        // Searches suppliers and refreshes grid and profile panel

        private void RefreshGrid()
        {
            var results = SupplierService.Search(txtSearch.Text);
            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = results;
            UpdateProfile();
        }

        // Fills the profile panel from the currently selected grid row

        private void UpdateProfile()
        {
            Supplier selectedSupplier = SelectedSupplier();
            if (selectedSupplier == null)
            {
                lblProfileName.Text = "Select a supplier";
                lblProfileContact.Text = string.Empty;
                lblProfilePhone.Text = string.Empty;
                lblProfileEmail.Text = string.Empty;
                lblProfileDelivery.Text = string.Empty;
                lblProfileProducts.Text = string.Empty;
                return;
            }
            lblProfileName.Text = selectedSupplier.Name;
            lblProfileContact.Text = "Contact: " + selectedSupplier.ContactName;
            lblProfilePhone.Text = "Phone: " + selectedSupplier.Phone;
            lblProfileEmail.Text = "Email: " + selectedSupplier.Email;
            lblProfileDelivery.Text = "Delivery: " + selectedSupplier.DeliveryInfo;
            int productCount = ProductService.All.Count(product => product.SupplierId == selectedSupplier.Id);
            lblProfileProducts.Text = productCount + " product(s) supplied";
        }

        // Returns supplier bound to current grid row, or null

        private Supplier SelectedSupplier()
        {
            if (dgvSuppliers.CurrentRow == null) return null;
            return dgvSuppliers.CurrentRow.DataBoundItem as Supplier;
        }

        // Refreshes grid when search text changes

        private void txtSearch_TextChanged(object sender, System.EventArgs e) { RefreshGrid(); }

        // Opens blank supplier edit dialog and refreshes list on save

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            using (SupplierEditForm editDialog = new SupplierEditForm(null))
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK) RefreshGrid();
            }
        }

        // Opens edit dialog for selected supplier

        private void btnEdit_Click(object sender, System.EventArgs e) { EditSelected(); }

        // Validates selection and opens supplier edit form

        private void EditSelected()
        {
            Supplier selectedSupplier = SelectedSupplier();
            if (selectedSupplier == null)
            {
                MessageBox.Show("Select a supplier first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SupplierEditForm editDialog = new SupplierEditForm(selectedSupplier))
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK) RefreshGrid();
            }
        }

        // Deletes supplier if no products still reference it

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            Supplier selectedSupplier = SelectedSupplier();
            if (selectedSupplier == null) return;
            int linkedProductCount = ProductService.All.Count(product => product.SupplierId == selectedSupplier.Id);
            if (linkedProductCount > 0)
            {
                MessageBox.Show("Cannot delete - " + linkedProductCount + " product(s) still reference this supplier.",
                    "In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirmDelete = MessageBox.Show("Delete " + selectedSupplier.Name + "?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDelete != DialogResult.Yes) return;
            SupplierService.Delete(selectedSupplier.Id);
            RefreshGrid();
        }
    }
}
