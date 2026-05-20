using System;
using System.Linq;
using System.Windows.Forms;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Live alerts dashboard. Re-evaluates each time the screen is opened.

    public partial class AlertsControl : UserControl
    {

        // Initializes alert grid columns and filter controls

        public AlertsControl()
        {
            InitializeComponent();
        }

        // Loads filters and binds the alert grid on first display

        private void AlertsControl_Load(object sender, EventArgs e)
        {
            SetupGrid();
            PopulateFilters();
            RefreshGrid();
        }

        // Configures read-only alert grid columns and row formatting hook

        private void SetupGrid()
        {
            dgvAlerts.AutoGenerateColumns = false;
            dgvAlerts.Columns.Clear();
            dgvAlerts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Type",     HeaderText = "Type",     Width = 130 });
            dgvAlerts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Priority", HeaderText = "Priority", Width = 90 });
            dgvAlerts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Message",  HeaderText = "Message",  Width = 480 });
            dgvAlerts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Reference",HeaderText = "Ref",      Width = 100 });
            dgvAlerts.ReadOnly = true;
            dgvAlerts.RowHeadersVisible = false;
            dgvAlerts.AllowUserToAddRows = false;
            dgvAlerts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlerts.MultiSelect = false;
            dgvAlerts.CellFormatting += DgvAlerts_CellFormatting;
        }

        // Sets font colours for high, medium, and low priority

        private void DgvAlerts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string columnName = dgvAlerts.Columns[e.ColumnIndex].DataPropertyName;
            if (columnName == "Priority")
            {
                string priority = e.Value as string;

                // Colour-code priority column for quick scanning
                switch (priority)
                {
                    case "High":   e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28); e.CellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f); break;
                    case "Medium": e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(202, 138, 4); break;
                    default:       e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105); break;
                }
            }
        }

        // Fills type and priority filter dropdowns with default selections

        private void PopulateFilters()
        {
            cmbType.Items.Clear();
            cmbType.Items.AddRange(new object[] { "All", "Low Stock", "Out of Stock", "Pending PO" });
            cmbType.SelectedItem = "All";
            cmbPriority.Items.Clear();
            cmbPriority.Items.AddRange(new object[] { "All", "High", "Medium", "Low" });
            cmbPriority.SelectedItem = "All";
        }

        // Reloads alerts from service, applies filters, and updates summary labels

        private void RefreshGrid()
        {
            var all = AlertService.GetAll();
            string type = cmbType.SelectedItem != null ? cmbType.SelectedItem.ToString() : "All";
            string priorityFilter = cmbPriority.SelectedItem != null ? cmbPriority.SelectedItem.ToString() : "All";

            // Filter by type and priority, then sort high priority first
            var filtered = all
                .Where(alert => type == "All" || alert.Type == type)
                .Where(alert => priorityFilter == "All" || alert.Priority == priorityFilter)
                .OrderBy(alert => PriorityRank(alert.Priority))
                .ToList();
            dgvAlerts.DataSource = null;
            dgvAlerts.DataSource = filtered;

            // KPI counts use full alert list, not just filtered rows
            lblHigh.Text   = "High: "   + all.Count(alert => alert.Priority == "High");
            lblMedium.Text = "Medium: " + all.Count(alert => alert.Priority == "Medium");
            lblLow.Text    = "Low: "    + all.Count(alert => alert.Priority == "Low");
            lblTotal.Text  = all.Count + " active alert(s)";
        }

        // Maps priority label to sort order (High before Medium before Low)

        private int PriorityRank(string priority)
        {
            switch (priority)
            {
                case "High":   return 0;
                case "Medium": return 1;
                default:       return 2;
            }
        }

        // Rebinds grid when alert type filter changes

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e) { RefreshGrid(); }

        // Rebinds grid when priority filter changes

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e) { RefreshGrid(); }

        // Reloads alerts from service when refresh button is clicked

        private void btnRefresh_Click(object sender, EventArgs e) { RefreshGrid(); }
    }
}
