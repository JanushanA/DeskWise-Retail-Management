using System;

using System.Windows.Forms;

using DeskWise.Models;

using DeskWise.Services;



namespace DeskWise.Forms

{

    // Add/Edit user dialog. When _existing is null we're creating a new user.

    public partial class UserEditForm : Form

    {

        private readonly User _existing;



        // Opens in add or edit mode; username is locked when editing an existing user.

        public UserEditForm(User existing)

        {

            InitializeComponent();

            _existing = existing;

            cmbRole.Items.AddRange(new object[] { "Admin", "Manager", "Employee" });



            if (_existing != null)

            {

                this.Text = "Edit User";

                txtUsername.Text = _existing.Username;

                txtUsername.Enabled = false; // username acts as the key, don't allow rename

                txtDisplayName.Text = _existing.DisplayName;

                txtEmail.Text = _existing.Email;

                cmbRole.SelectedItem = _existing.Role;

                chkActive.Checked = _existing.IsActive;

                lblPasswordHint.Text = "(leave blank to keep current password)";

            }

            else

            {

                this.Text = "Add User";

                cmbRole.SelectedItem = "Employee";

                chkActive.Checked = true;

            }

        }



        // Validate inputs, then create a new user or update the existing one.

        private void btnSave_Click(object sender, EventArgs e)

        {

            // ---- Validation ----

            if (!ValidationService.IsValidName(txtUsername.Text))

            {

                MessageBox.Show("Please enter a valid username.", "Invalid Username",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUsername.Focus();

                return;

            }

            if (!ValidationService.IsValidName(txtDisplayName.Text))

            {

                MessageBox.Show("Please enter a valid display name.", "Invalid Display Name",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDisplayName.Focus();

                return;

            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !ValidationService.IsValidEmail(txtEmail.Text))

            {

                MessageBox.Show("Please enter a valid email address.", "Invalid Email",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtEmail.Focus();

                return;

            }

            if (cmbRole.SelectedItem == null)

            {

                MessageBox.Show("Please choose a role.", "Role Required",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            bool isNew = (_existing == null);

            if (isNew)

            {

                if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 4)

                {

                    MessageBox.Show("Password is required and must be at least 4 characters.", "Password",

                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtPassword.Focus();

                    return;

                }

                if (AuthService.GetByUsername(txtUsername.Text.Trim()) != null)

                {

                    MessageBox.Show("That username already exists.", "Duplicate",

                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                // ---- Save (new user) ----

                User newUser = new User

                {

                    Username = txtUsername.Text.Trim(),

                    Password = txtPassword.Text,

                    DisplayName = txtDisplayName.Text.Trim(),

                    Role = cmbRole.SelectedItem.ToString(),

                    Email = txtEmail.Text.Trim(),

                    IsActive = chkActive.Checked

                };

                AuthService.Add(newUser);

            }

            else

            {

                // ---- Save (existing user) ----

                _existing.DisplayName = txtDisplayName.Text.Trim();

                _existing.Email = txtEmail.Text.Trim();

                _existing.Role = cmbRole.SelectedItem.ToString();

                _existing.IsActive = chkActive.Checked;

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))

                {

                    if (txtPassword.Text.Length < 4)

                    {

                        MessageBox.Show("Password must be at least 4 characters.", "Password",

                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;

                    }

                    _existing.Password = txtPassword.Text;

                }

                AuthService.Update(_existing);

            }



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


