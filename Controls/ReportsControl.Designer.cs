using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DeskWise.Controls
{
    partial class ReportsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblToCap = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblFromCap = new System.Windows.Forms.Label();
            this.pnlKpis = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKpiOrders = new System.Windows.Forms.Panel();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblOrdersCaption = new System.Windows.Forms.Label();
            this.pnlKpiRevenue = new System.Windows.Forms.Panel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblRevenueCaption = new System.Windows.Forms.Label();
            this.pnlKpiItems = new System.Windows.Forms.Panel();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblItemsCaption = new System.Windows.Forms.Label();
            this.pnlKpiAvg = new System.Windows.Forms.Panel();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblAvgCaption = new System.Windows.Forms.Label();
            this.tlpCharts = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSalesChart = new System.Windows.Forms.Panel();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlProductsChart = new System.Windows.Forms.Panel();
            this.chartProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpGrids = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.lblStaffTitle = new System.Windows.Forms.Label();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.pnlInsights = new System.Windows.Forms.Panel();
            this.txtInsights = new System.Windows.Forms.TextBox();
            this.lblInsightsTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlKpis.SuspendLayout();
            this.pnlKpiOrders.SuspendLayout();
            this.pnlKpiRevenue.SuspendLayout();
            this.pnlKpiItems.SuspendLayout();
            this.pnlKpiAvg.SuspendLayout();
            this.tlpCharts.SuspendLayout();
            this.pnlSalesChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.pnlProductsChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).BeginInit();
            this.tlpGrids.SuspendLayout();
            this.pnlStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.pnlCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.pnlInsights.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 70);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Reports & Analytics";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlToolbar.Controls.Add(this.btnExport);
            this.pnlToolbar.Controls.Add(this.btnApply);
            this.pnlToolbar.Controls.Add(this.dtpEnd);
            this.pnlToolbar.Controls.Add(this.lblToCap);
            this.pnlToolbar.Controls.Add(this.dtpStart);
            this.pnlToolbar.Controls.Add(this.lblFromCap);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 70);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 64);
            this.pnlToolbar.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnExport.Location = new System.Drawing.Point(500, 16);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 30);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(395, 16);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(95, 30);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(245, 18);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(130, 25);
            this.dtpEnd.TabIndex = 2;
            // 
            // lblToCap
            // 
            this.lblToCap.AutoSize = true;
            this.lblToCap.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblToCap.Location = new System.Drawing.Point(210, 22);
            this.lblToCap.Name = "lblToCap";
            this.lblToCap.Size = new System.Drawing.Size(25, 17);
            this.lblToCap.TabIndex = 3;
            this.lblToCap.Text = "To:";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(65, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(130, 25);
            this.dtpStart.TabIndex = 4;
            // 
            // lblFromCap
            // 
            this.lblFromCap.AutoSize = true;
            this.lblFromCap.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFromCap.Location = new System.Drawing.Point(20, 22);
            this.lblFromCap.Name = "lblFromCap";
            this.lblFromCap.Size = new System.Drawing.Size(41, 17);
            this.lblFromCap.TabIndex = 5;
            this.lblFromCap.Text = "From:";
            // 
            // pnlKpis
            // 
            this.pnlKpis.BackColor = System.Drawing.Color.White;
            this.pnlKpis.ColumnCount = 4;
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlKpis.Controls.Add(this.pnlKpiOrders, 0, 0);
            this.pnlKpis.Controls.Add(this.pnlKpiRevenue, 1, 0);
            this.pnlKpis.Controls.Add(this.pnlKpiItems, 2, 0);
            this.pnlKpis.Controls.Add(this.pnlKpiAvg, 3, 0);
            this.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpis.Location = new System.Drawing.Point(0, 134);
            this.pnlKpis.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlKpis.Name = "pnlKpis";
            this.pnlKpis.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlKpis.RowCount = 1;
            this.pnlKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlKpis.Size = new System.Drawing.Size(1100, 108);
            this.pnlKpis.TabIndex = 2;
            // 
            // pnlKpiOrders
            // 
            this.pnlKpiOrders.BackColor = System.Drawing.Color.White;
            this.pnlKpiOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiOrders.Controls.Add(this.lblOrders);
            this.pnlKpiOrders.Controls.Add(this.lblOrdersCaption);
            this.pnlKpiOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiOrders.Location = new System.Drawing.Point(26, 18);
            this.pnlKpiOrders.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiOrders.Name = "pnlKpiOrders";
            this.pnlKpiOrders.Size = new System.Drawing.Size(253, 72);
            this.pnlKpiOrders.TabIndex = 0;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblOrders.Location = new System.Drawing.Point(12, 30);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(38, 32);
            this.lblOrders.TabIndex = 0;
            this.lblOrders.Text = "—";
            // 
            // lblOrdersCaption
            // 
            this.lblOrdersCaption.AutoSize = true;
            this.lblOrdersCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrdersCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblOrdersCaption.Location = new System.Drawing.Point(12, 10);
            this.lblOrdersCaption.Name = "lblOrdersCaption";
            this.lblOrdersCaption.Size = new System.Drawing.Size(42, 15);
            this.lblOrdersCaption.TabIndex = 1;
            this.lblOrdersCaption.Text = "Orders";
            // 
            // pnlKpiRevenue
            // 
            this.pnlKpiRevenue.BackColor = System.Drawing.Color.White;
            this.pnlKpiRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiRevenue.Controls.Add(this.lblRevenue);
            this.pnlKpiRevenue.Controls.Add(this.lblRevenueCaption);
            this.pnlKpiRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiRevenue.Location = new System.Drawing.Point(291, 18);
            this.pnlKpiRevenue.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiRevenue.Name = "pnlKpiRevenue";
            this.pnlKpiRevenue.Size = new System.Drawing.Size(253, 72);
            this.pnlKpiRevenue.TabIndex = 1;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblRevenue.Location = new System.Drawing.Point(12, 30);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(38, 32);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "—";
            // 
            // lblRevenueCaption
            // 
            this.lblRevenueCaption.AutoSize = true;
            this.lblRevenueCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRevenueCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRevenueCaption.Location = new System.Drawing.Point(12, 10);
            this.lblRevenueCaption.Name = "lblRevenueCaption";
            this.lblRevenueCaption.Size = new System.Drawing.Size(52, 15);
            this.lblRevenueCaption.TabIndex = 1;
            this.lblRevenueCaption.Text = "Revenue";
            // 
            // pnlKpiItems
            // 
            this.pnlKpiItems.BackColor = System.Drawing.Color.White;
            this.pnlKpiItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiItems.Controls.Add(this.lblItems);
            this.pnlKpiItems.Controls.Add(this.lblItemsCaption);
            this.pnlKpiItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiItems.Location = new System.Drawing.Point(556, 18);
            this.pnlKpiItems.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiItems.Name = "pnlKpiItems";
            this.pnlKpiItems.Size = new System.Drawing.Size(253, 72);
            this.pnlKpiItems.TabIndex = 2;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(70)))), ((int)(((byte)(239)))));
            this.lblItems.Location = new System.Drawing.Point(12, 30);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(38, 32);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "—";
            // 
            // lblItemsCaption
            // 
            this.lblItemsCaption.AutoSize = true;
            this.lblItemsCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblItemsCaption.Location = new System.Drawing.Point(12, 10);
            this.lblItemsCaption.Name = "lblItemsCaption";
            this.lblItemsCaption.Size = new System.Drawing.Size(62, 15);
            this.lblItemsCaption.TabIndex = 1;
            this.lblItemsCaption.Text = "Items Sold";
            // 
            // pnlKpiAvg
            // 
            this.pnlKpiAvg.BackColor = System.Drawing.Color.White;
            this.pnlKpiAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiAvg.Controls.Add(this.lblAvg);
            this.pnlKpiAvg.Controls.Add(this.lblAvgCaption);
            this.pnlKpiAvg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiAvg.Location = new System.Drawing.Point(821, 18);
            this.pnlKpiAvg.Margin = new System.Windows.Forms.Padding(6);
            this.pnlKpiAvg.Name = "pnlKpiAvg";
            this.pnlKpiAvg.Size = new System.Drawing.Size(253, 72);
            this.pnlKpiAvg.TabIndex = 3;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAvg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblAvg.Location = new System.Drawing.Point(12, 30);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(38, 32);
            this.lblAvg.TabIndex = 0;
            this.lblAvg.Text = "—";
            // 
            // lblAvgCaption
            // 
            this.lblAvgCaption.AutoSize = true;
            this.lblAvgCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvgCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAvgCaption.Location = new System.Drawing.Point(12, 10);
            this.lblAvgCaption.Name = "lblAvgCaption";
            this.lblAvgCaption.Size = new System.Drawing.Size(61, 15);
            this.lblAvgCaption.TabIndex = 1;
            this.lblAvgCaption.Text = "Avg Order";
            // 
            // tlpCharts
            // 
            this.tlpCharts.ColumnCount = 2;
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tlpCharts.Controls.Add(this.pnlSalesChart, 0, 0);
            this.tlpCharts.Controls.Add(this.pnlProductsChart, 1, 0);
            this.tlpCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCharts.Location = new System.Drawing.Point(0, 242);
            this.tlpCharts.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.tlpCharts.Name = "tlpCharts";
            this.tlpCharts.Padding = new System.Windows.Forms.Padding(20, 16, 20, 12);
            this.tlpCharts.RowCount = 1;
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCharts.Size = new System.Drawing.Size(1100, 380);
            this.tlpCharts.TabIndex = 1;
            // 
            // pnlSalesChart
            // 
            this.pnlSalesChart.BackColor = System.Drawing.Color.White;
            this.pnlSalesChart.Controls.Add(this.chartSales);
            this.pnlSalesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesChart.Location = new System.Drawing.Point(20, 16);
            this.pnlSalesChart.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlSalesChart.Name = "pnlSalesChart";
            this.pnlSalesChart.Padding = new System.Windows.Forms.Padding(12, 12, 16, 12);
            this.pnlSalesChart.Size = new System.Drawing.Size(602, 352);
            this.pnlSalesChart.TabIndex = 0;
            // 
            // chartSales
            // 
            this.chartSales.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.chartSales.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSales.Location = new System.Drawing.Point(12, 12);
            this.chartSales.MinimumSize = new System.Drawing.Size(200, 280);
            this.chartSales.Name = "chartSales";
            this.chartSales.Size = new System.Drawing.Size(574, 328);
            this.chartSales.TabIndex = 0;
            // 
            // pnlProductsChart
            // 
            this.pnlProductsChart.BackColor = System.Drawing.Color.White;
            this.pnlProductsChart.Controls.Add(this.chartProducts);
            this.pnlProductsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductsChart.Location = new System.Drawing.Point(646, 16);
            this.pnlProductsChart.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlProductsChart.Name = "pnlProductsChart";
            this.pnlProductsChart.Padding = new System.Windows.Forms.Padding(12);
            this.pnlProductsChart.Size = new System.Drawing.Size(434, 352);
            this.pnlProductsChart.TabIndex = 1;
            // 
            // chartProducts
            // 
            this.chartProducts.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.chartProducts.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartProducts.Location = new System.Drawing.Point(12, 12);
            this.chartProducts.MinimumSize = new System.Drawing.Size(200, 280);
            this.chartProducts.Name = "chartProducts";
            this.chartProducts.Size = new System.Drawing.Size(410, 328);
            this.chartProducts.TabIndex = 0;
            // 
            // tlpGrids
            // 
            this.tlpGrids.ColumnCount = 3;
            this.tlpGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpGrids.Controls.Add(this.pnlStaff, 0, 0);
            this.tlpGrids.Controls.Add(this.pnlCategory, 1, 0);
            this.tlpGrids.Controls.Add(this.pnlInsights, 2, 0);
            this.tlpGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGrids.Location = new System.Drawing.Point(0, 622);
            this.tlpGrids.Name = "tlpGrids";
            this.tlpGrids.Padding = new System.Windows.Forms.Padding(20, 8, 20, 20);
            this.tlpGrids.RowCount = 1;
            this.tlpGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGrids.Size = new System.Drawing.Size(1100, 128);
            this.tlpGrids.TabIndex = 0;
            // 
            // pnlStaff
            // 
            this.pnlStaff.BackColor = System.Drawing.Color.White;
            this.pnlStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaff.Controls.Add(this.dgvStaff);
            this.pnlStaff.Controls.Add(this.lblStaffTitle);
            this.pnlStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStaff.Location = new System.Drawing.Point(20, 8);
            this.pnlStaff.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(341, 100);
            this.pnlStaff.TabIndex = 0;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvStaff.Location = new System.Drawing.Point(0, 38);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowTemplate.Height = 26;
            this.dgvStaff.Size = new System.Drawing.Size(339, 60);
            this.dgvStaff.TabIndex = 0;
            // 
            // lblStaffTitle
            // 
            this.lblStaffTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStaffTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblStaffTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStaffTitle.Location = new System.Drawing.Point(0, 0);
            this.lblStaffTitle.Name = "lblStaffTitle";
            this.lblStaffTitle.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.lblStaffTitle.Size = new System.Drawing.Size(339, 38);
            this.lblStaffTitle.TabIndex = 1;
            this.lblStaffTitle.Text = "Staff Performance";
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.White;
            this.pnlCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategory.Controls.Add(this.dgvCategory);
            this.pnlCategory.Controls.Add(this.lblCategoryTitle);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.Location = new System.Drawing.Point(377, 8);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(333, 100);
            this.pnlCategory.TabIndex = 1;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCategory.Location = new System.Drawing.Point(0, 38);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.RowTemplate.Height = 26;
            this.dgvCategory.Size = new System.Drawing.Size(331, 60);
            this.dgvCategory.TabIndex = 0;
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblCategoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCategoryTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.lblCategoryTitle.Size = new System.Drawing.Size(331, 38);
            this.lblCategoryTitle.TabIndex = 1;
            this.lblCategoryTitle.Text = "Category Summary";
            // 
            // pnlInsights
            // 
            this.pnlInsights.BackColor = System.Drawing.Color.White;
            this.pnlInsights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInsights.Controls.Add(this.txtInsights);
            this.pnlInsights.Controls.Add(this.lblInsightsTitle);
            this.pnlInsights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInsights.Location = new System.Drawing.Point(726, 8);
            this.pnlInsights.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlInsights.Name = "pnlInsights";
            this.pnlInsights.Size = new System.Drawing.Size(354, 100);
            this.pnlInsights.TabIndex = 2;
            // 
            // txtInsights
            // 
            this.txtInsights.BackColor = System.Drawing.Color.White;
            this.txtInsights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInsights.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtInsights.Location = new System.Drawing.Point(0, 38);
            this.txtInsights.Multiline = true;
            this.txtInsights.Name = "txtInsights";
            this.txtInsights.ReadOnly = true;
            this.txtInsights.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInsights.Size = new System.Drawing.Size(352, 60);
            this.txtInsights.TabIndex = 0;
            // 
            // lblInsightsTitle
            // 
            this.lblInsightsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInsightsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblInsightsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblInsightsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblInsightsTitle.Name = "lblInsightsTitle";
            this.lblInsightsTitle.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.lblInsightsTitle.Size = new System.Drawing.Size(352, 38);
            this.lblInsightsTitle.TabIndex = 1;
            this.lblInsightsTitle.Text = "Insights";
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpGrids);
            this.Controls.Add(this.tlpCharts);
            this.Controls.Add(this.pnlKpis);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(1100, 750);
            this.Load += new System.EventHandler(this.ReportsControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlKpis.ResumeLayout(false);
            this.pnlKpiOrders.ResumeLayout(false);
            this.pnlKpiOrders.PerformLayout();
            this.pnlKpiRevenue.ResumeLayout(false);
            this.pnlKpiRevenue.PerformLayout();
            this.pnlKpiItems.ResumeLayout(false);
            this.pnlKpiItems.PerformLayout();
            this.pnlKpiAvg.ResumeLayout(false);
            this.pnlKpiAvg.PerformLayout();
            this.tlpCharts.ResumeLayout(false);
            this.pnlSalesChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.pnlProductsChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).EndInit();
            this.tlpGrids.ResumeLayout(false);
            this.pnlStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.pnlCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.pnlInsights.ResumeLayout(false);
            this.pnlInsights.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlToolbar;
        private Label lblFromCap;
        private DateTimePicker dtpStart;
        private Label lblToCap;
        private DateTimePicker dtpEnd;
        private Button btnApply;
        private Button btnExport;
        private TableLayoutPanel pnlKpis;
        private Panel pnlKpiOrders;
        private Label lblOrdersCaption;
        private Label lblOrders;
        private Panel pnlKpiRevenue;
        private Label lblRevenueCaption;
        private Label lblRevenue;
        private Panel pnlKpiItems;
        private Label lblItemsCaption;
        private Label lblItems;
        private Panel pnlKpiAvg;
        private Label lblAvgCaption;
        private Label lblAvg;
        private TableLayoutPanel tlpCharts;
        private Panel pnlSalesChart;
        private Panel pnlProductsChart;
        private Chart chartSales;
        private Chart chartProducts;
        private TableLayoutPanel tlpGrids;
        private Panel pnlStaff;
        private Label lblStaffTitle;
        private DataGridView dgvStaff;
        private Panel pnlCategory;
        private Label lblCategoryTitle;
        private DataGridView dgvCategory;
        private Panel pnlInsights;
        private Label lblInsightsTitle;
        private TextBox txtInsights;
    }
}
