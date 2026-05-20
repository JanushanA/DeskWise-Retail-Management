using System.Drawing;
using System.Windows.Forms;

namespace DeskWise.Controls
{
    partial class SettingsControl
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
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.pnlBody = new Panel();
            this.gbStore = new GroupBox();
            this.lblCompany = new Label();
            this.txtCompany = new TextBox();
            this.lblTaxRate = new Label();
            this.nudTaxRate = new NumericUpDown();
            this.lblTaxPct = new Label();
            this.lblLowStock = new Label();
            this.nudLowStock = new NumericUpDown();
            this.gbReceipt = new GroupBox();
            this.lblReceiptHeader = new Label();
            this.txtReceiptHeader = new TextBox();
            this.lblReceiptFooter = new Label();
            this.txtReceiptFooter = new TextBox();
            this.gbSystem = new GroupBox();
            this.lblTheme = new Label();
            this.cmbTheme = new ComboBox();
            this.lblAutoBackup = new Label();
            this.cmbAutoBackup = new ComboBox();
            this.btnBackup = new Button();
            this.btnRestore = new Button();
            this.pnlActions = new Panel();
            this.btnReset = new Button();
            this.btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowStock)).BeginInit();
            this.SuspendLayout();

            // header
            this.pnlHeader.BackColor = Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.Padding = new Padding(20);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new Point(20, 12);
            this.lblTitle.Text = "Settings";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new Font("Segoe UI", 9.75F);
            this.lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new Point(22, 45);
            this.lblSubtitle.Text = "Configure tax, receipts, alerts and backups.";

            // store group
            this.gbStore.Text = "Store";
            this.gbStore.Font = new Font("Segoe UI Semibold", 10F);
            this.gbStore.ForeColor = Color.FromArgb(15, 23, 42);
            this.gbStore.Location = new Point(20, 20);
            this.gbStore.Size = new Size(440, 180);
            this.gbStore.Controls.Add(this.lblCompany);
            this.gbStore.Controls.Add(this.txtCompany);
            this.gbStore.Controls.Add(this.lblTaxRate);
            this.gbStore.Controls.Add(this.nudTaxRate);
            this.gbStore.Controls.Add(this.lblTaxPct);
            this.gbStore.Controls.Add(this.lblLowStock);
            this.gbStore.Controls.Add(this.nudLowStock);

            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new Font("Segoe UI", 9.75F);
            this.lblCompany.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblCompany.Location = new Point(20, 36);
            this.lblCompany.Text = "Company name";

            this.txtCompany.Font = new Font("Segoe UI", 9.75F);
            this.txtCompany.Location = new Point(180, 32);
            this.txtCompany.Size = new Size(220, 25);

            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Font = new Font("Segoe UI", 9.75F);
            this.lblTaxRate.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblTaxRate.Location = new Point(20, 80);
            this.lblTaxRate.Text = "Tax rate";

            this.nudTaxRate.DecimalPlaces = 2;
            this.nudTaxRate.Font = new Font("Segoe UI", 9.75F);
            this.nudTaxRate.Location = new Point(180, 76);
            this.nudTaxRate.Size = new Size(100, 25);
            this.nudTaxRate.Maximum = 100M;
            this.nudTaxRate.Minimum = 0M;
            this.nudTaxRate.Increment = 0.5M;

            this.lblTaxPct.AutoSize = true;
            this.lblTaxPct.Font = new Font("Segoe UI", 9.75F);
            this.lblTaxPct.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblTaxPct.Location = new Point(290, 80);
            this.lblTaxPct.Text = "%  (e.g. 13 for 13% tax)";

            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new Font("Segoe UI", 9.75F);
            this.lblLowStock.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblLowStock.Location = new Point(20, 125);
            this.lblLowStock.Text = "Low stock alert at";

            this.nudLowStock.Font = new Font("Segoe UI", 9.75F);
            this.nudLowStock.Location = new Point(180, 121);
            this.nudLowStock.Size = new Size(100, 25);
            this.nudLowStock.Maximum = 1000M;
            this.nudLowStock.Minimum = 0M;

            // receipt group
            this.gbReceipt.Text = "Receipt";
            this.gbReceipt.Font = new Font("Segoe UI Semibold", 10F);
            this.gbReceipt.ForeColor = Color.FromArgb(15, 23, 42);
            this.gbReceipt.Location = new Point(480, 20);
            this.gbReceipt.Size = new Size(440, 180);
            this.gbReceipt.Controls.Add(this.lblReceiptHeader);
            this.gbReceipt.Controls.Add(this.txtReceiptHeader);
            this.gbReceipt.Controls.Add(this.lblReceiptFooter);
            this.gbReceipt.Controls.Add(this.txtReceiptFooter);

            this.lblReceiptHeader.AutoSize = true;
            this.lblReceiptHeader.Font = new Font("Segoe UI", 9.75F);
            this.lblReceiptHeader.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblReceiptHeader.Location = new Point(20, 36);
            this.lblReceiptHeader.Text = "Header line";

            this.txtReceiptHeader.Font = new Font("Segoe UI", 9.75F);
            this.txtReceiptHeader.Location = new Point(120, 32);
            this.txtReceiptHeader.Size = new Size(290, 25);

            this.lblReceiptFooter.AutoSize = true;
            this.lblReceiptFooter.Font = new Font("Segoe UI", 9.75F);
            this.lblReceiptFooter.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblReceiptFooter.Location = new Point(20, 80);
            this.lblReceiptFooter.Text = "Footer line";

            this.txtReceiptFooter.Font = new Font("Segoe UI", 9.75F);
            this.txtReceiptFooter.Location = new Point(120, 76);
            this.txtReceiptFooter.Size = new Size(290, 25);
            this.txtReceiptFooter.Multiline = true;
            this.txtReceiptFooter.Size = new Size(290, 80);

            // system group
            this.gbSystem.Text = "System";
            this.gbSystem.Font = new Font("Segoe UI Semibold", 10F);
            this.gbSystem.ForeColor = Color.FromArgb(15, 23, 42);
            this.gbSystem.Location = new Point(20, 220);
            this.gbSystem.Size = new Size(900, 160);
            this.gbSystem.Controls.Add(this.lblTheme);
            this.gbSystem.Controls.Add(this.cmbTheme);
            this.gbSystem.Controls.Add(this.lblAutoBackup);
            this.gbSystem.Controls.Add(this.cmbAutoBackup);
            this.gbSystem.Controls.Add(this.btnBackup);
            this.gbSystem.Controls.Add(this.btnRestore);

            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new Font("Segoe UI", 9.75F);
            this.lblTheme.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblTheme.Location = new Point(20, 40);
            this.lblTheme.Text = "Theme";

            this.cmbTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTheme.Font = new Font("Segoe UI", 9.75F);
            this.cmbTheme.Location = new Point(180, 36);
            this.cmbTheme.Size = new Size(180, 25);

            this.lblAutoBackup.AutoSize = true;
            this.lblAutoBackup.Font = new Font("Segoe UI", 9.75F);
            this.lblAutoBackup.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblAutoBackup.Location = new Point(20, 80);
            this.lblAutoBackup.Text = "Auto backup";

            this.cmbAutoBackup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbAutoBackup.Font = new Font("Segoe UI", 9.75F);
            this.cmbAutoBackup.Location = new Point(180, 76);
            this.cmbAutoBackup.Size = new Size(180, 25);

            this.btnBackup.BackColor = Color.White;
            this.btnBackup.FlatStyle = FlatStyle.Flat;
            this.btnBackup.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            this.btnBackup.Font = new Font("Segoe UI", 9.75F);
            this.btnBackup.Location = new Point(400, 36);
            this.btnBackup.Size = new Size(130, 32);
            this.btnBackup.Text = "Backup Now";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);

            this.btnRestore.BackColor = Color.White;
            this.btnRestore.FlatStyle = FlatStyle.Flat;
            this.btnRestore.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            this.btnRestore.Font = new Font("Segoe UI", 9.75F);
            this.btnRestore.Location = new Point(540, 36);
            this.btnRestore.Size = new Size(130, 32);
            this.btnRestore.Text = "Restore...";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);

            // body
            this.pnlBody.Dock = DockStyle.Fill;
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Padding = new Padding(20, 10, 20, 10);
            this.pnlBody.Controls.Add(this.gbSystem);
            this.pnlBody.Controls.Add(this.gbReceipt);
            this.pnlBody.Controls.Add(this.gbStore);

            // actions
            this.pnlActions.Dock = DockStyle.Bottom;
            this.pnlActions.BackColor = Color.FromArgb(248, 250, 252);
            this.pnlActions.Height = 60;
            this.pnlActions.Padding = new Padding(20, 12, 20, 12);
            this.pnlActions.Controls.Add(this.btnReset);
            this.pnlActions.Controls.Add(this.btnSave);

            this.btnSave.BackColor = Color.FromArgb(37, 99, 235);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Dock = DockStyle.Right;
            this.btnSave.Size = new Size(150, 36);
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnReset.BackColor = Color.White;
            this.btnReset.FlatStyle = FlatStyle.Flat;
            this.btnReset.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            this.btnReset.Font = new Font("Segoe UI", 9.75F);
            this.btnReset.Dock = DockStyle.Left;
            this.btnReset.Size = new Size(150, 36);
            this.btnReset.Text = "Reset to Defaults";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // control
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SettingsControl";
            this.Size = new Size(1100, 700);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowStock)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlBody;
        private GroupBox gbStore;
        private Label lblCompany;
        private TextBox txtCompany;
        private Label lblTaxRate;
        private NumericUpDown nudTaxRate;
        private Label lblTaxPct;
        private Label lblLowStock;
        private NumericUpDown nudLowStock;
        private GroupBox gbReceipt;
        private Label lblReceiptHeader;
        private TextBox txtReceiptHeader;
        private Label lblReceiptFooter;
        private TextBox txtReceiptFooter;
        private GroupBox gbSystem;
        private Label lblTheme;
        private ComboBox cmbTheme;
        private Label lblAutoBackup;
        private ComboBox cmbAutoBackup;
        private Button btnBackup;
        private Button btnRestore;
        private Panel pnlActions;
        private Button btnReset;
        private Button btnSave;
    }
}
