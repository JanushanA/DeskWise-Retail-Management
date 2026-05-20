using System;
using System.Windows.Forms;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Forms
{
    // Modal dialog for adding or editing a Supplier.
    public partial class SupplierEditForm : Form
    {
        private readonly Supplier _existing;

        // Opens in add mode when existing is null; otherwise pre-fills fields for edit.
        public SupplierEditForm(Supplier existing)
        {
            InitializeComponent();
            _existing = existing;
            if (_existing != null)
            {
                this.Text = "Edit Supplier";
                txtName.Text = existing.Name;
                txtContact.Text = existing.ContactName;
                txtPhone.Text = existing.Phone;
                txtEmail.Text = existing.Email;
                txtDelivery.Text = existing.DeliveryInfo;
                cmbStatus.SelectedItem = existing.Status;
            }
            else
            {
                this.Text = "Add Supplier";
                cmbStatus.SelectedItem = "Active";
            }
        }

        // Validate inputs, then create or update the supplier record.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // ---- Validation ----
            if (!ValidationService.IsValidName(txtName.Text))
            {
                MessageBox.Show("Please enter a valid supplier name.", "Invalid Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Supplier target = isNew ? new Supplier() : _existing;
            target.Name = txtName.Text.Trim();
            target.ContactName = txtContact.Text.Trim();
            target.Phone = txtPhone.Text.Trim();
            target.Email = txtEmail.Text.Trim();
            target.DeliveryInfo = txtDelivery.Text.Trim();
            target.Status = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "Active";

            if (isNew)
            {
                target.Id = SupplierService.NextId();
                SupplierService.Add(target);
            }
            else
            {
                SupplierService.Update(target);
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
