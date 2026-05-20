using System;
using System.IO;
using System.Windows.Forms;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Application settings - tax rate, receipt text, backups. Manager/Admin only.

    public partial class SettingsControl : UserControl
    {

        // Initializes settings form controls

        public SettingsControl()
        {
            InitializeComponent();
        }

        // Loads current settings into controls and disables save for Employees

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            cmbAutoBackup.Items.AddRange(new object[] { "Off", "Daily", "Weekly" });
            cmbTheme.Items.AddRange(new object[] { "Light", "Dark" });
            LoadFromSettings();

            // Employees can look but not save.
            if (AppState.CurrentUser != null && AppState.CurrentUser.Role == "Employee")
            {
                btnSave.Enabled = false;
                btnReset.Enabled = false;
                btnBackup.Enabled = false;
                btnRestore.Enabled = false;
            }
        }

        // Copies AppSettings values into form fields

        private void LoadFromSettings()
        {
            AppSettings settings = SettingsService.Current;
            nudTaxRate.Value = decimal.Round(settings.TaxRate * 100m, 2);
            txtCompany.Text = settings.CompanyName ?? "DeskWise";
            txtReceiptHeader.Text = settings.ReceiptHeader ?? string.Empty;
            txtReceiptFooter.Text = settings.ReceiptFooter ?? string.Empty;
            nudLowStock.Value = Math.Max(0, settings.LowStockThreshold);
            cmbAutoBackup.SelectedItem = string.IsNullOrEmpty(settings.AutoBackup) ? "Off" : settings.AutoBackup;
            cmbTheme.SelectedItem = string.IsNullOrEmpty(settings.Theme) ? "Light" : settings.Theme;
        }

        // Persists form values to SettingsService and shows confirmation

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppSettings copy = new AppSettings
            {
                TaxRate = nudTaxRate.Value / 100m,
                CompanyName = string.IsNullOrWhiteSpace(txtCompany.Text) ? "DeskWise" : txtCompany.Text.Trim(),
                ReceiptHeader = txtReceiptHeader.Text.Trim(),
                ReceiptFooter = txtReceiptFooter.Text.Trim(),
                LowStockThreshold = (int)nudLowStock.Value,
                AutoBackup = cmbAutoBackup.SelectedItem != null ? cmbAutoBackup.SelectedItem.ToString() : "Off",
                Theme = cmbTheme.SelectedItem != null ? cmbTheme.SelectedItem.ToString() : "Light"
            };
            SettingsService.Save(copy);
            MessageBox.Show("Settings saved. Theme and tax rate apply immediately.", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Resets settings to defaults after user confirmation

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Reset all settings to defaults?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            SettingsService.Save(new AppSettings());
            LoadFromSettings();
        }

        // Copies deskwise.json to a timestamped file in the Backups folder

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string storePath = DataStoreService.StoreFilePath;
                if (!File.Exists(storePath))
                {
                    MessageBox.Show("No data file found. Save some data first.", "Backup",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string backupsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backups");
                Directory.CreateDirectory(backupsDir);
                string fileName = "deskwise-backup-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".json";
                string fullPath = Path.Combine(backupsDir, fileName);
                File.Copy(storePath, fullPath, true);
                MessageBox.Show("Backup written to:\r\n" + fullPath, "Backup",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup failed: " + ex.Message, "Backup",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Overwrites deskwise.json from a user-selected backup file

        private void btnRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openDialog.Title = "Restore from backup";
                if (openDialog.ShowDialog(this.FindForm()) != DialogResult.OK) return;
                DialogResult confirm = MessageBox.Show(
                    "Restoring will overwrite deskwise.json. Continue?",
                    "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;
                try
                {
                    File.Copy(openDialog.FileName, DataStoreService.StoreFilePath, true);
                    AppState.Initialize();
                    ThemeService.ApplyToForm(this.FindForm() as Form);
                    MessageBox.Show("Restore complete. Data has been reloaded.",
                        "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Restore failed: " + ex.Message, "Restore",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
