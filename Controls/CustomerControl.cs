using System;
using System.Linq;
using System.Windows.Forms;
using DeskWise.Forms;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Customer management screen. Left side: searchable list of customers in a grid.
    // Right side: read-only profile card for the currently selected customer.

    public partial class CustomerControl : UserControl
    {

        // Initializes customer grid and profile panel

        public CustomerControl()
        {
            InitializeComponent();
        }

        // Sets up grid, role-based buttons, and initial customer list on load

        private void CustomerControl_Load(object sender, EventArgs e)
        {
            TextBoxHelper.SetSearchPlaceholder(txtSearch);
            SetupGrid();
            ApplyRoleRestrictions();
            RefreshGrid();
        }

        // Configures customer list columns and selection handlers

        private void SetupGrid()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.Columns.Clear();
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id",            HeaderText = "ID",         Width = 60 });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name",          HeaderText = "Name",       Width = 180 });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone",         HeaderText = "Phone",      Width = 130 });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email",         HeaderText = "Email",      Width = 180 });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LoyaltyPoints", HeaderText = "Loyalty",    Width = 70 });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastPurchase",  HeaderText = "Last Purchase", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" } });
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.SelectionChanged += (sender, args) => UpdateProfile();
            dgvCustomers.CellDoubleClick += (sender, args) => { if (args.RowIndex >= 0) EditSelected(); };
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

        // Searches customers by text and refreshes grid and profile panel

        private void RefreshGrid()
        {
            var results = CustomerService.Search(txtSearch.Text);
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = results;
            UpdateProfile();
        }

        // Updates right-hand profile labels from the selected customer row

        private void UpdateProfile()
        {
            Customer selectedCustomer = SelectedCustomer();
            if (selectedCustomer == null)
            {
                lblProfileName.Text = "Select a customer";
                lblProfilePhone.Text = string.Empty;
                lblProfileEmail.Text = string.Empty;
                lblProfileLoyalty.Text = string.Empty;
                lblProfileSpend.Text = string.Empty;
                lblProfileLast.Text = string.Empty;
                txtProfileNotes.Text = string.Empty;
                return;
            }
            lblProfileName.Text = selectedCustomer.Name;
            lblProfilePhone.Text = "Phone: " + selectedCustomer.Phone;
            lblProfileEmail.Text = "Email: " + selectedCustomer.Email;
            lblProfileLoyalty.Text = "Loyalty: " + selectedCustomer.LoyaltyPoints + " pts";

            // Aggregate completed order spend and order count for this customer
            decimal totalSpend = OrderService.All
                .Where(order => order.CustomerId == selectedCustomer.Id && order.Status == "Completed")
                .Sum(order => order.Total);
            int orderCount = OrderService.All.Count(order => order.CustomerId == selectedCustomer.Id);
            lblProfileSpend.Text = "Total spend: " + totalSpend.ToString("C2") + "  (" + orderCount + " orders)";
            lblProfileLast.Text = "Last purchase: " + (selectedCustomer.LastPurchase.HasValue
                ? selectedCustomer.LastPurchase.Value.ToString("yyyy-MM-dd") : "never");
            txtProfileNotes.Text = selectedCustomer.Notes ?? string.Empty;
        }

        // Returns the customer bound to the current grid row, or null

        private Customer SelectedCustomer()
        {
            if (dgvCustomers.CurrentRow == null) return null;
            return dgvCustomers.CurrentRow.DataBoundItem as Customer;
        }

        // Refreshes grid when search text changes

        private void txtSearch_TextChanged(object sender, EventArgs e) { RefreshGrid(); }

        // Opens blank customer edit dialog and refreshes list on save

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (CustomerEditForm editDialog = new CustomerEditForm(null))
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        // Opens edit dialog for the selected customer

        private void btnEdit_Click(object sender, EventArgs e) { EditSelected(); }

        // Validates selection and opens customer edit form for the current row

        private void EditSelected()
        {
            Customer selectedCustomer = SelectedCustomer();
            if (selectedCustomer == null)
            {
                MessageBox.Show("Select a customer first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (CustomerEditForm editDialog = new CustomerEditForm(selectedCustomer))
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        // Deletes selected customer after confirmation

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = SelectedCustomer();
            if (selectedCustomer == null) return;
            DialogResult confirmDelete = MessageBox.Show("Delete " + selectedCustomer.Name + "?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDelete != DialogResult.Yes) return;
            CustomerService.Delete(selectedCustomer.Id);
            RefreshGrid();
        }
    }
}
