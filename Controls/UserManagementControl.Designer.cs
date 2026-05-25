using System.Drawing;
using System.Windows.Forms;

namespace DeskWise.Controls
{
    partial class UserManagementControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.pnlToolbar = new Panel();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnToggle = new Button();
            this.btnResetPassword = new Button();
            this.btnDelete = new Button();
            this.dgvUsers = new DataGridView();
            this.pnlPermissions = new Panel();
            this.lblPermissionsTitle = new Label();
            this.dgvPermissions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).BeginInit();
            this.SuspendLayout();

            // header
            this.pnlHeader.BackColor = Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.Padding = new Padding(20);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new Point(20, 12);
            this.lblTitle.Text = "User Management";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new Font("Segoe UI", 9.75F);
            this.lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new Point(22, 45);
            this.lblSubtitle.Text = "Create accounts, change roles, reset passwords, disable access.";

            // toolbar
            this.pnlToolbar.BackColor = Color.FromArgb(248, 250, 252);
            this.pnlToolbar.Dock = DockStyle.Top;
            this.pnlToolbar.Height = 60;
            this.pnlToolbar.Padding = new Padding(20, 12, 20, 12);
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnResetPassword);
            this.pnlToolbar.Controls.Add(this.btnToggle);
            this.pnlToolbar.Controls.Add(this.btnEdit);
            this.pnlToolbar.Controls.Add(this.btnAdd);

            this.btnAdd.BackColor = Color.FromArgb(37, 99, 235);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            this.btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.Location = new Point(20, 12);
            this.btnAdd.Size = new Size(120, 34);
            this.btnAdd.Text = "+ Add User";
            this.btnAdd.UseVisualStyleBackColor = false;

            this.btnEdit.BackColor = Color.White;
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            this.btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnEdit.ForeColor = Color.FromArgb(15, 23, 42);
            this.btnEdit.Location = new Point(140, 12);
            this.btnEdit.Size = new Size(120, 34);
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;

            this.btnToggle.BackColor = Color.White;
            this.btnToggle.FlatStyle = FlatStyle.Flat;
            this.btnToggle.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            this.btnToggle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnToggle.ForeColor = Color.FromArgb(15, 23, 42);
            this.btnToggle.Location = new Point(235, 12);
            this.btnToggle.Size = new Size(120, 34);
            this.btnToggle.Text = "Enable / Disable";
            this.btnToggle.UseVisualStyleBackColor = false;

            this.btnResetPassword.BackColor = Color.White;
            this.btnResetPassword.FlatStyle = FlatStyle.Flat;
            this.btnResetPassword.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            this.btnResetPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnResetPassword.ForeColor = Color.FromArgb(15, 23, 42);
            this.btnResetPassword.Location = new Point(365, 12);
            this.btnResetPassword.Size = new Size(120, 34);
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;

            this.btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            this.btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.Location = new Point(495, 12);
            this.btnDelete.Size = new Size(120, 34);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnAdd.Click           += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click          += new System.EventHandler(this.btnEdit_Click);
            this.btnToggle.Click        += new System.EventHandler(this.btnToggle_Click);
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            this.btnDelete.Click        += new System.EventHandler(this.btnDelete_Click);

            // grid
            this.dgvUsers.BackgroundColor = Color.White;
            this.dgvUsers.BorderStyle = BorderStyle.None;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F);
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Font = new Font("Segoe UI", 9.75F);
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.RowTemplate.Height = 30;
            this.dgvUsers.Dock = DockStyle.Fill;

            // permissions panel
            this.pnlPermissions.Dock = DockStyle.Bottom;
            this.pnlPermissions.BackColor = Color.White;
            this.pnlPermissions.BorderStyle = BorderStyle.FixedSingle;
            this.pnlPermissions.Height = 220;
            this.pnlPermissions.Padding = new Padding(20, 10, 20, 10);
            this.pnlPermissions.Controls.Add(this.dgvPermissions);
            this.pnlPermissions.Controls.Add(this.lblPermissionsTitle);

            this.lblPermissionsTitle.AutoSize = true;
            this.lblPermissionsTitle.Font = new Font("Segoe UI Semibold", 10.5F);
            this.lblPermissionsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblPermissionsTitle.Location = new Point(20, 8);
            this.lblPermissionsTitle.Text = "Role Permissions";

            this.dgvPermissions.AllowUserToAddRows = false;
            this.dgvPermissions.AllowUserToDeleteRows = false;
            this.dgvPermissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPermissions.BackgroundColor = Color.White;
            this.dgvPermissions.BorderStyle = BorderStyle.None;
            this.dgvPermissions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            this.dgvPermissions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F);
            this.dgvPermissions.Dock = DockStyle.Bottom;
            this.dgvPermissions.EnableHeadersVisualStyles = false;
            this.dgvPermissions.Height = 175;
            this.dgvPermissions.ReadOnly = true;
            this.dgvPermissions.RowHeadersVisible = false;
            this.dgvPermissions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // control
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlPermissions);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UserManagementControl";
            this.Size = new Size(1100, 700);
            this.Load += new System.EventHandler(this.UserManagementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlToolbar;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnToggle;
        private Button btnResetPassword;
        private Button btnDelete;
        private DataGridView dgvUsers;
        private Panel pnlPermissions;
        private Label lblPermissionsTitle;
        private DataGridView dgvPermissions;
    }
}
