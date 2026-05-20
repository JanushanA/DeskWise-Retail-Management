namespace DeskWise.Controls
{
    partial class CustomerControl
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblProfileHeader = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfilePhone = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.lblProfileLoyalty = new System.Windows.Forms.Label();
            this.lblProfileSpend = new System.Windows.Forms.Label();
            this.lblProfileLast = new System.Windows.Forms.Label();
            this.lblNotesCaption = new System.Windows.Forms.Label();
            this.txtProfileNotes = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 50);
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Text = "Customers";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnEdit);
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 60);
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(20, 17);
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(820, 14);
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.Location = new System.Drawing.Point(945, 14);
            this.btnEdit.Size = new System.Drawing.Size(60, 30);
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27);
            this.btnDelete.Location = new System.Drawing.Point(1010, 14);
            this.btnDelete.Size = new System.Drawing.Size(65, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlBody.Controls.Add(this.pnlProfile);
            this.pnlBody.Controls.Add(this.dgvCustomers);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            // 
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.White;
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfile.Controls.Add(this.txtProfileNotes);
            this.pnlProfile.Controls.Add(this.lblNotesCaption);
            this.pnlProfile.Controls.Add(this.lblProfileLast);
            this.pnlProfile.Controls.Add(this.lblProfileSpend);
            this.pnlProfile.Controls.Add(this.lblProfileLoyalty);
            this.pnlProfile.Controls.Add(this.lblProfileEmail);
            this.pnlProfile.Controls.Add(this.lblProfilePhone);
            this.pnlProfile.Controls.Add(this.lblProfileName);
            this.pnlProfile.Controls.Add(this.lblProfileHeader);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlProfile.Padding = new System.Windows.Forms.Padding(16);
            this.pnlProfile.Size = new System.Drawing.Size(340, 590);
            // 
            this.lblProfileHeader.AutoSize = true;
            this.lblProfileHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProfileHeader.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblProfileHeader.Location = new System.Drawing.Point(16, 16);
            this.lblProfileHeader.Text = "CUSTOMER PROFILE";
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblProfileName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblProfileName.Location = new System.Drawing.Point(16, 46);
            this.lblProfileName.Text = "Select a customer";
            // 
            this.lblProfilePhone.AutoSize = true;
            this.lblProfilePhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblProfilePhone.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblProfilePhone.Location = new System.Drawing.Point(16, 90);
            this.lblProfilePhone.Text = "";
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblProfileEmail.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblProfileEmail.Location = new System.Drawing.Point(16, 115);
            this.lblProfileEmail.Text = "";
            // 
            this.lblProfileLoyalty.AutoSize = true;
            this.lblProfileLoyalty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProfileLoyalty.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblProfileLoyalty.Location = new System.Drawing.Point(16, 145);
            this.lblProfileLoyalty.Text = "";
            // 
            this.lblProfileSpend.AutoSize = true;
            this.lblProfileSpend.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblProfileSpend.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblProfileSpend.Location = new System.Drawing.Point(16, 175);
            this.lblProfileSpend.Text = "";
            // 
            this.lblProfileLast.AutoSize = true;
            this.lblProfileLast.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblProfileLast.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblProfileLast.Location = new System.Drawing.Point(16, 200);
            this.lblProfileLast.Text = "";
            // 
            this.lblNotesCaption.AutoSize = true;
            this.lblNotesCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNotesCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblNotesCaption.Location = new System.Drawing.Point(16, 240);
            this.lblNotesCaption.Text = "Notes";
            // 
            this.txtProfileNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfileNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtProfileNotes.Location = new System.Drawing.Point(16, 265);
            this.txtProfileNotes.Multiline = true;
            this.txtProfileNotes.ReadOnly = true;
            this.txtProfileNotes.Size = new System.Drawing.Size(300, 280);
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.CustomerControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblProfileHeader;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfilePhone;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfileLoyalty;
        private System.Windows.Forms.Label lblProfileSpend;
        private System.Windows.Forms.Label lblProfileLast;
        private System.Windows.Forms.Label lblNotesCaption;
        private System.Windows.Forms.TextBox txtProfileNotes;
    }
}
