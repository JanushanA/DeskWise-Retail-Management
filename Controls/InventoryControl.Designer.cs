namespace DeskWise.Controls
{
    partial class InventoryControl
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlKpis = new System.Windows.Forms.Panel();
            this.pnlTotalItems = new System.Windows.Forms.Panel();
            this.lblTotalItemsValue = new System.Windows.Forms.Label();
            this.lblTotalItemsCaption = new System.Windows.Forms.Label();
            this.pnlInStock = new System.Windows.Forms.Panel();
            this.lblInStockValue = new System.Windows.Forms.Label();
            this.lblInStockCaption = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.lblLowStockCaption = new System.Windows.Forms.Label();
            this.pnlOutStock = new System.Windows.Forms.Panel();
            this.lblOutStockValue = new System.Windows.Forms.Label();
            this.lblOutStockCaption = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnExportInventory = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlKpis.SuspendLayout();
            this.pnlTotalItems.SuspendLayout();
            this.pnlInStock.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlOutStock.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
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
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Inventory Management";
            // 
            // pnlKpis
            // 
            this.pnlKpis.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlKpis.Controls.Add(this.pnlTotalItems);
            this.pnlKpis.Controls.Add(this.pnlInStock);
            this.pnlKpis.Controls.Add(this.pnlLowStock);
            this.pnlKpis.Controls.Add(this.pnlOutStock);
            this.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpis.Location = new System.Drawing.Point(0, 50);
            this.pnlKpis.Name = "pnlKpis";
            this.pnlKpis.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlKpis.Size = new System.Drawing.Size(1100, 100);
            this.pnlKpis.TabIndex = 1;
            // 
            // pnlTotalItems
            // 
            this.pnlTotalItems.BackColor = System.Drawing.Color.White;
            this.pnlTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalItems.Controls.Add(this.lblTotalItemsValue);
            this.pnlTotalItems.Controls.Add(this.lblTotalItemsCaption);
            this.pnlTotalItems.Location = new System.Drawing.Point(20, 12);
            this.pnlTotalItems.Name = "pnlTotalItems";
            this.pnlTotalItems.Size = new System.Drawing.Size(250, 76);
            this.pnlTotalItems.TabIndex = 0;
            // 
            // lblTotalItemsCaption
            // 
            this.lblTotalItemsCaption.AutoSize = true;
            this.lblTotalItemsCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalItemsCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTotalItemsCaption.Location = new System.Drawing.Point(15, 12);
            this.lblTotalItemsCaption.Name = "lblTotalItemsCaption";
            this.lblTotalItemsCaption.Text = "Total Items";
            // 
            // lblTotalItemsValue
            // 
            this.lblTotalItemsValue.AutoSize = true;
            this.lblTotalItemsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalItemsValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTotalItemsValue.Location = new System.Drawing.Point(13, 30);
            this.lblTotalItemsValue.Name = "lblTotalItemsValue";
            this.lblTotalItemsValue.Text = "0";
            // 
            // pnlInStock
            // 
            this.pnlInStock.BackColor = System.Drawing.Color.White;
            this.pnlInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInStock.Controls.Add(this.lblInStockValue);
            this.pnlInStock.Controls.Add(this.lblInStockCaption);
            this.pnlInStock.Location = new System.Drawing.Point(280, 12);
            this.pnlInStock.Name = "pnlInStock";
            this.pnlInStock.Size = new System.Drawing.Size(250, 76);
            this.pnlInStock.TabIndex = 1;
            // 
            // lblInStockCaption
            // 
            this.lblInStockCaption.AutoSize = true;
            this.lblInStockCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInStockCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblInStockCaption.Location = new System.Drawing.Point(15, 12);
            this.lblInStockCaption.Name = "lblInStockCaption";
            this.lblInStockCaption.Text = "In Stock";
            // 
            // lblInStockValue
            // 
            this.lblInStockValue.AutoSize = true;
            this.lblInStockValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblInStockValue.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52);
            this.lblInStockValue.Location = new System.Drawing.Point(13, 30);
            this.lblInStockValue.Name = "lblInStockValue";
            this.lblInStockValue.Text = "0";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLowStock.Controls.Add(this.lblLowStockValue);
            this.pnlLowStock.Controls.Add(this.lblLowStockCaption);
            this.pnlLowStock.Location = new System.Drawing.Point(540, 12);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(250, 76);
            this.pnlLowStock.TabIndex = 2;
            // 
            // lblLowStockCaption
            // 
            this.lblLowStockCaption.AutoSize = true;
            this.lblLowStockCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLowStockCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblLowStockCaption.Location = new System.Drawing.Point(15, 12);
            this.lblLowStockCaption.Name = "lblLowStockCaption";
            this.lblLowStockCaption.Text = "Low Stock";
            // 
            // lblLowStockValue
            // 
            this.lblLowStockValue.AutoSize = true;
            this.lblLowStockValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLowStockValue.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14);
            this.lblLowStockValue.Location = new System.Drawing.Point(13, 30);
            this.lblLowStockValue.Name = "lblLowStockValue";
            this.lblLowStockValue.Text = "0";
            // 
            // pnlOutStock
            // 
            this.pnlOutStock.BackColor = System.Drawing.Color.White;
            this.pnlOutStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutStock.Controls.Add(this.lblOutStockValue);
            this.pnlOutStock.Controls.Add(this.lblOutStockCaption);
            this.pnlOutStock.Location = new System.Drawing.Point(800, 12);
            this.pnlOutStock.Name = "pnlOutStock";
            this.pnlOutStock.Size = new System.Drawing.Size(250, 76);
            this.pnlOutStock.TabIndex = 3;
            // 
            // lblOutStockCaption
            // 
            this.lblOutStockCaption.AutoSize = true;
            this.lblOutStockCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOutStockCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblOutStockCaption.Location = new System.Drawing.Point(15, 12);
            this.lblOutStockCaption.Name = "lblOutStockCaption";
            this.lblOutStockCaption.Text = "Out of Stock";
            // 
            // lblOutStockValue
            // 
            this.lblOutStockValue.AutoSize = true;
            this.lblOutStockValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblOutStockValue.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27);
            this.lblOutStockValue.Location = new System.Drawing.Point(13, 30);
            this.lblOutStockValue.Name = "lblOutStockValue";
            this.lblOutStockValue.Text = "0";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.cmbCategory);
            this.pnlToolbar.Controls.Add(this.cmbStatus);
            this.pnlToolbar.Controls.Add(this.btnAddProduct);
            this.pnlToolbar.Controls.Add(this.btnEditProduct);
            this.pnlToolbar.Controls.Add(this.btnDeleteProduct);
            this.pnlToolbar.Controls.Add(this.btnExportInventory);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 150);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 56);
            this.pnlToolbar.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(20, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(250, 16);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 26);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(410, 16);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 26);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(620, 14);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 30);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditProduct.Location = new System.Drawing.Point(735, 14);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(80, 30);
            this.btnEditProduct.TabIndex = 4;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27);
            this.btnDeleteProduct.Location = new System.Drawing.Point(825, 14);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnExportInventory
            // 
            this.btnExportInventory.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnExportInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportInventory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportInventory.Location = new System.Drawing.Point(915, 14);
            this.btnExportInventory.Name = "btnExportInventory";
            this.btnExportInventory.Size = new System.Drawing.Size(140, 30);
            this.btnExportInventory.TabIndex = 6;
            this.btnExportInventory.Text = "Export to CSV";
            this.btnExportInventory.UseVisualStyleBackColor = false;
            this.btnExportInventory.Click += new System.EventHandler(this.btnExportInventory_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(0, 206);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(1100, 494);
            this.dgvInventory.TabIndex = 3;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlKpis);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlKpis.ResumeLayout(false);
            this.pnlTotalItems.ResumeLayout(false);
            this.pnlTotalItems.PerformLayout();
            this.pnlInStock.ResumeLayout(false);
            this.pnlInStock.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlOutStock.ResumeLayout(false);
            this.pnlOutStock.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlKpis;
        private System.Windows.Forms.Panel pnlTotalItems;
        private System.Windows.Forms.Label lblTotalItemsValue;
        private System.Windows.Forms.Label lblTotalItemsCaption;
        private System.Windows.Forms.Panel pnlInStock;
        private System.Windows.Forms.Label lblInStockValue;
        private System.Windows.Forms.Label lblInStockCaption;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Label lblLowStockCaption;
        private System.Windows.Forms.Panel pnlOutStock;
        private System.Windows.Forms.Label lblOutStockValue;
        private System.Windows.Forms.Label lblOutStockCaption;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnExportInventory;
        private System.Windows.Forms.DataGridView dgvInventory;
    }
}
