using System.Drawing;
using System.Windows.Forms;

namespace DeskWise.Forms
{
    partial class UserEditForm
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblDisplayName = new Label();
            this.txtDisplayName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblRole = new Label();
            this.cmbRole = new ComboBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.lblPasswordHint = new Label();
            this.chkActive = new CheckBox();
            this.btnCancel = new Button();
            this.btnSave = new Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Text = "User Details";

            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Segoe UI", 9.75F);
            this.lblUsername.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblUsername.Location = new Point(20, 65);
            this.lblUsername.Text = "Username";

            this.txtUsername.Font = new Font("Segoe UI", 9.75F);
            this.txtUsername.Location = new Point(150, 61);
            this.txtUsername.Size = new Size(280, 25);

            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new Font("Segoe UI", 9.75F);
            this.lblDisplayName.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblDisplayName.Location = new Point(20, 101);
            this.lblDisplayName.Text = "Display Name";

            this.txtDisplayName.Font = new Font("Segoe UI", 9.75F);
            this.txtDisplayName.Location = new Point(150, 97);
            this.txtDisplayName.Size = new Size(280, 25);

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 9.75F);
            this.lblEmail.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblEmail.Location = new Point(20, 137);
            this.lblEmail.Text = "Email";

            this.txtEmail.Font = new Font("Segoe UI", 9.75F);
            this.txtEmail.Location = new Point(150, 133);
            this.txtEmail.Size = new Size(280, 25);

            this.lblRole.AutoSize = true;
            this.lblRole.Font = new Font("Segoe UI", 9.75F);
            this.lblRole.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblRole.Location = new Point(20, 173);
            this.lblRole.Text = "Role";

            this.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new Font("Segoe UI", 9.75F);
            this.cmbRole.Location = new Point(150, 169);
            this.cmbRole.Size = new Size(280, 25);

            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 9.75F);
            this.lblPassword.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblPassword.Location = new Point(20, 209);
            this.lblPassword.Text = "Password";

            this.txtPassword.Font = new Font("Segoe UI", 9.75F);
            this.txtPassword.Location = new Point(150, 205);
            this.txtPassword.Size = new Size(280, 25);
            this.txtPassword.UseSystemPasswordChar = true;

            this.lblPasswordHint.AutoSize = true;
            this.lblPasswordHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            this.lblPasswordHint.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblPasswordHint.Location = new Point(150, 237);
            this.lblPasswordHint.Text = "";

            this.chkActive.AutoSize = true;
            this.chkActive.Font = new Font("Segoe UI", 9.75F);
            this.chkActive.Location = new Point(150, 265);
            this.chkActive.Text = "Active account";

            this.btnCancel.BackColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            this.btnCancel.Font = new Font("Segoe UI", 9.75F);
            this.btnCancel.Location = new Point(240, 305);
            this.btnCancel.Size = new Size(90, 32);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.btnSave.BackColor = Color.FromArgb(37, 99, 235);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(340, 305);
            this.btnSave.Size = new Size(90, 32);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(460, 355);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblPasswordHint);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Name = "UserEditForm";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblDisplayName;
        private TextBox txtDisplayName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPasswordHint;
        private CheckBox chkActive;
        private Button btnCancel;
        private Button btnSave;
    }
}
