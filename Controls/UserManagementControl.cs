using System;
using System.Linq;
using System.Windows.Forms;
using DeskWise.Forms;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Admin-only screen to manage user accounts (add/edit/disable/reset).

    public partial class UserManagementControl : UserControl
    {

        // Initializes user management grid and toolbar

        public UserManagementControl()
        {
            InitializeComponent();
        }

        // Blocks non-admins and loads user list for Admin role

        private void UserManagementControl_Load(object sender, EventArgs e)
        {
            if (AppState.CurrentUser == null || AppState.CurrentUser.Role != "Admin")
            {
                foreach (Control childControl in this.Controls) childControl.Enabled = false;
                lblTitle.Text = "User Management — Admin Only";
                return;
            }
            SetupGrid();
            RefreshGrid();
        }

        // Configures user list columns and double-click to edit

        private void SetupGrid()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Clear();
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Username",    HeaderText = "Username",     Width = 130 });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DisplayName", HeaderText = "Display Name", Width = 150 });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Role",        HeaderText = "Role",         Width = 100 });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email",       HeaderText = "Email",        Width = 180 });
            dgvUsers.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "IsActive",   HeaderText = "Active",       Width = 70 });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastLogin",   HeaderText = "Last Login",   Width = 140, DefaultCellStyle = { Format = "yyyy-MM-dd HH:mm" } });
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.CellDoubleClick += (sender, args) => { if (args.RowIndex >= 0) EditSelected(); };
        }

        // Binds all users from AuthService to the grid

        private void RefreshGrid()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = AuthService.All.ToList();
        }

        // Returns user bound to current grid row

        private User SelectedUser()
        {
            if (dgvUsers.CurrentRow == null) return null;
            return dgvUsers.CurrentRow.DataBoundItem as User;
        }

        // Opens blank user edit dialog and refreshes grid on save

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (UserEditForm editDialog = new UserEditForm(null))
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK) RefreshGrid();
            }
        }

        // Opens edit dialog for selected user

        private void btnEdit_Click(object sender, EventArgs e) { EditSelected(); }

        // Opens user edit form for the selected row

        private void EditSelected()
        {
            User selectedUser = SelectedUser();
            if (selectedUser == null) return;
            using (UserEditForm editDialog = new UserEditForm(selectedUser))
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK) RefreshGrid();
            }
        }

        // Toggles IsActive on selected user (cannot disable own account)

        private void btnToggle_Click(object sender, EventArgs e)
        {
            User selectedUser = SelectedUser();
            if (selectedUser == null) return;
            if (string.Equals(selectedUser.Username, AppState.CurrentUser.Username, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot disable your own account.", "Blocked",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectedUser.IsActive = !selectedUser.IsActive;
            AuthService.Update(selectedUser);
            RefreshGrid();
        }

        // Prompts for new password and updates selected user via AuthService

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            User selectedUser = SelectedUser();
            if (selectedUser == null) return;
            string newPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "New password for " + selectedUser.Username + ":", "Reset Password", string.Empty);
            if (string.IsNullOrWhiteSpace(newPassword)) return;
            if (newPassword.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.", "Too Short",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectedUser.Password = newPassword;
            AuthService.Update(selectedUser);
            MessageBox.Show("Password updated.", "Done",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Deletes selected user after confirmation (cannot delete own account)

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User selectedUser = SelectedUser();
            if (selectedUser == null) return;
            if (string.Equals(selectedUser.Username, AppState.CurrentUser.Username, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot delete your own account.", "Blocked",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirmDelete = MessageBox.Show("Delete user " + selectedUser.Username + "?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDelete != DialogResult.Yes) return;
            AuthService.Delete(selectedUser.Username);
            RefreshGrid();
        }
    }
}
