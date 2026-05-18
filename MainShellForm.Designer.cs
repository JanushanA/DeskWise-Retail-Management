namespace DeskWise
{
    partial class MainShellForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flowNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnBuildOrders = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnPurchaseOrders = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAlerts = new System.Windows.Forms.Button();
            this.btnUserMgmt = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblTopBorder = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.flowNav.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlSidebar.Controls.Add(this.flowNav);
            this.pnlSidebar.Controls.Add(this.pnlBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 800);
            this.pnlSidebar.TabIndex = 0;
            //
            // flowNav
            //
            this.flowNav.AutoScroll = true;
            this.flowNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.flowNav.Controls.Add(this.btnDashboard);
            this.flowNav.Controls.Add(this.btnInventory);
            this.flowNav.Controls.Add(this.btnBuildOrders);
            this.flowNav.Controls.Add(this.btnOrderHistory);
            this.flowNav.Controls.Add(this.btnCustomers);
            this.flowNav.Controls.Add(this.btnSuppliers);
            this.flowNav.Controls.Add(this.btnPurchaseOrders);
            this.flowNav.Controls.Add(this.btnReports);
            this.flowNav.Controls.Add(this.btnAlerts);
            this.flowNav.Controls.Add(this.btnUserMgmt);
            this.flowNav.Controls.Add(this.btnSettings);
            this.flowNav.Controls.Add(this.btnLogout);
            this.flowNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNav.Location = new System.Drawing.Point(0, 90);
            this.flowNav.Name = "flowNav";
            this.flowNav.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowNav.Size = new System.Drawing.Size(240, 710);
            this.flowNav.TabIndex = 1;
            this.flowNav.WrapContents = false;
            //
            // btnDashboard
            //
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 8);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(240, 44);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            //
            // btnInventory
            //
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(0, 52);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(240, 44);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            //
            // btnBuildOrders
            //
            this.btnBuildOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnBuildOrders.FlatAppearance.BorderSize = 0;
            this.btnBuildOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBuildOrders.ForeColor = System.Drawing.Color.White;
            this.btnBuildOrders.Location = new System.Drawing.Point(0, 96);
            this.btnBuildOrders.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuildOrders.Name = "btnBuildOrders";
            this.btnBuildOrders.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnBuildOrders.Size = new System.Drawing.Size(240, 44);
            this.btnBuildOrders.TabIndex = 2;
            this.btnBuildOrders.Text = "Build Orders";
            this.btnBuildOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuildOrders.UseVisualStyleBackColor = false;
            this.btnBuildOrders.Click += new System.EventHandler(this.btnBuildOrders_Click);
            //
            // btnOrderHistory
            //
            this.btnOrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnOrderHistory.FlatAppearance.BorderSize = 0;
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOrderHistory.ForeColor = System.Drawing.Color.White;
            this.btnOrderHistory.Location = new System.Drawing.Point(0, 140);
            this.btnOrderHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnOrderHistory.Size = new System.Drawing.Size(240, 44);
            this.btnOrderHistory.TabIndex = 3;
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderHistory.UseVisualStyleBackColor = false;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            //
            // btnCustomers
            //
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(0, 184);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(240, 44);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            //
            // btnSuppliers
            //
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 228);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnSuppliers.Size = new System.Drawing.Size(240, 44);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            //
            // btnPurchaseOrders
            //
            this.btnPurchaseOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnPurchaseOrders.FlatAppearance.BorderSize = 0;
            this.btnPurchaseOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPurchaseOrders.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseOrders.Location = new System.Drawing.Point(0, 272);
            this.btnPurchaseOrders.Margin = new System.Windows.Forms.Padding(0);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnPurchaseOrders.Size = new System.Drawing.Size(240, 44);
            this.btnPurchaseOrders.TabIndex = 6;
            this.btnPurchaseOrders.Text = "Purchase Orders";
            this.btnPurchaseOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrders.UseVisualStyleBackColor = false;
            this.btnPurchaseOrders.Click += new System.EventHandler(this.btnPurchaseOrders_Click);
            //
            // btnReports
            //
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 316);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(240, 44);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            //
            // btnAlerts
            //
            this.btnAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnAlerts.FlatAppearance.BorderSize = 0;
            this.btnAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlerts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAlerts.ForeColor = System.Drawing.Color.White;
            this.btnAlerts.Location = new System.Drawing.Point(0, 360);
            this.btnAlerts.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlerts.Name = "btnAlerts";
            this.btnAlerts.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnAlerts.Size = new System.Drawing.Size(240, 44);
            this.btnAlerts.TabIndex = 8;
            this.btnAlerts.Text = "Alerts";
            this.btnAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlerts.UseVisualStyleBackColor = false;
            this.btnAlerts.Click += new System.EventHandler(this.btnAlerts_Click);
            //
            // btnUserMgmt
            //
            this.btnUserMgmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnUserMgmt.FlatAppearance.BorderSize = 0;
            this.btnUserMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMgmt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUserMgmt.ForeColor = System.Drawing.Color.White;
            this.btnUserMgmt.Location = new System.Drawing.Point(0, 404);
            this.btnUserMgmt.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserMgmt.Name = "btnUserMgmt";
            this.btnUserMgmt.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnUserMgmt.Size = new System.Drawing.Size(240, 44);
            this.btnUserMgmt.TabIndex = 9;
            this.btnUserMgmt.Text = "User Management";
            this.btnUserMgmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserMgmt.UseVisualStyleBackColor = false;
            this.btnUserMgmt.Click += new System.EventHandler(this.btnUserMgmt_Click);
            //
            // btnSettings
            //
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 448);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(240, 44);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            //
            // btnLogout
            //
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 502);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(240, 44);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // pnlBrand
            //
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlBrand.Controls.Add(this.lblBrandSub);
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(240, 90);
            this.pnlBrand.TabIndex = 0;
            //
            // lblBrandSub
            //
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBrandSub.Location = new System.Drawing.Point(0, 55);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Size = new System.Drawing.Size(240, 20);
            this.lblBrandSub.TabIndex = 1;
            this.lblBrandSub.Text = "Sales Management";
            this.lblBrandSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblBrand
            //
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(0, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(240, 40);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "DeskWise";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlTop
            //
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblCurrentUser);
            this.pnlTop.Controls.Add(this.lblTopBorder);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(240, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1040, 70);
            this.pnlTop.TabIndex = 1;
            //
            // lblCurrentUser
            //
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCurrentUser.Location = new System.Drawing.Point(720, 21);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(300, 25);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = "Not signed in";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblTopBorder
            //
            this.lblTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.lblTopBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTopBorder.Location = new System.Drawing.Point(0, 69);
            this.lblTopBorder.Name = "lblTopBorder";
            this.lblTopBorder.Size = new System.Drawing.Size(1040, 1);
            this.lblTopBorder.TabIndex = 2;
            //
            // pnlContent
            //
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(240, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1040, 730);
            this.pnlContent.TabIndex = 2;
            //
            // MainShellForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "MainShellForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskWise - Retail Sales Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.flowNav.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.FlowLayoutPanel flowNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnBuildOrders;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnPurchaseOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAlerts;
        private System.Windows.Forms.Button btnUserMgmt;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblTopBorder;
        private System.Windows.Forms.Panel pnlContent;
    }
}
