namespace DeskWise.Controls
{
    partial class DashboardControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlKpis = new System.Windows.Forms.Panel();
            this.pnlTotalProducts = new System.Windows.Forms.Panel();
            this.lblTotalProductsValue = new System.Windows.Forms.Label();
            this.lblTotalProductsCaption = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.lblLowStockCaption = new System.Windows.Forms.Label();
            this.pnlTodaysSales = new System.Windows.Forms.Panel();
            this.lblTodaysSalesValue = new System.Windows.Forms.Label();
            this.lblTodaysSalesCaption = new System.Windows.Forms.Label();
            this.pnlPendingOrders = new System.Windows.Forms.Panel();
            this.lblPendingOrdersValue = new System.Windows.Forms.Label();
            this.lblPendingOrdersCaption = new System.Windows.Forms.Label();
            this.pnlMonthlyRevenue = new System.Windows.Forms.Panel();
            this.lblMonthlyRevenueValue = new System.Windows.Forms.Label();
            this.lblMonthlyRevenueCaption = new System.Windows.Forms.Label();
            this.pnlChartHost = new System.Windows.Forms.Panel();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblActionsTitle = new System.Windows.Forms.Label();
            this.pnlLowStockList = new System.Windows.Forms.Panel();
            this.lstLowStock = new System.Windows.Forms.ListBox();
            this.lblLowStockListTitle = new System.Windows.Forms.Label();
            this.pnlRecentActivity = new System.Windows.Forms.Panel();
            this.lstRecentActivity = new System.Windows.Forms.ListBox();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlKpis.SuspendLayout();
            this.pnlTotalProducts.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlTodaysSales.SuspendLayout();
            this.pnlPendingOrders.SuspendLayout();
            this.pnlMonthlyRevenue.SuspendLayout();
            this.pnlChartHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlLowStockList.SuspendLayout();
            this.pnlRecentActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 50);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // pnlKpis
            // 
            this.pnlKpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlKpis.Controls.Add(this.pnlTotalProducts);
            this.pnlKpis.Controls.Add(this.pnlLowStock);
            this.pnlKpis.Controls.Add(this.pnlTodaysSales);
            this.pnlKpis.Controls.Add(this.pnlPendingOrders);
            this.pnlKpis.Controls.Add(this.pnlMonthlyRevenue);
            this.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpis.Location = new System.Drawing.Point(0, 50);
            this.pnlKpis.Name = "pnlKpis";
            this.pnlKpis.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlKpis.Size = new System.Drawing.Size(1100, 100);
            this.pnlKpis.TabIndex = 2;
            // 
            // pnlTotalProducts
            // 
            this.pnlTotalProducts.BackColor = System.Drawing.Color.White;
            this.pnlTotalProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalProducts.Controls.Add(this.lblTotalProductsValue);
            this.pnlTotalProducts.Controls.Add(this.lblTotalProductsCaption);
            this.pnlTotalProducts.Location = new System.Drawing.Point(20, 12);
            this.pnlTotalProducts.Name = "pnlTotalProducts";
            this.pnlTotalProducts.Size = new System.Drawing.Size(200, 76);
            this.pnlTotalProducts.TabIndex = 0;
            // 
            // lblTotalProductsValue
            // 
            this.lblTotalProductsValue.AutoSize = true;
            this.lblTotalProductsValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTotalProductsValue.Location = new System.Drawing.Point(11, 30);
            this.lblTotalProductsValue.Name = "lblTotalProductsValue";
            this.lblTotalProductsValue.Size = new System.Drawing.Size(28, 32);
            this.lblTotalProductsValue.TabIndex = 0;
            this.lblTotalProductsValue.Text = "0";
            // 
            // lblTotalProductsCaption
            // 
            this.lblTotalProductsCaption.AutoSize = true;
            this.lblTotalProductsCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalProductsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalProductsCaption.Location = new System.Drawing.Point(13, 12);
            this.lblTotalProductsCaption.Name = "lblTotalProductsCaption";
            this.lblTotalProductsCaption.Size = new System.Drawing.Size(83, 15);
            this.lblTotalProductsCaption.TabIndex = 1;
            this.lblTotalProductsCaption.Text = "Total Products";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLowStock.Controls.Add(this.lblLowStockValue);
            this.pnlLowStock.Controls.Add(this.lblLowStockCaption);
            this.pnlLowStock.Location = new System.Drawing.Point(230, 12);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(200, 76);
            this.pnlLowStock.TabIndex = 1;
            // 
            // lblLowStockValue
            // 
            this.lblLowStockValue.AutoSize = true;
            this.lblLowStockValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLowStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblLowStockValue.Location = new System.Drawing.Point(11, 30);
            this.lblLowStockValue.Name = "lblLowStockValue";
            this.lblLowStockValue.Size = new System.Drawing.Size(28, 32);
            this.lblLowStockValue.TabIndex = 0;
            this.lblLowStockValue.Text = "0";
            // 
            // lblLowStockCaption
            // 
            this.lblLowStockCaption.AutoSize = true;
            this.lblLowStockCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLowStockCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLowStockCaption.Location = new System.Drawing.Point(13, 12);
            this.lblLowStockCaption.Name = "lblLowStockCaption";
            this.lblLowStockCaption.Size = new System.Drawing.Size(61, 15);
            this.lblLowStockCaption.TabIndex = 1;
            this.lblLowStockCaption.Text = "Low Stock";
            // 
            // pnlTodaysSales
            // 
            this.pnlTodaysSales.BackColor = System.Drawing.Color.White;
            this.pnlTodaysSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTodaysSales.Controls.Add(this.lblTodaysSalesValue);
            this.pnlTodaysSales.Controls.Add(this.lblTodaysSalesCaption);
            this.pnlTodaysSales.Location = new System.Drawing.Point(440, 12);
            this.pnlTodaysSales.Name = "pnlTodaysSales";
            this.pnlTodaysSales.Size = new System.Drawing.Size(200, 76);
            this.pnlTodaysSales.TabIndex = 2;
            // 
            // lblTodaysSalesValue
            // 
            this.lblTodaysSalesValue.AutoSize = true;
            this.lblTodaysSalesValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTodaysSalesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblTodaysSalesValue.Location = new System.Drawing.Point(11, 30);
            this.lblTodaysSalesValue.Name = "lblTodaysSalesValue";
            this.lblTodaysSalesValue.Size = new System.Drawing.Size(77, 32);
            this.lblTodaysSalesValue.TabIndex = 0;
            this.lblTodaysSalesValue.Text = "$0.00";
            // 
            // lblTodaysSalesCaption
            // 
            this.lblTodaysSalesCaption.AutoSize = true;
            this.lblTodaysSalesCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTodaysSalesCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTodaysSalesCaption.Location = new System.Drawing.Point(13, 12);
            this.lblTodaysSalesCaption.Name = "lblTodaysSalesCaption";
            this.lblTodaysSalesCaption.Size = new System.Drawing.Size(76, 15);
            this.lblTodaysSalesCaption.TabIndex = 1;
            this.lblTodaysSalesCaption.Text = "Today\'s Sales";
            // 
            // pnlPendingOrders
            // 
            this.pnlPendingOrders.BackColor = System.Drawing.Color.White;
            this.pnlPendingOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPendingOrders.Controls.Add(this.lblPendingOrdersValue);
            this.pnlPendingOrders.Controls.Add(this.lblPendingOrdersCaption);
            this.pnlPendingOrders.Location = new System.Drawing.Point(650, 12);
            this.pnlPendingOrders.Name = "pnlPendingOrders";
            this.pnlPendingOrders.Size = new System.Drawing.Size(200, 76);
            this.pnlPendingOrders.TabIndex = 3;
            // 
            // lblPendingOrdersValue
            // 
            this.lblPendingOrdersValue.AutoSize = true;
            this.lblPendingOrdersValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPendingOrdersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPendingOrdersValue.Location = new System.Drawing.Point(11, 30);
            this.lblPendingOrdersValue.Name = "lblPendingOrdersValue";
            this.lblPendingOrdersValue.Size = new System.Drawing.Size(28, 32);
            this.lblPendingOrdersValue.TabIndex = 0;
            this.lblPendingOrdersValue.Text = "0";
            // 
            // lblPendingOrdersCaption
            // 
            this.lblPendingOrdersCaption.AutoSize = true;
            this.lblPendingOrdersCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPendingOrdersCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPendingOrdersCaption.Location = new System.Drawing.Point(13, 12);
            this.lblPendingOrdersCaption.Name = "lblPendingOrdersCaption";
            this.lblPendingOrdersCaption.Size = new System.Drawing.Size(89, 15);
            this.lblPendingOrdersCaption.TabIndex = 1;
            this.lblPendingOrdersCaption.Text = "Pending Orders";
            // 
            // pnlMonthlyRevenue
            // 
            this.pnlMonthlyRevenue.BackColor = System.Drawing.Color.White;
            this.pnlMonthlyRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMonthlyRevenue.Controls.Add(this.lblMonthlyRevenueValue);
            this.pnlMonthlyRevenue.Controls.Add(this.lblMonthlyRevenueCaption);
            this.pnlMonthlyRevenue.Location = new System.Drawing.Point(860, 12);
            this.pnlMonthlyRevenue.Name = "pnlMonthlyRevenue";
            this.pnlMonthlyRevenue.Size = new System.Drawing.Size(200, 76);
            this.pnlMonthlyRevenue.TabIndex = 4;
            // 
            // lblMonthlyRevenueValue
            // 
            this.lblMonthlyRevenueValue.AutoSize = true;
            this.lblMonthlyRevenueValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblMonthlyRevenueValue.Location = new System.Drawing.Point(11, 30);
            this.lblMonthlyRevenueValue.Name = "lblMonthlyRevenueValue";
            this.lblMonthlyRevenueValue.Size = new System.Drawing.Size(77, 32);
            this.lblMonthlyRevenueValue.TabIndex = 0;
            this.lblMonthlyRevenueValue.Text = "$0.00";
            // 
            // lblMonthlyRevenueCaption
            // 
            this.lblMonthlyRevenueCaption.AutoSize = true;
            this.lblMonthlyRevenueCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMonthlyRevenueCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMonthlyRevenueCaption.Location = new System.Drawing.Point(13, 12);
            this.lblMonthlyRevenueCaption.Name = "lblMonthlyRevenueCaption";
            this.lblMonthlyRevenueCaption.Size = new System.Drawing.Size(100, 15);
            this.lblMonthlyRevenueCaption.TabIndex = 1;
            this.lblMonthlyRevenueCaption.Text = "Monthly Revenue";
            // 
            // pnlChartHost
            // 
            this.pnlChartHost.BackColor = System.Drawing.Color.White;
            this.pnlChartHost.Controls.Add(this.chartSales);
            this.pnlChartHost.Controls.Add(this.lblChartTitle);
            this.pnlChartHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChartHost.Location = new System.Drawing.Point(0, 150);
            this.pnlChartHost.Name = "pnlChartHost";
            this.pnlChartHost.Padding = new System.Windows.Forms.Padding(20, 0, 20, 12);
            this.pnlChartHost.Size = new System.Drawing.Size(1100, 240);
            this.pnlChartHost.TabIndex = 1;
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            this.chartSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(20, 27);
            this.chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(1060, 201);
            this.chartSales.TabIndex = 0;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblChartTitle.Location = new System.Drawing.Point(20, 8);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(210, 20);
            this.lblChartTitle.TabIndex = 1;
            this.lblChartTitle.Text = "Sales Overview (Last 7 Days)";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlBottom.Controls.Add(this.pnlActions);
            this.pnlBottom.Controls.Add(this.pnlLowStockList);
            this.pnlBottom.Controls.Add(this.pnlRecentActivity);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 390);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(20, 8, 20, 20);
            this.pnlBottom.Size = new System.Drawing.Size(1100, 310);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.btnRestock);
            this.pnlActions.Controls.Add(this.btnGenerateReport);
            this.pnlActions.Controls.Add(this.btnNewOrder);
            this.pnlActions.Controls.Add(this.btnAddProduct);
            this.pnlActions.Controls.Add(this.lblActionsTitle);
            this.pnlActions.Location = new System.Drawing.Point(720, 8);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(12);
            this.pnlActions.Size = new System.Drawing.Size(340, 260);
            this.pnlActions.TabIndex = 0;
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnRestock.Location = new System.Drawing.Point(165, 100);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(140, 40);
            this.btnRestock.TabIndex = 0;
            this.btnRestock.Text = "Restock Inventory";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnGenerateReport.Location = new System.Drawing.Point(15, 100);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(140, 40);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Location = new System.Drawing.Point(165, 50);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(140, 40);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(15, 50);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(140, 40);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblActionsTitle
            // 
            this.lblActionsTitle.AutoSize = true;
            this.lblActionsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblActionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblActionsTitle.Location = new System.Drawing.Point(12, 12);
            this.lblActionsTitle.Name = "lblActionsTitle";
            this.lblActionsTitle.Size = new System.Drawing.Size(105, 20);
            this.lblActionsTitle.TabIndex = 4;
            this.lblActionsTitle.Text = "Quick Actions";
            // 
            // pnlLowStockList
            // 
            this.pnlLowStockList.BackColor = System.Drawing.Color.White;
            this.pnlLowStockList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLowStockList.Controls.Add(this.lstLowStock);
            this.pnlLowStockList.Controls.Add(this.lblLowStockListTitle);
            this.pnlLowStockList.Location = new System.Drawing.Point(370, 8);
            this.pnlLowStockList.Name = "pnlLowStockList";
            this.pnlLowStockList.Padding = new System.Windows.Forms.Padding(12);
            this.pnlLowStockList.Size = new System.Drawing.Size(340, 260);
            this.pnlLowStockList.TabIndex = 1;
            // 
            // lstLowStock
            // 
            this.lstLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLowStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstLowStock.ItemHeight = 15;
            this.lstLowStock.Location = new System.Drawing.Point(12, 32);
            this.lstLowStock.Name = "lstLowStock";
            this.lstLowStock.Size = new System.Drawing.Size(314, 214);
            this.lstLowStock.TabIndex = 0;
            // 
            // lblLowStockListTitle
            // 
            this.lblLowStockListTitle.AutoSize = true;
            this.lblLowStockListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLowStockListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLowStockListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblLowStockListTitle.Location = new System.Drawing.Point(12, 12);
            this.lblLowStockListTitle.Name = "lblLowStockListTitle";
            this.lblLowStockListTitle.Size = new System.Drawing.Size(126, 20);
            this.lblLowStockListTitle.TabIndex = 1;
            this.lblLowStockListTitle.Text = "Low Stock Alerts";
            // 
            // pnlRecentActivity
            // 
            this.pnlRecentActivity.BackColor = System.Drawing.Color.White;
            this.pnlRecentActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecentActivity.Controls.Add(this.lstRecentActivity);
            this.pnlRecentActivity.Controls.Add(this.lblRecentTitle);
            this.pnlRecentActivity.Location = new System.Drawing.Point(20, 8);
            this.pnlRecentActivity.Name = "pnlRecentActivity";
            this.pnlRecentActivity.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRecentActivity.Size = new System.Drawing.Size(340, 260);
            this.pnlRecentActivity.TabIndex = 2;
            // 
            // lstRecentActivity
            // 
            this.lstRecentActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRecentActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRecentActivity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstRecentActivity.ItemHeight = 15;
            this.lstRecentActivity.Location = new System.Drawing.Point(12, 32);
            this.lstRecentActivity.Name = "lstRecentActivity";
            this.lstRecentActivity.Size = new System.Drawing.Size(314, 214);
            this.lstRecentActivity.TabIndex = 0;
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.AutoSize = true;
            this.lblRecentTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRecentTitle.Location = new System.Drawing.Point(12, 12);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(115, 20);
            this.lblRecentTitle.TabIndex = 1;
            this.lblRecentTitle.Text = "Recent Activity";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlChartHost);
            this.Controls.Add(this.pnlKpis);
            this.Controls.Add(this.pnlHeader);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlKpis.ResumeLayout(false);
            this.pnlTotalProducts.ResumeLayout(false);
            this.pnlTotalProducts.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlTodaysSales.ResumeLayout(false);
            this.pnlTodaysSales.PerformLayout();
            this.pnlPendingOrders.ResumeLayout(false);
            this.pnlPendingOrders.PerformLayout();
            this.pnlMonthlyRevenue.ResumeLayout(false);
            this.pnlMonthlyRevenue.PerformLayout();
            this.pnlChartHost.ResumeLayout(false);
            this.pnlChartHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.pnlLowStockList.ResumeLayout(false);
            this.pnlLowStockList.PerformLayout();
            this.pnlRecentActivity.ResumeLayout(false);
            this.pnlRecentActivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlKpis;
        private System.Windows.Forms.Panel pnlTotalProducts;
        private System.Windows.Forms.Label lblTotalProductsValue;
        private System.Windows.Forms.Label lblTotalProductsCaption;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Label lblLowStockCaption;
        private System.Windows.Forms.Panel pnlTodaysSales;
        private System.Windows.Forms.Label lblTodaysSalesValue;
        private System.Windows.Forms.Label lblTodaysSalesCaption;
        private System.Windows.Forms.Panel pnlPendingOrders;
        private System.Windows.Forms.Label lblPendingOrdersValue;
        private System.Windows.Forms.Label lblPendingOrdersCaption;
        private System.Windows.Forms.Panel pnlMonthlyRevenue;
        private System.Windows.Forms.Label lblMonthlyRevenueValue;
        private System.Windows.Forms.Label lblMonthlyRevenueCaption;
        private System.Windows.Forms.Panel pnlChartHost;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlRecentActivity;
        private System.Windows.Forms.ListBox lstRecentActivity;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.Panel pnlLowStockList;
        private System.Windows.Forms.ListBox lstLowStock;
        private System.Windows.Forms.Label lblLowStockListTitle;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblActionsTitle;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnRestock;
    }
}
