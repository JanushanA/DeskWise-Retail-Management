using System.Drawing;
using System.Windows.Forms;

namespace DeskWise.Controls
{
    partial class PurchaseOrdersControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlKpis = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKpiTotal = new System.Windows.Forms.Panel();
            this.lblKpiTotal = new System.Windows.Forms.Label();
            this.lblKpiTotalCaption = new System.Windows.Forms.Label();
            this.pnlKpiDraft = new System.Windows.Forms.Panel();
            this.lblKpiDraft = new System.Windows.Forms.Label();
            this.lblKpiDraftCaption = new System.Windows.Forms.Label();
            this.pnlKpiSent = new System.Windows.Forms.Panel();
            this.lblKpiSent = new System.Windows.Forms.Label();
            this.lblKpiSentCaption = new System.Windows.Forms.Label();
            this.pnlKpiPending = new System.Windows.Forms.Panel();
            this.lblKpiPending = new System.Windows.Forms.Label();
            this.lblKpiPendingCaption = new System.Windows.Forms.Label();
            this.pnlKpiReceived = new System.Windows.Forms.Panel();
            this.lblKpiReceived = new System.Windows.Forms.Label();
            this.lblKpiReceivedCaption = new System.Windows.Forms.Label();
            this.pnlKpiCancelled = new System.Windows.Forms.Panel();
            this.lblKpiCancelled = new System.Windows.Forms.Label();
            this.lblKpiCancelledCaption = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkReceived = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvPos = new System.Windows.Forms.DataGridView();
            this.pnlReorder = new System.Windows.Forms.Panel();
            this.dgvReorder = new System.Windows.Forms.DataGridView();
            this.pnlReorderHeader = new System.Windows.Forms.Panel();
            this.btnGeneratePo = new System.Windows.Forms.Button();
            this.lblReorderCount = new System.Windows.Forms.Label();
            this.lblReorderTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlKpis.SuspendLayout();
            this.pnlKpiTotal.SuspendLayout();
            this.pnlKpiDraft.SuspendLayout();
            this.pnlKpiSent.SuspendLayout();
            this.pnlKpiPending.SuspendLayout();
            this.pnlKpiReceived.SuspendLayout();
            this.pnlKpiCancelled.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPos)).BeginInit();
            this.pnlReorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorder)).BeginInit();
            this.pnlReorderHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 70);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtitle.Location = new System.Drawing.Point(42, 65);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(453, 17);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Track orders to suppliers and restock inventory automatically when received.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Purchase Orders";
            // 
            // pnlKpis
            // 
            this.pnlKpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlKpis.ColumnCount = 6;
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.pnlKpis.Controls.Add(this.pnlKpiTotal, 0, 0);
            this.pnlKpis.Controls.Add(this.pnlKpiDraft, 1, 0);
            this.pnlKpis.Controls.Add(this.pnlKpiSent, 2, 0);
            this.pnlKpis.Controls.Add(this.pnlKpiPending, 3, 0);
            this.pnlKpis.Controls.Add(this.pnlKpiReceived, 4, 0);
            this.pnlKpis.Controls.Add(this.pnlKpiCancelled, 5, 0);
            this.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpis.Location = new System.Drawing.Point(0, 70);
            this.pnlKpis.Name = "pnlKpis";
            this.pnlKpis.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlKpis.RowCount = 1;
            this.pnlKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlKpis.Size = new System.Drawing.Size(1100, 100);
            this.pnlKpis.TabIndex = 2;
            // 
            // pnlKpiTotal
            // 
            this.pnlKpiTotal.BackColor = System.Drawing.Color.White;
            this.pnlKpiTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiTotal.Controls.Add(this.lblKpiTotal);
            this.pnlKpiTotal.Controls.Add(this.lblKpiTotalCaption);
            this.pnlKpiTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiTotal.Location = new System.Drawing.Point(26, 18);
            this.pnlKpiTotal.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiTotal.Name = "pnlKpiTotal";
            this.pnlKpiTotal.Size = new System.Drawing.Size(164, 64);
            this.pnlKpiTotal.TabIndex = 0;
            // 
            // lblKpiTotal
            // 
            this.lblKpiTotal.AutoSize = true;
            this.lblKpiTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblKpiTotal.Location = new System.Drawing.Point(10, 30);
            this.lblKpiTotal.Name = "lblKpiTotal";
            this.lblKpiTotal.Size = new System.Drawing.Size(33, 37);
            this.lblKpiTotal.TabIndex = 0;
            this.lblKpiTotal.Text = "0";
            // 
            // lblKpiTotalCaption
            // 
            this.lblKpiTotalCaption.AutoSize = true;
            this.lblKpiTotalCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiTotalCaption.Location = new System.Drawing.Point(10, 8);
            this.lblKpiTotalCaption.Name = "lblKpiTotalCaption";
            this.lblKpiTotalCaption.Size = new System.Drawing.Size(57, 15);
            this.lblKpiTotalCaption.TabIndex = 1;
            this.lblKpiTotalCaption.Text = "Total POs";
            // 
            // pnlKpiDraft
            // 
            this.pnlKpiDraft.BackColor = System.Drawing.Color.White;
            this.pnlKpiDraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiDraft.Controls.Add(this.lblKpiDraft);
            this.pnlKpiDraft.Controls.Add(this.lblKpiDraftCaption);
            this.pnlKpiDraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiDraft.Location = new System.Drawing.Point(202, 18);
            this.pnlKpiDraft.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiDraft.Name = "pnlKpiDraft";
            this.pnlKpiDraft.Size = new System.Drawing.Size(164, 64);
            this.pnlKpiDraft.TabIndex = 1;
            // 
            // lblKpiDraft
            // 
            this.lblKpiDraft.AutoSize = true;
            this.lblKpiDraft.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiDraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiDraft.Location = new System.Drawing.Point(10, 30);
            this.lblKpiDraft.Name = "lblKpiDraft";
            this.lblKpiDraft.Size = new System.Drawing.Size(33, 37);
            this.lblKpiDraft.TabIndex = 0;
            this.lblKpiDraft.Text = "0";
            // 
            // lblKpiDraftCaption
            // 
            this.lblKpiDraftCaption.AutoSize = true;
            this.lblKpiDraftCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiDraftCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiDraftCaption.Location = new System.Drawing.Point(10, 8);
            this.lblKpiDraftCaption.Name = "lblKpiDraftCaption";
            this.lblKpiDraftCaption.Size = new System.Drawing.Size(33, 15);
            this.lblKpiDraftCaption.TabIndex = 1;
            this.lblKpiDraftCaption.Text = "Draft";
            // 
            // pnlKpiSent
            // 
            this.pnlKpiSent.BackColor = System.Drawing.Color.White;
            this.pnlKpiSent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiSent.Controls.Add(this.lblKpiSent);
            this.pnlKpiSent.Controls.Add(this.lblKpiSentCaption);
            this.pnlKpiSent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiSent.Location = new System.Drawing.Point(378, 18);
            this.pnlKpiSent.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiSent.Name = "pnlKpiSent";
            this.pnlKpiSent.Size = new System.Drawing.Size(164, 64);
            this.pnlKpiSent.TabIndex = 2;
            // 
            // lblKpiSent
            // 
            this.lblKpiSent.AutoSize = true;
            this.lblKpiSent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblKpiSent.Location = new System.Drawing.Point(10, 30);
            this.lblKpiSent.Name = "lblKpiSent";
            this.lblKpiSent.Size = new System.Drawing.Size(33, 37);
            this.lblKpiSent.TabIndex = 0;
            this.lblKpiSent.Text = "0";
            // 
            // lblKpiSentCaption
            // 
            this.lblKpiSentCaption.AutoSize = true;
            this.lblKpiSentCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiSentCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiSentCaption.Location = new System.Drawing.Point(10, 8);
            this.lblKpiSentCaption.Name = "lblKpiSentCaption";
            this.lblKpiSentCaption.Size = new System.Drawing.Size(30, 15);
            this.lblKpiSentCaption.TabIndex = 1;
            this.lblKpiSentCaption.Text = "Sent";
            // 
            // pnlKpiPending
            // 
            this.pnlKpiPending.BackColor = System.Drawing.Color.White;
            this.pnlKpiPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiPending.Controls.Add(this.lblKpiPending);
            this.pnlKpiPending.Controls.Add(this.lblKpiPendingCaption);
            this.pnlKpiPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiPending.Location = new System.Drawing.Point(554, 18);
            this.pnlKpiPending.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiPending.Name = "pnlKpiPending";
            this.pnlKpiPending.Size = new System.Drawing.Size(164, 64);
            this.pnlKpiPending.TabIndex = 3;
            // 
            // lblKpiPending
            // 
            this.lblKpiPending.AutoSize = true;
            this.lblKpiPending.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(4)))));
            this.lblKpiPending.Location = new System.Drawing.Point(10, 30);
            this.lblKpiPending.Name = "lblKpiPending";
            this.lblKpiPending.Size = new System.Drawing.Size(33, 37);
            this.lblKpiPending.TabIndex = 0;
            this.lblKpiPending.Text = "0";
            // 
            // lblKpiPendingCaption
            // 
            this.lblKpiPendingCaption.AutoSize = true;
            this.lblKpiPendingCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiPendingCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiPendingCaption.Location = new System.Drawing.Point(10, 8);
            this.lblKpiPendingCaption.Name = "lblKpiPendingCaption";
            this.lblKpiPendingCaption.Size = new System.Drawing.Size(51, 15);
            this.lblKpiPendingCaption.TabIndex = 1;
            this.lblKpiPendingCaption.Text = "Pending";
            // 
            // pnlKpiReceived
            // 
            this.pnlKpiReceived.BackColor = System.Drawing.Color.White;
            this.pnlKpiReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiReceived.Controls.Add(this.lblKpiReceived);
            this.pnlKpiReceived.Controls.Add(this.lblKpiReceivedCaption);
            this.pnlKpiReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiReceived.Location = new System.Drawing.Point(730, 18);
            this.pnlKpiReceived.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiReceived.Name = "pnlKpiReceived";
            this.pnlKpiReceived.Size = new System.Drawing.Size(164, 64);
            this.pnlKpiReceived.TabIndex = 4;
            // 
            // lblKpiReceived
            // 
            this.lblKpiReceived.AutoSize = true;
            this.lblKpiReceived.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblKpiReceived.Location = new System.Drawing.Point(10, 30);
            this.lblKpiReceived.Name = "lblKpiReceived";
            this.lblKpiReceived.Size = new System.Drawing.Size(33, 37);
            this.lblKpiReceived.TabIndex = 0;
            this.lblKpiReceived.Text = "0";
            // 
            // lblKpiReceivedCaption
            // 
            this.lblKpiReceivedCaption.AutoSize = true;
            this.lblKpiReceivedCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiReceivedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiReceivedCaption.Location = new System.Drawing.Point(10, 8);
            this.lblKpiReceivedCaption.Name = "lblKpiReceivedCaption";
            this.lblKpiReceivedCaption.Size = new System.Drawing.Size(54, 15);
            this.lblKpiReceivedCaption.TabIndex = 1;
            this.lblKpiReceivedCaption.Text = "Received";
            // 
            // pnlKpiCancelled
            // 
            this.pnlKpiCancelled.BackColor = System.Drawing.Color.White;
            this.pnlKpiCancelled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiCancelled.Controls.Add(this.lblKpiCancelled);
            this.pnlKpiCancelled.Controls.Add(this.lblKpiCancelledCaption);
            this.pnlKpiCancelled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiCancelled.Location = new System.Drawing.Point(906, 18);
            this.pnlKpiCancelled.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiCancelled.Name = "pnlKpiCancelled";
            this.pnlKpiCancelled.Size = new System.Drawing.Size(168, 64);
            this.pnlKpiCancelled.TabIndex = 5;
            // 
            // lblKpiCancelled
            // 
            this.lblKpiCancelled.AutoSize = true;
            this.lblKpiCancelled.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiCancelled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblKpiCancelled.Location = new System.Drawing.Point(10, 30);
            this.lblKpiCancelled.Name = "lblKpiCancelled";
            this.lblKpiCancelled.Size = new System.Drawing.Size(33, 37);
            this.lblKpiCancelled.TabIndex = 0;
            this.lblKpiCancelled.Text = "0";
            // 
            // lblKpiCancelledCaption
            // 
            this.lblKpiCancelledCaption.AutoSize = true;
            this.lblKpiCancelledCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiCancelledCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiCancelledCaption.Location = new System.Drawing.Point(10, 8);
            this.lblKpiCancelledCaption.Name = "lblKpiCancelledCaption";
            this.lblKpiCancelledCaption.Size = new System.Drawing.Size(59, 15);
            this.lblKpiCancelledCaption.TabIndex = 1;
            this.lblKpiCancelledCaption.Text = "Cancelled";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnMarkReceived);
            this.pnlToolbar.Controls.Add(this.btnView);
            this.pnlToolbar.Controls.Add(this.btnCreate);
            this.pnlToolbar.Controls.Add(this.cmbStatus);
            this.pnlToolbar.Controls.Add(this.lblStatus);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 170);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 60);
            this.pnlToolbar.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDelete.Location = new System.Drawing.Point(835, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 32);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMarkReceived
            // 
            this.btnMarkReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.btnMarkReceived.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.btnMarkReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkReceived.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMarkReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnMarkReceived.Location = new System.Drawing.Point(700, 14);
            this.btnMarkReceived.Name = "btnMarkReceived";
            this.btnMarkReceived.Size = new System.Drawing.Size(130, 32);
            this.btnMarkReceived.TabIndex = 1;
            this.btnMarkReceived.Text = "Mark Received";
            this.btnMarkReceived.UseVisualStyleBackColor = false;
            this.btnMarkReceived.Click += new System.EventHandler(this.btnMarkReceived_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnView.Location = new System.Drawing.Point(605, 14);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 32);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(480, 14);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 32);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "+ Create PO";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbStatus.Location = new System.Drawing.Point(330, 18);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(130, 25);
            this.cmbStatus.TabIndex = 4;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStatus.Location = new System.Drawing.Point(280, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(20, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 25);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvPos);
            this.pnlBody.Controls.Add(this.pnlReorder);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 230);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.pnlBody.Size = new System.Drawing.Size(1100, 470);
            this.pnlBody.TabIndex = 0;
            // 
            // dgvPos
            // 
            this.dgvPos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPos.ColumnHeadersHeight = 34;
            this.dgvPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPos.EnableHeadersVisualStyles = false;
            this.dgvPos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvPos.Location = new System.Drawing.Point(20, 10);
            this.dgvPos.Name = "dgvPos";
            this.dgvPos.RowTemplate.Height = 28;
            this.dgvPos.Size = new System.Drawing.Size(680, 440);
            this.dgvPos.TabIndex = 0;
            // 
            // pnlReorder
            // 
            this.pnlReorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlReorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReorder.Controls.Add(this.dgvReorder);
            this.pnlReorder.Controls.Add(this.pnlReorderHeader);
            this.pnlReorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlReorder.Location = new System.Drawing.Point(700, 10);
            this.pnlReorder.Name = "pnlReorder";
            this.pnlReorder.Size = new System.Drawing.Size(380, 440);
            this.pnlReorder.TabIndex = 1;
            // 
            // dgvReorder
            // 
            this.dgvReorder.BackgroundColor = System.Drawing.Color.White;
            this.dgvReorder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReorder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReorder.EnableHeadersVisualStyles = false;
            this.dgvReorder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvReorder.Location = new System.Drawing.Point(0, 100);
            this.dgvReorder.Name = "dgvReorder";
            this.dgvReorder.RowTemplate.Height = 26;
            this.dgvReorder.Size = new System.Drawing.Size(378, 338);
            this.dgvReorder.TabIndex = 0;
            // 
            // pnlReorderHeader
            // 
            this.pnlReorderHeader.BackColor = System.Drawing.Color.White;
            this.pnlReorderHeader.Controls.Add(this.btnGeneratePo);
            this.pnlReorderHeader.Controls.Add(this.lblReorderCount);
            this.pnlReorderHeader.Controls.Add(this.lblReorderTitle);
            this.pnlReorderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReorderHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlReorderHeader.Name = "pnlReorderHeader";
            this.pnlReorderHeader.Size = new System.Drawing.Size(378, 100);
            this.pnlReorderHeader.TabIndex = 1;
            // 
            // btnGeneratePo
            // 
            this.btnGeneratePo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnGeneratePo.FlatAppearance.BorderSize = 0;
            this.btnGeneratePo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGeneratePo.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePo.Location = new System.Drawing.Point(15, 60);
            this.btnGeneratePo.Name = "btnGeneratePo";
            this.btnGeneratePo.Size = new System.Drawing.Size(220, 30);
            this.btnGeneratePo.TabIndex = 0;
            this.btnGeneratePo.Text = "Auto-Generate POs";
            this.btnGeneratePo.UseVisualStyleBackColor = false;
            this.btnGeneratePo.Click += new System.EventHandler(this.btnGeneratePo_Click);
            // 
            // lblReorderCount
            // 
            this.lblReorderCount.AutoSize = true;
            this.lblReorderCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReorderCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblReorderCount.Location = new System.Drawing.Point(15, 38);
            this.lblReorderCount.Name = "lblReorderCount";
            this.lblReorderCount.Size = new System.Drawing.Size(0, 15);
            this.lblReorderCount.TabIndex = 1;
            // 
            // lblReorderTitle
            // 
            this.lblReorderTitle.AutoSize = true;
            this.lblReorderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblReorderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblReorderTitle.Location = new System.Drawing.Point(15, 12);
            this.lblReorderTitle.Name = "lblReorderTitle";
            this.lblReorderTitle.Size = new System.Drawing.Size(194, 20);
            this.lblReorderTitle.TabIndex = 2;
            this.lblReorderTitle.Text = "Reorder Recommendations";
            // 
            // PurchaseOrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlKpis);
            this.Controls.Add(this.pnlHeader);
            this.Name = "PurchaseOrdersControl";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.PurchaseOrdersControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlKpis.ResumeLayout(false);
            this.pnlKpiTotal.ResumeLayout(false);
            this.pnlKpiTotal.PerformLayout();
            this.pnlKpiDraft.ResumeLayout(false);
            this.pnlKpiDraft.PerformLayout();
            this.pnlKpiSent.ResumeLayout(false);
            this.pnlKpiSent.PerformLayout();
            this.pnlKpiPending.ResumeLayout(false);
            this.pnlKpiPending.PerformLayout();
            this.pnlKpiReceived.ResumeLayout(false);
            this.pnlKpiReceived.PerformLayout();
            this.pnlKpiCancelled.ResumeLayout(false);
            this.pnlKpiCancelled.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPos)).EndInit();
            this.pnlReorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorder)).EndInit();
            this.pnlReorderHeader.ResumeLayout(false);
            this.pnlReorderHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private TableLayoutPanel pnlKpis;
        private Panel pnlToolbar;
        private TextBox txtSearch;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnCreate;
        private Button btnView;
        private Button btnMarkReceived;
        private Button btnDelete;
        private Panel pnlBody;
        private DataGridView dgvPos;
        private Panel pnlReorder;
        private Panel pnlReorderHeader;
        private Label lblReorderTitle;
        private Label lblReorderCount;
        private Button btnGeneratePo;
        private DataGridView dgvReorder;
        private Panel pnlKpiTotal;
        private Label lblKpiTotalCaption;
        private Label lblKpiTotal;
        private Panel pnlKpiDraft;
        private Label lblKpiDraftCaption;
        private Label lblKpiDraft;
        private Panel pnlKpiSent;
        private Label lblKpiSentCaption;
        private Label lblKpiSent;
        private Panel pnlKpiPending;
        private Label lblKpiPendingCaption;
        private Label lblKpiPending;
        private Panel pnlKpiReceived;
        private Label lblKpiReceivedCaption;
        private Label lblKpiReceived;
        private Panel pnlKpiCancelled;
        private Label lblKpiCancelledCaption;
        private Label lblKpiCancelled;
    }
}
