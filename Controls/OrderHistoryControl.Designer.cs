namespace DeskWise.Controls
{
    partial class OrderHistoryControl
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
            this.pnlKpis = new System.Windows.Forms.Panel();
            this.pnlKpiTotal = new System.Windows.Forms.Panel();
            this.lblKpiTotalCaption = new System.Windows.Forms.Label();
            this.lblKpiTotal = new System.Windows.Forms.Label();
            this.pnlKpiCompleted = new System.Windows.Forms.Panel();
            this.lblKpiCompletedCaption = new System.Windows.Forms.Label();
            this.lblKpiCompleted = new System.Windows.Forms.Label();
            this.pnlKpiPending = new System.Windows.Forms.Panel();
            this.lblKpiPendingCaption = new System.Windows.Forms.Label();
            this.lblKpiPending = new System.Windows.Forms.Label();
            this.pnlKpiRefunded = new System.Windows.Forms.Panel();
            this.lblKpiRefundedCaption = new System.Windows.Forms.Label();
            this.lblKpiRefunded = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnReprint = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlKpis.SuspendLayout();
            this.pnlKpiTotal.SuspendLayout();
            this.pnlKpiCompleted.SuspendLayout();
            this.pnlKpiPending.SuspendLayout();
            this.pnlKpiRefunded.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
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
            this.lblTitle.Text = "Order History";
            // 
            // pnlKpis
            // 
            this.pnlKpis.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlKpis.Controls.Add(this.pnlKpiRefunded);
            this.pnlKpis.Controls.Add(this.pnlKpiPending);
            this.pnlKpis.Controls.Add(this.pnlKpiCompleted);
            this.pnlKpis.Controls.Add(this.pnlKpiTotal);
            this.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpis.Padding = new System.Windows.Forms.Padding(20, 12, 20, 0);
            this.pnlKpis.Size = new System.Drawing.Size(1100, 110);
            // 
            this.pnlKpiTotal.BackColor = System.Drawing.Color.White;
            this.pnlKpiTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiTotal.Location = new System.Drawing.Point(20, 14);
            this.pnlKpiTotal.Size = new System.Drawing.Size(240, 80);
            this.pnlKpiTotal.Controls.Add(this.lblKpiTotalCaption);
            this.pnlKpiTotal.Controls.Add(this.lblKpiTotal);
            this.lblKpiTotalCaption.AutoSize = true;
            this.lblKpiTotalCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKpiTotalCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblKpiTotalCaption.Location = new System.Drawing.Point(15, 12);
            this.lblKpiTotalCaption.Text = "Total Orders";
            this.lblKpiTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotal.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblKpiTotal.Location = new System.Drawing.Point(13, 32);
            this.lblKpiTotal.Size = new System.Drawing.Size(220, 40);
            this.lblKpiTotal.Text = "0";

            this.pnlKpiCompleted.BackColor = System.Drawing.Color.White;
            this.pnlKpiCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiCompleted.Location = new System.Drawing.Point(280, 14);
            this.pnlKpiCompleted.Size = new System.Drawing.Size(240, 80);
            this.pnlKpiCompleted.Controls.Add(this.lblKpiCompletedCaption);
            this.pnlKpiCompleted.Controls.Add(this.lblKpiCompleted);
            this.lblKpiCompletedCaption.AutoSize = true;
            this.lblKpiCompletedCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKpiCompletedCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblKpiCompletedCaption.Location = new System.Drawing.Point(15, 12);
            this.lblKpiCompletedCaption.Text = "Completed";
            this.lblKpiCompleted.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiCompleted.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblKpiCompleted.Location = new System.Drawing.Point(13, 32);
            this.lblKpiCompleted.Size = new System.Drawing.Size(220, 40);
            this.lblKpiCompleted.Text = "0";

            this.pnlKpiPending.BackColor = System.Drawing.Color.White;
            this.pnlKpiPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiPending.Location = new System.Drawing.Point(540, 14);
            this.pnlKpiPending.Size = new System.Drawing.Size(240, 80);
            this.pnlKpiPending.Controls.Add(this.lblKpiPendingCaption);
            this.pnlKpiPending.Controls.Add(this.lblKpiPending);
            this.lblKpiPendingCaption.AutoSize = true;
            this.lblKpiPendingCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKpiPendingCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblKpiPendingCaption.Location = new System.Drawing.Point(15, 12);
            this.lblKpiPendingCaption.Text = "Pending";
            this.lblKpiPending.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiPending.ForeColor = System.Drawing.Color.FromArgb(202, 138, 4);
            this.lblKpiPending.Location = new System.Drawing.Point(13, 32);
            this.lblKpiPending.Size = new System.Drawing.Size(220, 40);
            this.lblKpiPending.Text = "0";

            this.pnlKpiRefunded.BackColor = System.Drawing.Color.White;
            this.pnlKpiRefunded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiRefunded.Location = new System.Drawing.Point(800, 14);
            this.pnlKpiRefunded.Size = new System.Drawing.Size(240, 80);
            this.pnlKpiRefunded.Controls.Add(this.lblKpiRefundedCaption);
            this.pnlKpiRefunded.Controls.Add(this.lblKpiRefunded);
            this.lblKpiRefundedCaption.AutoSize = true;
            this.lblKpiRefundedCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKpiRefundedCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblKpiRefundedCaption.Location = new System.Drawing.Point(15, 12);
            this.lblKpiRefundedCaption.Text = "Refunded";
            this.lblKpiRefunded.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiRefunded.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27);
            this.lblKpiRefunded.Location = new System.Drawing.Point(13, 32);
            this.lblKpiRefunded.Size = new System.Drawing.Size(220, 40);
            this.lblKpiRefunded.Text = "0";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.btnReset);
            this.pnlFilters.Controls.Add(this.btnApply);
            this.pnlFilters.Controls.Add(this.cmbPayment);
            this.pnlFilters.Controls.Add(this.lblPayment);
            this.pnlFilters.Controls.Add(this.cmbStatus);
            this.pnlFilters.Controls.Add(this.lblStatus);
            this.pnlFilters.Controls.Add(this.dtpTo);
            this.pnlFilters.Controls.Add(this.lblTo);
            this.pnlFilters.Controls.Add(this.dtpFrom);
            this.pnlFilters.Controls.Add(this.lblFrom);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.lblSearch);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Size = new System.Drawing.Size(1100, 80);
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.Location = new System.Drawing.Point(22, 10);
            this.lblSearch.Text = "Search";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(20, 28);
            this.txtSearch.Size = new System.Drawing.Size(190, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFrom.Location = new System.Drawing.Point(222, 10);
            this.lblFrom.Text = "From";
            this.dtpFrom.Location = new System.Drawing.Point(220, 28);
            this.dtpFrom.Size = new System.Drawing.Size(140, 23);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTo.Location = new System.Drawing.Point(372, 10);
            this.lblTo.Text = "To";
            this.dtpTo.Location = new System.Drawing.Point(370, 28);
            this.dtpTo.Size = new System.Drawing.Size(140, 23);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(522, 10);
            this.lblStatus.Text = "Status";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbStatus.Location = new System.Drawing.Point(520, 28);
            this.cmbStatus.Size = new System.Drawing.Size(130, 25);
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPayment.Location = new System.Drawing.Point(662, 10);
            this.lblPayment.Text = "Payment";
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbPayment.Location = new System.Drawing.Point(660, 28);
            this.cmbPayment.Size = new System.Drawing.Size(140, 25);
            this.cmbPayment.SelectedIndexChanged += new System.EventHandler(this.cmbPayment_SelectedIndexChanged);
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(820, 27);
            this.btnApply.Size = new System.Drawing.Size(110, 28);
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.Location = new System.Drawing.Point(940, 27);
            this.btnReset.Size = new System.Drawing.Size(110, 28);
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.btnDuplicate);
            this.pnlActions.Controls.Add(this.btnRefund);
            this.pnlActions.Controls.Add(this.btnReprint);
            this.pnlActions.Controls.Add(this.btnViewDetails);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Size = new System.Drawing.Size(1100, 60);
            this.pnlActions.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewDetails.Location = new System.Drawing.Point(20, 14);
            this.btnViewDetails.Size = new System.Drawing.Size(140, 32);
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            this.btnReprint.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnReprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReprint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReprint.Location = new System.Drawing.Point(170, 14);
            this.btnReprint.Size = new System.Drawing.Size(140, 32);
            this.btnReprint.Text = "Reprint Receipt";
            this.btnReprint.UseVisualStyleBackColor = false;
            this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
            // 
            this.btnRefund.BackColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefund.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27);
            this.btnRefund.Location = new System.Drawing.Point(320, 14);
            this.btnRefund.Size = new System.Drawing.Size(140, 32);
            this.btnRefund.Text = "Refund Order";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            this.btnDuplicate.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuplicate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDuplicate.ForeColor = System.Drawing.Color.White;
            this.btnDuplicate.Location = new System.Drawing.Point(470, 14);
            this.btnDuplicate.Size = new System.Drawing.Size(150, 32);
            this.btnDuplicate.Text = "Duplicate Order";
            this.btnDuplicate.UseVisualStyleBackColor = false;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // OrderHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlKpis);
            this.Controls.Add(this.pnlHeader);
            this.Name = "OrderHistoryControl";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.OrderHistoryControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlKpis.ResumeLayout(false);
            this.pnlKpiTotal.ResumeLayout(false);
            this.pnlKpiTotal.PerformLayout();
            this.pnlKpiCompleted.ResumeLayout(false);
            this.pnlKpiCompleted.PerformLayout();
            this.pnlKpiPending.ResumeLayout(false);
            this.pnlKpiPending.PerformLayout();
            this.pnlKpiRefunded.ResumeLayout(false);
            this.pnlKpiRefunded.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlKpis;
        private System.Windows.Forms.Panel pnlKpiTotal;
        private System.Windows.Forms.Label lblKpiTotalCaption;
        private System.Windows.Forms.Label lblKpiTotal;
        private System.Windows.Forms.Panel pnlKpiCompleted;
        private System.Windows.Forms.Label lblKpiCompletedCaption;
        private System.Windows.Forms.Label lblKpiCompleted;
        private System.Windows.Forms.Panel pnlKpiPending;
        private System.Windows.Forms.Label lblKpiPendingCaption;
        private System.Windows.Forms.Label lblKpiPending;
        private System.Windows.Forms.Panel pnlKpiRefunded;
        private System.Windows.Forms.Label lblKpiRefundedCaption;
        private System.Windows.Forms.Label lblKpiRefunded;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnReprint;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}
