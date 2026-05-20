using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Reports screen: charts + summary tables built live from OrderService.

    public partial class ReportsControl : UserControl
    {

        // Initializes date range pickers and report charts

        public ReportsControl()
        {
            InitializeComponent();
        }

        // Sets default date range to last 30 days and builds initial report

        private void ReportsControl_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddDays(-30);
            dtpEnd.Value = DateTime.Today;
            BuildReport();
        }

        // Rebuilds all charts and grids for the selected date range

        private void btnApply_Click(object sender, EventArgs e) { BuildReport(); }

        // Exports filtered completed orders to CSV

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "deskwise-report-" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".csv"
            })
            {
                if (saveDialog.ShowDialog(this.FindForm()) != DialogResult.OK) return;
                var orders = FilteredOrders();
                StringBuilder csvContent = new StringBuilder();
                csvContent.AppendLine("OrderId,Date,Customer,Employee,Payment,Status,Subtotal,Tax,Discount,Total");
                foreach (Order order in orders)
                {
                    csvContent.AppendLine(string.Join(",", new[]
                    {
                        order.OrderId,
                        order.Date.ToString("yyyy-MM-dd"),
                        EscapeCsvField(order.CustomerName),
                        EscapeCsvField(order.EmployeeUsername),
                        EscapeCsvField(order.PaymentMethod),
                        EscapeCsvField(order.Status),
                        order.Subtotal.ToString("F2"),
                        order.Tax.ToString("F2"),
                        order.Discount.ToString("F2"),
                        order.Total.ToString("F2")
                    }));
                }
                File.WriteAllText(saveDialog.FileName, csvContent.ToString());
                MessageBox.Show("Report exported.", "Export Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Wraps CSV field values that contain commas or quotes

        private static string EscapeCsvField(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            if (value.Contains(",") || value.Contains("\"")) return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        // Returns completed orders within the selected start/end date range

        private List<Order> FilteredOrders()
        {
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date.AddDays(1).AddTicks(-1);
            return OrderService.All
                .Where(order => order.Date >= start && order.Date <= end && order.Status == "Completed")
                .ToList();
        }

        // Refreshes KPIs, charts, staff/category grids, and insight text

        private void BuildReport()
        {
            var orders = FilteredOrders();

            // KPI labels
            lblOrders.Text = orders.Count.ToString();
            lblRevenue.Text = orders.Sum(order => order.Total).ToString("C2");
            lblItems.Text = orders.SelectMany(order => order.Items).Sum(lineItem => lineItem.Quantity).ToString();
            lblAvg.Text = orders.Count == 0
                ? "$0.00"
                : (orders.Sum(order => order.Total) / orders.Count).ToString("C2");
            BuildSalesChart(orders);
            BuildCategoryPieChart(orders);
            BuildStaffGrid(orders);
            BuildCategoryGrid(orders);
            BuildInsights(orders);
        }

        // Plots daily revenue line chart across the selected date range

        private void BuildSalesChart(List<Order> orders)
        {
            chartSales.Series.Clear();
            chartSales.ChartAreas.Clear();
            chartSales.Legends.Clear();
            ChartArea area = new ChartArea("salesArea");
            ConfigureChartArea(area);
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8f);
            area.AxisY.LabelStyle.Format = "C0";
            area.AxisY.Minimum = 0;
            chartSales.ChartAreas.Add(area);
            Series dailySalesSeries = new Series("Daily Sales")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.FromArgb(37, 99, 235),
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 7,
                XValueType = ChartValueType.String
            };
            chartSales.Series.Add(dailySalesSeries);
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;
            for (DateTime day = start; day <= end; day = day.AddDays(1))
            {
                decimal dayTotal = orders.Where(order => order.Date.Date == day).Sum(order => order.Total);
                dailySalesSeries.Points.AddXY(day.ToString("MM/dd"), (double)dayTotal);
            }
            chartSales.Titles.Clear();
            Title salesTitle = new Title("Daily Sales")
            {
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59)
            };
            chartSales.Titles.Add(salesTitle);
        }

        // Builds pie chart of revenue share by product category

        private void BuildCategoryPieChart(List<Order> orders)
        {
            chartProducts.Series.Clear();
            chartProducts.ChartAreas.Clear();
            chartProducts.Legends.Clear();

            ChartArea area = new ChartArea("categoryArea");
            ConfigureChartArea(area);
            area.Area3DStyle.Enable3D = false;
            chartProducts.ChartAreas.Add(area);

            Legend legend = new Legend("categoryLegend")
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Center,
                Font = new Font("Segoe UI", 8f),
                LegendStyle = LegendStyle.Column
            };
            chartProducts.Legends.Add(legend);

            var categoryTotals = orders
                .SelectMany(order => order.Items)
                .GroupBy(lineItem =>
                {
                    Product product = ProductService.GetById(lineItem.ProductId);
                    return product != null ? (product.Category ?? "Other") : "Other";
                })
                .Select(categoryGroup => new
                {
                    Category = categoryGroup.Key,
                    Revenue = categoryGroup.Sum(lineItem => lineItem.Subtotal)
                })
                .Where(row => row.Revenue > 0)
                .OrderByDescending(row => row.Revenue)
                .Take(6)
                .ToList();

            Series categorySeries = new Series("Revenue by Category")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "categoryArea",
                Legend = "categoryLegend",
                IsValueShownAsLabel = true,
                Label = "#PERCENT{P0}",
                Font = new Font("Segoe UI", 8f),
                CustomProperties = "PieLabelStyle=Outside, PieLineColor=DimGray"
            };
            chartProducts.Series.Add(categorySeries);

            Color[] sliceColors =
            {
                Color.FromArgb(37, 99, 235),
                Color.FromArgb(22, 163, 74),
                Color.FromArgb(234, 88, 12),
                Color.FromArgb(168, 85, 247),
                Color.FromArgb(14, 165, 233),
                Color.FromArgb(220, 38, 38)
            };
            int colorIndex = 0;
            foreach (var categoryRow in categoryTotals)
            {
                int pointIndex = categorySeries.Points.AddXY(categoryRow.Category, (double)categoryRow.Revenue);
                categorySeries.Points[pointIndex].LegendText = categoryRow.Category;
                categorySeries.Points[pointIndex].Color = sliceColors[colorIndex % sliceColors.Length];
                colorIndex++;
            }

            if (categoryTotals.Count == 0)
            {
                int emptyPoint = categorySeries.Points.AddXY("No sales", 1);
                categorySeries.Points[emptyPoint].Color = Color.FromArgb(226, 232, 240);
                categorySeries.IsValueShownAsLabel = false;
            }

            chartProducts.Titles.Clear();
            Title categoryTitle = new Title("Revenue by Category")
            {
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59)
            };
            chartProducts.Titles.Add(categoryTitle);
        }

        // Sets chart area margins so the plot is not clipped in tight layouts

        private static void ConfigureChartArea(ChartArea area)
        {
            area.BackColor = Color.White;
            area.Position.Auto = false;
            area.Position.X = 4;
            area.Position.Y = 14;
            area.Position.Width = 92;
            area.Position.Height = 78;
            area.InnerPlotPosition.Auto = false;
            area.InnerPlotPosition.X = 8;
            area.InnerPlotPosition.Y = 8;
            area.InnerPlotPosition.Width = 84;
            area.InnerPlotPosition.Height = 84;
        }

        // Binds staff performance grid grouped by employee username

        private void BuildStaffGrid(List<Order> orders)
        {
            dgvStaff.AutoGenerateColumns = false;
            if (dgvStaff.Columns.Count == 0)
            {
                dgvStaff.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Employee", HeaderText = "Employee", Width = 150 });
                dgvStaff.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderCount", HeaderText = "Orders", Width = 80 });
                dgvStaff.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Revenue", HeaderText = "Revenue", Width = 110, DefaultCellStyle = { Format = "C2" } });
            }
            var rows = orders
                .GroupBy(order => order.EmployeeUsername)
                .Select(staffGroup => new StaffRow
                {
                    Employee = string.IsNullOrEmpty(staffGroup.Key) ? "(unknown)" : staffGroup.Key,
                    OrderCount = staffGroup.Count(),
                    Revenue = staffGroup.Sum(order => order.Total)
                })
                .OrderByDescending(row => row.Revenue)
                .ToList();
            dgvStaff.DataSource = null;
            dgvStaff.DataSource = rows;
        }

        // Binds category revenue grid with units and totals per category

        private void BuildCategoryGrid(List<Order> orders)
        {
            dgvCategory.AutoGenerateColumns = false;
            if (dgvCategory.Columns.Count == 0)
            {
                dgvCategory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category",   HeaderText = "Category",   Width = 150 });
                dgvCategory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Units",      HeaderText = "Units",      Width = 80 });
                dgvCategory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Revenue",    HeaderText = "Revenue",    Width = 110, DefaultCellStyle = { Format = "C2" } });
            }

            // Resolve each line item's category from ProductService.
            var rows = orders
                .SelectMany(order => order.Items)
                .GroupBy(lineItem =>
                {
                    Product product = ProductService.GetById(lineItem.ProductId);
                    return product != null ? (product.Category ?? "Other") : "Other";
                })
                .Select(categoryGroup => new CategoryRow
                {
                    Category = categoryGroup.Key,
                    Units = categoryGroup.Sum(lineItem => lineItem.Quantity),
                    Revenue = categoryGroup.Sum(lineItem => lineItem.Subtotal)
                })
                .OrderByDescending(row => row.Revenue)
                .ToList();
            dgvCategory.DataSource = null;
            dgvCategory.DataSource = rows;
        }

        // Fills insight text box with stock, category, and PO summary bullets

        private void BuildInsights(List<Order> orders)
        {
            StringBuilder insightsText = new StringBuilder();
            insightsText.AppendLine("Predictive Insights:");
            insightsText.AppendLine();
            int lowStock = ProductService.GetLowStock().Count;
            insightsText.AppendLine("- " + lowStock + " product(s) currently at or below reorder level.");
            var topCategory = orders
                .SelectMany(order => order.Items)
                .GroupBy(lineItem =>
                {
                    Product product = ProductService.GetById(lineItem.ProductId);
                    return product != null ? product.Category : null;
                })
                .Where(categoryGroup => !string.IsNullOrEmpty(categoryGroup.Key))
                .OrderByDescending(categoryGroup => categoryGroup.Sum(lineItem => lineItem.Subtotal))
                .FirstOrDefault();
            if (topCategory != null)
            {
                insightsText.AppendLine("- Highest revenue category: " + topCategory.Key + " (" +
                    topCategory.Sum(lineItem => lineItem.Subtotal).ToString("C2") + ").");
            }
            if (orders.Count > 0)
            {
                decimal averageOrderValue = orders.Sum(order => order.Total) / orders.Count;
                insightsText.AppendLine("- Average order value: " + averageOrderValue.ToString("C2") +
                    ". Suggest upsell prompts at checkout when cart total < " + (averageOrderValue * 0.7m).ToString("C2") + ".");
            }
            else
            {
                insightsText.AppendLine("- No completed orders in the selected period.");
            }
            int pendingPurchaseOrders = PurchaseOrderService.CountByStatus("Pending") + PurchaseOrderService.CountByStatus("Sent");
            if (pendingPurchaseOrders > 0)
            {
                insightsText.AppendLine("- " + pendingPurchaseOrders + " purchase order(s) outstanding; expect stock arrivals soon.");
            }
            txtInsights.Text = insightsText.ToString();
        }

        // Row model for staff performance grid binding

        private class StaffRow
        {

            public string Employee { get; set; }

            public int OrderCount { get; set; }

            public decimal Revenue { get; set; }
        }

        // Row model for category breakdown grid binding

        private class CategoryRow
        {

            public string Category { get; set; }

            public int Units { get; set; }

            public decimal Revenue { get; set; }
        }
    }
}
