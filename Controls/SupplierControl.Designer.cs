namespace DeskWise.Controls
{
    partial class SupplierControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblProfileTitle = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileContact = new System.Windows.Forms.Label();
            this.lblProfilePhone = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.lblProfileDelivery = new System.Windows.Forms.Label();
            this.lblProfileProducts = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Text = "Suppliers";
            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 45);
            this.lblSubtitle.Text = "Manage suppliers, contacts and product sourcing.";
            // pnlToolbar
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnEdit);
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Height = 60;
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            // txtSearch
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(20, 17);
            this.txtSearch.Size = new System.Drawing.Size(320, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(360, 13);
            this.btnAdd.Size = new System.Drawing.Size(110, 32);
            this.btnAdd.Text = "+ Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // btnEdit
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEdit.Location = new System.Drawing.Point(480, 13);
            this.btnEdit.Size = new System.Drawing.Size(95, 32);
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(252, 165, 165);
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnDelete.Location = new System.Drawing.Point(585, 13);
            this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // pnlBody
            this.pnlBody.Controls.Add(this.pnlProfile);
            this.pnlBody.Controls.Add(this.dgvSuppliers);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            // dgvSuppliers
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.dgvSuppliers.ColumnHeadersHeight = 34;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvSuppliers.RowTemplate.Height = 28;
            // pnlProfile
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfile.Controls.Add(this.lblProfileProducts);
            this.pnlProfile.Controls.Add(this.lblProfileDelivery);
            this.pnlProfile.Controls.Add(this.lblProfileEmail);
            this.pnlProfile.Controls.Add(this.lblProfilePhone);
            this.pnlProfile.Controls.Add(this.lblProfileContact);
            this.pnlProfile.Controls.Add(this.lblProfileName);
            this.pnlProfile.Controls.Add(this.lblProfileTitle);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlProfile.Padding = new System.Windows.Forms.Padding(18);
            this.pnlProfile.Width = 320;
            // lblProfileTitle
            this.lblProfileTitle.AutoSize = true;
            this.lblProfileTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblProfileTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblProfileTitle.Location = new System.Drawing.Point(15, 15);
            this.lblProfileTitle.Text = "Supplier Profile";
            // lblProfileName
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProfileName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblProfileName.Location = new System.Drawing.Point(15, 50);
            this.lblProfileName.Text = "Select a supplier";
            // lblProfileContact
            this.lblProfileContact.AutoSize = true;
            this.lblProfileContact.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblProfileContact.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblProfileContact.Location = new System.Drawing.Point(15, 90);
            // lblProfilePhone
            this.lblProfilePhone.AutoSize = true;
            this.lblProfilePhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblProfilePhone.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblProfilePhone.Location = new System.Drawing.Point(15, 115);
            // lblProfileEmail
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblProfileEmail.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblProfileEmail.Location = new System.Drawing.Point(15, 140);
            // lblProfileDelivery
            this.lblProfileDelivery.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblProfileDelivery.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblProfileDelivery.Location = new System.Drawing.Point(15, 175);
            this.lblProfileDelivery.Size = new System.Drawing.Size(275, 60);
            // lblProfileProducts
            this.lblProfileProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblProfileProducts.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblProfileProducts.Location = new System.Drawing.Point(15, 250);
            this.lblProfileProducts.Size = new System.Drawing.Size(275, 22);
            // SupplierControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SupplierControl";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.SupplierControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblProfileProducts;
        private System.Windows.Forms.Label lblProfileDelivery;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfilePhone;
        private System.Windows.Forms.Label lblProfileContact;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileTitle;
        private System.Windows.Forms.DataGridView dgvSuppliers;
    }
}
