using System;
using System.Drawing;
using System.Windows.Forms;
using DeskWise.Controls;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise
{
    // Main application shell. Hosts the sidebar nav, top bar, and a content panel.
    // Every screen change goes through LoadScreen so disposal + active-button styling
    // is handled in exactly one place.
    public partial class MainShellForm : Form
    {
        // Track the active sidebar button so we can revert its colour when the user moves on.
        private Button _activeNav;

        // Sidebar palette - kept inline so it's easy to spot during code review.
        private static readonly Color SidebarBg     = Color.FromArgb(30, 41, 59);
        private static readonly Color SidebarHover  = Color.FromArgb(51, 65, 85);
        private static readonly Color SidebarActive = Color.FromArgb(37, 99, 235);

        // Builds the shell, wires sidebar hover effects, and saves data when the form closes.
        public MainShellForm()
        {
            InitializeComponent();
            WireSidebarHoverEffects();
            this.FormClosing += MainShellForm_FormClosing;
        }

        // First paint: apply role-based nav, show user label, theme, and open the dashboard.
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ApplyRolePermissions();
            UpdateCurrentUserLabel();
            ThemeService.ApplyToForm(this);
            LoadScreen(new DashboardControl(), btnDashboard);
        }

        // Shows the signed-in user's role and display name in the top bar.
        private void UpdateCurrentUserLabel()
        {
            User currentUser = AppState.CurrentUser;
            if (currentUser == null)
            {
                lblCurrentUser.Text = "Not signed in";
                return;
            }
            lblCurrentUser.Text = currentUser.Role + " | " +
                (string.IsNullOrEmpty(currentUser.DisplayName) ? currentUser.Username : currentUser.DisplayName);
        }

        // Swap the screen in pnlContent and visually mark which nav button is active.
        public void LoadScreen(UserControl screen, Button navButton = null)
        {
            if (screen == null) return;

            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }
            pnlContent.Controls.Clear();

            screen.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(screen);

            HighlightNav(navButton);
            ThemeService.ApplyToForm(this);
        }

        // Highlights the active sidebar button and resets the previous one.
        private void HighlightNav(Button navButton)
        {
            if (_activeNav != null)
            {
                _activeNav.BackColor = SidebarBg;
            }
            _activeNav = navButton;
            if (_activeNav != null)
            {
                _activeNav.BackColor = SidebarActive;
            }
        }

        // Adds hover background colour to sidebar nav buttons when they are not active.
        private void WireSidebarHoverEffects()
        {
            // Apply consistent hover behaviour to every nav button defined in the Designer.
            foreach (Control navControl in flowNav.Controls)
            {
                Button navButton = navControl as Button;
                if (navButton == null) continue;
                navButton.MouseEnter += (sender, args) =>
                {
                    if (sender != _activeNav) ((Button)sender).BackColor = SidebarHover;
                };
                navButton.MouseLeave += (sender, args) =>
                {
                    if (sender != _activeNav) ((Button)sender).BackColor = SidebarBg;
                };
            }
        }

        // Hide/disable nav buttons the current role can't use.
        private void ApplyRolePermissions()
        {
            User currentUser = AppState.CurrentUser;
            string role = currentUser != null ? currentUser.Role : "Employee";

            // Reset visibility first so role can be re-applied (e.g. after switching user).
            btnDashboard.Visible      = true;
            btnInventory.Visible      = true;
            btnBuildOrders.Visible    = true;
            btnOrderHistory.Visible   = true;
            btnCustomers.Visible      = true;
            btnSuppliers.Visible      = true;
            btnPurchaseOrders.Visible = true;
            btnReports.Visible        = true;
            btnAlerts.Visible         = true;
            btnUserMgmt.Visible       = true;
            btnSettings.Visible       = true;
            btnLogout.Visible         = true;

            if (role == "Manager")
            {
                btnUserMgmt.Visible = false;
            }
            else if (role == "Employee")
            {
                btnUserMgmt.Visible = false;
                btnSuppliers.Visible = false;
                btnPurchaseOrders.Visible = false;
                btnReports.Visible = false;
            }
        }

        // ---- Nav button event handlers ----

        // Opens the dashboard screen.
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadScreen(new DashboardControl(), btnDashboard);
        }

        // Opens the inventory screen.
        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadScreen(new InventoryControl(), btnInventory);
        }

        // Opens the order builder screen.
        private void btnBuildOrders_Click(object sender, EventArgs e)
        {
            LoadScreen(new OrderBuilderControl(), btnBuildOrders);
        }

        // Opens the order history screen.
        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            LoadScreen(new OrderHistoryControl(), btnOrderHistory);
        }

        // Opens the customers screen.
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LoadScreen(new CustomerControl(), btnCustomers);
        }

        // Opens the suppliers screen.
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            LoadScreen(new SupplierControl(), btnSuppliers);
        }

        // Opens the purchase orders screen.
        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            LoadScreen(new PurchaseOrdersControl(), btnPurchaseOrders);
        }

        // Opens the reports screen.
        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadScreen(new ReportsControl(), btnReports);
        }

        // Opens the alerts screen.
        private void btnAlerts_Click(object sender, EventArgs e)
        {
            LoadScreen(new AlertsControl(), btnAlerts);
        }

        // Opens user management (admin only).
        private void btnUserMgmt_Click(object sender, EventArgs e)
        {
            LoadScreen(new UserManagementControl(), btnUserMgmt);
        }

        // Opens application settings.
        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadScreen(new SettingsControl(), btnSettings);
        }

        // Signs out and returns to the login screen.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to sign out?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            AppState.Logout();
            this.DialogResult = DialogResult.Retry; // Tells Program.Main to relaunch login.
            this.Close();
        }

        // Saves all data to disk when the main window is closing.
        private void MainShellForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Belt-and-braces save: each service already writes on every mutation,
            // but on close we flush everything anyway.
            AppState.SaveAll();
        }
    }
}
