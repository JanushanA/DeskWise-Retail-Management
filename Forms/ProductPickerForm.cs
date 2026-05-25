using System;

using System.Collections.Generic;

using System.Drawing;

using System.Linq;

using System.Windows.Forms;

using DeskWise.Models;

using DeskWise.Services;



namespace DeskWise.Forms

{

    // Compact dialog to pick a product by search text and list selection.

    public partial class ProductPickerForm : Form

    {

        private List<Product> _allProducts;

        public Product SelectedProduct { get; private set; }



        private TextBox txtSearch;

        private ListBox lstProducts;

        private Button btnOk;

        private Button btnCancel;

        private Label lblHint;



        // Load the full product catalog and show the initial unfiltered list.

        public ProductPickerForm()

        {

            InitializePickerLayout();

            _allProducts = ProductService.All.OrderBy(product => product.Name).ToList();

            RefreshProductList(string.Empty);

        }



        // Build the picker UI in code (search box, list, OK/Cancel buttons).

        private void InitializePickerLayout()

        {

            this.Text = "Add Product";

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.StartPosition = FormStartPosition.CenterParent;

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            this.ClientSize = new Size(480, 380);

            this.Font = new Font("Segoe UI", 9.75f);



            lblHint = new Label

            {

                Text = "Search by name or SKU, then select a product:",

                Location = new Point(16, 12),

                Size = new Size(440, 22),

                ForeColor = Color.FromArgb(71, 85, 105)

            };



            txtSearch = new TextBox

            {

                Location = new Point(16, 38),

                Size = new Size(448, 25)

            };

            txtSearch.TextChanged += TxtSearch_TextChanged;
            TextBoxHelper.SetSearchPlaceholder(txtSearch);



            lstProducts = new ListBox

            {

                Location = new Point(16, 72),

                Size = new Size(448, 240),

                IntegralHeight = false

            };

            lstProducts.DoubleClick += (sender, args) => ConfirmSelection();



            btnOk = new Button

            {

                Text = "Add",

                DialogResult = DialogResult.None,

                Location = new Point(288, 322),

                Size = new Size(84, 32),

                BackColor = Color.FromArgb(37, 99, 235),

                ForeColor = Color.White,

                FlatStyle = FlatStyle.Flat

            };

            btnOk.FlatAppearance.BorderSize = 0;

            btnOk.Click += (sender, args) => ConfirmSelection();



            btnCancel = new Button

            {

                Text = "Cancel",

                DialogResult = DialogResult.Cancel,

                Location = new Point(380, 322),

                Size = new Size(84, 32)

            };



            this.Controls.Add(lblHint);

            this.Controls.Add(txtSearch);

            this.Controls.Add(lstProducts);

            this.Controls.Add(btnOk);

            this.Controls.Add(btnCancel);

            this.CancelButton = btnCancel;

        }



        // Re-filter the list as the user types in the search box.

        private void TxtSearch_TextChanged(object sender, EventArgs e)

        {

            RefreshProductList(txtSearch.Text);

        }



        // Filter products by name, SKU, or id and repopulate the list (max 200 rows).

        private void RefreshProductList(string query)

        {

            lstProducts.Items.Clear();

            IEnumerable<Product> filtered = _allProducts;

            if (!string.IsNullOrWhiteSpace(query))

            {

                string needle = query.Trim().ToLowerInvariant();

                filtered = _allProducts.Where(product =>

                    (product.Name != null && product.Name.ToLowerInvariant().Contains(needle)) ||

                    (product.SKU != null && product.SKU.ToLowerInvariant().Contains(needle)) ||

                    product.Id.ToString().Contains(needle));

            }

            foreach (Product product in filtered.Take(200))

            {

                Supplier supplier = SupplierService.GetById(product.SupplierId);

                string supplierName = supplier != null ? supplier.Name : "Unknown";

                lstProducts.Items.Add(new ProductListItem(product, supplierName));

            }

            if (lstProducts.Items.Count > 0)

            {

                lstProducts.SelectedIndex = 0;

            }

        }



        // Accept the highlighted product and close with DialogResult.OK.

        private void ConfirmSelection()

        {

            ProductListItem selected = lstProducts.SelectedItem as ProductListItem;

            if (selected == null)

            {

                MessageBox.Show("Please select a product.", "Select Product",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }

            SelectedProduct = selected.Product;

            this.DialogResult = DialogResult.OK;

            this.Close();

        }



        // Wrapper for list box display text (product id, name, stock, supplier).

        private sealed class ProductListItem

        {

            public Product Product { get; private set; }

            private readonly string _display;



            public ProductListItem(Product product, string supplierName)

            {

                Product = product;

                _display = string.Format("{0} — {1} (stock {2}, {3})",

                    product.Id, product.Name, product.Quantity, supplierName);

            }



            // Text shown in the list box for this product row.

            public override string ToString()

            {

                return _display;

            }

        }

    }

}


