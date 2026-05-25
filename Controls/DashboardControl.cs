using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DeskWise.Forms;
using DeskWise;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Main dashboard screen.
    // - 5 KPI cards across the top (totals, low stock, today's sales, pending orders, monthly revenue).
    // - Sales overview line chart - last 7 days of completed orders.
    // - Recent activity and low-stock alerts side-by-side.
    // - 4 quick-action buttons (Add Product, New Order, Generate Report, Restock Inventory).

    public partial class DashboardControl : UserControl
    {

        // Initializes dashboard layout and child controls

        public DashboardControl()
        {
            InitializeComponent();
        }

        // Binds KPIs, sales chart, recent orders, and low-stock list on load

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            BindKpis();
            BuildSalesChart();
            PopulateRecentActivity();
            PopulateLowStock();
        }

        // Fills top KPI cards from product and order services

        private void BindKpis()
        {
            lblTotalProductsValue.Text = ProductService.All.Count.ToString();
            lblLowStockValue.Text = ProductService.GetLowStock().Count.ToString();
            lblTodaysSalesValue.Text = OrderService.TotalSalesToday().ToString("C2");
            lblPendingOrdersValue.Text = OrderService.CountPending().ToString();
            lblMonthlyRevenueValue.Text = OrderService.TotalRevenueThisMonth().ToString("C2");
        }

        // Bins last 7 days of completed orders by date and plots total revenue per day

        private void BuildSalesChart()
        {
            chartSales.Series.Clear();
            chartSales.ChartAreas.Clear();
            chartSales.Legends.Clear();
            chartSales.Titles.Clear();

            ChartArea area = new ChartArea("MainArea");
            ConfigureChartArea(area);
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(226, 232, 240);
            area.AxisY.Minimum = 0;
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);
            area.AxisY.LabelStyle.Format = "C0";
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(226, 232, 240);
            chartSales.ChartAreas.Add(area);

            Series series = new Series("Sales")
            {
                ChartArea = "MainArea",
                ChartType = SeriesChartType.Line,
                Color = Color.FromArgb(37, 99, 235),
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                MarkerColor = Color.FromArgb(37, 99, 235),
                XValueType = ChartValueType.String,
                IsXValueIndexed = true
            };
            chartSales.Series.Add(series);

            DateTime start;
            DateTime end;
            OrderService.GetSalesChartWindow(out start, out end);

            for (DateTime day = start.Date; day <= end.Date; day = day.AddDays(1))
            {
                decimal total = OrderService.All
                    .Where(order => order.Date.Date == day
                        && string.Equals(order.Status, "Completed", StringComparison.OrdinalIgnoreCase))
                    .Sum(order => order.Total);
                series.Points.AddXY(day.ToString("ddd"), (double)total);
            }
        }

        private static void ConfigureChartArea(ChartArea area)
        {
            area.BackColor = Color.White;
            area.Position.Auto = false;
            area.Position.X = 4;
            area.Position.Y = 8;
            area.Position.Width = 92;
            area.Position.Height = 82;
            area.InnerPlotPosition.Auto = false;
            area.InnerPlotPosition.X = 8;
            area.InnerPlotPosition.Y = 8;
            area.InnerPlotPosition.Width = 84;
            area.InnerPlotPosition.Height = 84;
        }

        // Lists the six most recent orders in the activity panel

        private void PopulateRecentActivity()
        {
            lstRecentActivity.Items.Clear();
            IEnumerable<Order> recent = OrderService.Recent(6);
            if (!recent.Any())
            {
                lstRecentActivity.Items.Add("No orders yet - start a sale to see activity here.");
                return;
            }
            foreach (Order order in recent)
            {
                lstRecentActivity.Items.Add(string.Format("{0} - {1} ({2:C2}) - {3}",
                    order.OrderId, order.CustomerName, order.Total, order.Date.ToString("HH:mm dd/MM")));
            }
        }

        // Shows up to six low-stock products with quantity and status

        private void PopulateLowStock()
        {
            lstLowStock.Items.Clear();
            List<Product> low = ProductService.GetLowStock();
            if (low.Count == 0)
            {
                lstLowStock.Items.Add("All products are above the reorder level.");
                return;
            }
            foreach (Product product in low.Take(6))
            {
                lstLowStock.Items.Add(string.Format("{0} - {1} in stock ({2})",
                    product.Name, product.Quantity, product.StatusDisplay));
            }
        }

        // Opens product edit dialog and refreshes KPIs when a product is added

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (ProductEditForm editDialog = new ProductEditForm())
            {
                if (editDialog.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    BindKpis();
                    PopulateLowStock();
                }
            }
        }

        // Navigates to Order Builder for a new sale

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            MainShellForm main = this.FindForm() as MainShellForm;
            if (main != null) main.LoadScreen(new OrderBuilderControl());
        }

        // Navigates to Reports screen

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            MainShellForm main = this.FindForm() as MainShellForm;
            if (main != null) main.LoadScreen(new ReportsControl());
        }

        // Navigates to Purchase Orders for restocking

        private void btnRestock_Click(object sender, EventArgs e)
        {
            MainShellForm mainForm = this.FindForm() as MainShellForm;
            if (mainForm != null)
            {
                mainForm.LoadScreen(new PurchaseOrdersControl());
            }
        }
    }
}
