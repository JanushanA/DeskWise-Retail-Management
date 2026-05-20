using System.Drawing;
using System.Windows.Forms;

namespace DeskWise.Forms
{
    partial class PurchaseOrderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblPoIdCaption = new Label();
            this.lblPoId = new Label();
            this.lblSupplier = new Label();
            this.cmbSupplier = new ComboBox();
            this.lblExpected = new Label();
            this.dtpExpected = new DateTimePicker();
            this.lblStatus = new Label();
            this.cmbStatus = new ComboBox();
            this.lblItemsTitle = new Label();
            this.btnAddItem = new Button();
            this.dgvItems = new DataGridView();
            this.lblTotal = new Label();
            this.lblNotes = new Label();
            this.txtNotes = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            this.lblPoIdCaption.AutoSize = true;
            this.lblPoIdCaption.Font = new Font("Segoe UI", 9.75F);
            this.lblPoIdCaption.Location = new Point(20, 15);
            this.lblPoIdCaption.Text = "PO ID:";

            this.lblPoId.AutoSize = true;
            this.lblPoId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPoId.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblPoId.Location = new Point(70, 14);
            this.lblPoId.Text = "(new)";

            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new Font("Segoe UI", 9.75F);
            this.lblSupplier.Location = new Point(20, 50);
            this.lblSupplier.Text = "Supplier";

            this.cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSupplier.Font = new Font("Segoe UI", 10F);
            this.cmbSupplier.Location = new Point(20, 70);
            this.cmbSupplier.Size = new Size(280, 25);

            this.lblExpected.AutoSize = true;
            this.lblExpected.Font = new Font("Segoe UI", 9.75F);
            this.lblExpected.Location = new Point(320, 50);
            this.lblExpected.Text = "Expected Delivery";

            this.dtpExpected.Format = DateTimePickerFormat.Short;
            this.dtpExpected.Font = new Font("Segoe UI", 10F);
            this.dtpExpected.Location = new Point(320, 70);
            this.dtpExpected.Size = new Size(170, 25);

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Segoe UI", 9.75F);
            this.lblStatus.Location = new Point(510, 50);
            this.lblStatus.Text = "Status";

            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new Font("Segoe UI", 10F);
            this.cmbStatus.Location = new Point(510, 70);
            this.cmbStatus.Size = new Size(130, 25);

            this.lblItemsTitle.AutoSize = true;
            this.lblItemsTitle.Font = new Font("Segoe UI Semibold", 11F);
            this.lblItemsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblItemsTitle.Location = new Point(20, 115);
            this.lblItemsTitle.Text = "Order Items";

            this.btnAddItem.BackColor = Color.FromArgb(37, 99, 235);
            this.btnAddItem.FlatStyle = FlatStyle.Flat;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnAddItem.ForeColor = Color.White;
            this.btnAddItem.Location = new Point(540, 110);
            this.btnAddItem.Size = new Size(100, 28);
            this.btnAddItem.Text = "+ Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            this.dgvItems.BackgroundColor = Color.White;
            this.dgvItems.BorderStyle = BorderStyle.FixedSingle;
            this.dgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            this.dgvItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F);
            this.dgvItems.ColumnHeadersHeight = 32;
            this.dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Font = new Font("Segoe UI", 9.75F);
            this.dgvItems.Location = new Point(20, 145);
            this.dgvItems.Size = new Size(620, 230);
            this.dgvItems.RowTemplate.Height = 28;

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTotal.ForeColor = Color.FromArgb(37, 99, 235);
            this.lblTotal.Location = new Point(480, 385);
            this.lblTotal.Text = "Total: $0.00";

            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new Font("Segoe UI", 9.75F);
            this.lblNotes.Location = new Point(20, 420);
            this.lblNotes.Text = "Notes";

            this.txtNotes.Font = new Font("Segoe UI", 9.75F);
            this.txtNotes.Location = new Point(20, 440);
            this.txtNotes.Multiline = true;
            this.txtNotes.Size = new Size(620, 60);

            this.btnSave.BackColor = Color.FromArgb(22, 163, 74);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(450, 515);
            this.btnSave.Size = new Size(90, 35);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.BackColor = Color.FromArgb(241, 245, 249);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 10F);
            this.btnCancel.Location = new Point(550, 515);
            this.btnCancel.Size = new Size(90, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(662, 568);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblItemsTitle);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpExpected);
            this.Controls.Add(this.lblExpected);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblPoId);
            this.Controls.Add(this.lblPoIdCaption);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrderForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private Label lblPoIdCaption;
        private Label lblPoId;
        private Label lblSupplier;
        private ComboBox cmbSupplier;
        private Label lblExpected;
        private DateTimePicker dtpExpected;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblItemsTitle;
        private Button btnAddItem;
        private DataGridView dgvItems;
        private Label lblTotal;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;
    }
}
