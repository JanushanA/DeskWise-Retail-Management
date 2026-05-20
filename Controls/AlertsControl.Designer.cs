using System.Drawing;
using System.Windows.Forms;

namespace DeskWise.Controls
{
    partial class AlertsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.pnlToolbar = new Panel();
            this.lblTypeCaption = new Label();
            this.cmbType = new ComboBox();
            this.lblPriorityCaption = new Label();
            this.cmbPriority = new ComboBox();
            this.btnRefresh = new Button();
            this.lblHigh = new Label();
            this.lblMedium = new Label();
            this.lblLow = new Label();
            this.lblTotal = new Label();
            this.dgvAlerts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            this.SuspendLayout();

            // header
            this.pnlHeader.BackColor = Color.White;
            this.pnlHeader.Controls.Add(this.lblTotal);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.Padding = new Padding(20);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new Point(20, 12);
            this.lblTitle.Text = "Alerts";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new Font("Segoe UI", 9.75F);
            this.lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new Point(22, 45);
            this.lblSubtitle.Text = "Real-time notifications for stock, deliveries and inventory health.";

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new Font("Segoe UI Semibold", 10F);
            this.lblTotal.ForeColor = Color.FromArgb(37, 99, 235);
            this.lblTotal.Location = new Point(900, 30);
            this.lblTotal.Text = "0 active alert(s)";

            // toolbar
            this.pnlToolbar.BackColor = Color.FromArgb(248, 250, 252);
            this.pnlToolbar.Dock = DockStyle.Top;
            this.pnlToolbar.Height = 64;
            this.pnlToolbar.Padding = new Padding(20, 14, 20, 14);
            this.pnlToolbar.Controls.Add(this.lblLow);
            this.pnlToolbar.Controls.Add(this.lblMedium);
            this.pnlToolbar.Controls.Add(this.lblHigh);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.cmbPriority);
            this.pnlToolbar.Controls.Add(this.lblPriorityCaption);
            this.pnlToolbar.Controls.Add(this.cmbType);
            this.pnlToolbar.Controls.Add(this.lblTypeCaption);

            this.lblTypeCaption.AutoSize = true;
            this.lblTypeCaption.Font = new Font("Segoe UI", 9.75F);
            this.lblTypeCaption.Location = new Point(20, 22);
            this.lblTypeCaption.Text = "Type:";

            this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbType.Font = new Font("Segoe UI", 9.75F);
            this.cmbType.Location = new Point(65, 18);
            this.cmbType.Size = new Size(150, 25);
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);

            this.lblPriorityCaption.AutoSize = true;
            this.lblPriorityCaption.Font = new Font("Segoe UI", 9.75F);
            this.lblPriorityCaption.Location = new Point(235, 22);
            this.lblPriorityCaption.Text = "Priority:";

            this.cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new Font("Segoe UI", 9.75F);
            this.cmbPriority.Location = new Point(290, 18);
            this.cmbPriority.Size = new Size(130, 25);
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);

            this.btnRefresh.BackColor = Color.FromArgb(37, 99, 235);
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Location = new Point(440, 16);
            this.btnRefresh.Size = new Size(100, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new Font("Segoe UI Semibold", 9.75F);
            this.lblHigh.ForeColor = Color.FromArgb(185, 28, 28);
            this.lblHigh.Location = new Point(760, 22);
            this.lblHigh.Text = "High: 0";

            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new Font("Segoe UI Semibold", 9.75F);
            this.lblMedium.ForeColor = Color.FromArgb(202, 138, 4);
            this.lblMedium.Location = new Point(840, 22);
            this.lblMedium.Text = "Medium: 0";

            this.lblLow.AutoSize = true;
            this.lblLow.Font = new Font("Segoe UI Semibold", 9.75F);
            this.lblLow.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblLow.Location = new Point(945, 22);
            this.lblLow.Text = "Low: 0";

            // dgv
            this.dgvAlerts.BackgroundColor = Color.White;
            this.dgvAlerts.BorderStyle = BorderStyle.FixedSingle;
            this.dgvAlerts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            this.dgvAlerts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F);
            this.dgvAlerts.ColumnHeadersHeight = 34;
            this.dgvAlerts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlerts.Dock = DockStyle.Fill;
            this.dgvAlerts.EnableHeadersVisualStyles = false;
            this.dgvAlerts.Font = new Font("Segoe UI", 9.75F);
            this.dgvAlerts.RowTemplate.Height = 30;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.dgvAlerts);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "AlertsControl";
            this.Padding = new Padding(0, 0, 0, 0);
            this.Size = new Size(1100, 700);
            this.Load += new System.EventHandler(this.AlertsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            this.ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlToolbar;
        private Label lblTypeCaption;
        private ComboBox cmbType;
        private Label lblPriorityCaption;
        private ComboBox cmbPriority;
        private Button btnRefresh;
        private Label lblHigh;
        private Label lblMedium;
        private Label lblLow;
        private Label lblTotal;
        private DataGridView dgvAlerts;
    }
}
