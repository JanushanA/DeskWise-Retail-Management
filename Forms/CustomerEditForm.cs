using System;
using System.Windows.Forms;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Forms
{
    // Modal dialog for adding or editing a Customer.
    public partial class CustomerEditForm : Form
    {
        private readonly Customer _existing;

        // Opens in add mode when existing is null; otherwise pre-fills fields for edit.
        public CustomerEditForm(Customer existing)
        {
            InitializeComponent();
            _existing = existing;
            if (_existing != null)
            {
                this.Text = "Edit Customer";
                txtName.Text = existing.Name;
                txtPhone.Text = existing.Phone;
                txtEmail.Text = existing.Email;
                nudLoyalty.Value = Math.Max(0, existing.LoyaltyPoints);
                txtNotes.Text = existing.Notes;
            }
            else
            {
                this.Text = "Add Customer";
            }
        }

        // Validate inputs, then create or update the customer record.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // ---- Validation ----
            if (!ValidationService.IsValidName(txtName.Text))
            {
                MessageBox.Show("Please enter a valid name (letters or digits required).",
                    "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (!ValidationService.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (!ValidationService.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Please enter a valid phone number.", "Invalid Phone",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            // ---- Save ----
            bool isNew = (_existing == null);
            Customer target = isNew ? new Customer() : _existing;
            target.Name = txtName.Text.Trim();
            target.Phone = txtPhone.Text.Trim();
            target.Email = txtEmail.Text.Trim();
            target.LoyaltyPoints = (int)nudLoyalty.Value;
            target.Notes = txtNotes.Text.Trim();

            if (isNew)
            {
                target.Id = CustomerService.NextId();
                CustomerService.Add(target);
            }
            else
            {
                CustomerService.Update(target);
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
