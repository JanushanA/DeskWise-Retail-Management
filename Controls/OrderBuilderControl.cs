using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DeskWise;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Controls
{

    // Order Builder. The user picks products from the catalogue on the left, adds
    // them to the cart on the right, optionally applies a customer / discount, and
    // hands the in-progress Order to Checkout via AppState.PendingOrder.

    public partial class OrderBuilderControl : UserControl
    {

        private readonly BindingList<OrderItem> _cart = new BindingList<OrderItem>();

        private decimal _discount;

        private Customer _selectedCustomer;

        private int _dragRowIndex = -1;

        private bool _loadingCustomers;

        public OrderBuilderControl()
        {
            InitializeComponent();
        }

        private void OrderBuilderControl_Load(object sender, EventArgs e)
        {
            TextBoxHelper.SetSearchPlaceholder(txtSearch);
            SetupGrids();
            PopulateCustomers();

            if (AppState.PendingOrder != null && AppState.PendingOrder.Items != null)
            {
                foreach (OrderItem pendingLine in AppState.PendingOrder.Items) _cart.Add(pendingLine);
                _discount = AppState.PendingOrder.Discount;
                if (AppState.PendingOrder.CustomerId > 0)
                {
                    _selectedCustomer = CustomerService.GetById(AppState.PendingOrder.CustomerId);
                    SelectCustomerInCombo(_selectedCustomer);
                }
            }
            RefreshCatalog();
            RefreshCart();
            RecalculateTotals();
        }

        private void SetupGrids()
        {
            dgvCatalog.AutoGenerateColumns = false;
            dgvCatalog.Columns.Clear();
            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id",        HeaderText = "ID",    Width = 50 });
            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name",      HeaderText = "Product", Width = 200 });
            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category",  HeaderText = "Category", Width = 100 });
            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SalePrice", HeaderText = "Price", Width = 80, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity",  HeaderText = "In Stock", Width = 70 });
            dgvCatalog.ReadOnly = true;
            dgvCatalog.RowHeadersVisible = false;
            dgvCatalog.AllowUserToAddRows = false;
            dgvCatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCatalog.MultiSelect = false;
            dgvCatalog.BackgroundColor = Color.White;
            dgvCatalog.CellDoubleClick += (sender, args) => { if (args.RowIndex >= 0) AddSelectedToCart(); };
            dgvCatalog.MouseDown += DgvCatalog_MouseDown;
            dgvCatalog.MouseMove += DgvCatalog_MouseMove;

            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product",  Width = 180, ReadOnly = true });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity",    HeaderText = "Qty",      Width = 60 });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice",   HeaderText = "Price",    Width = 80, ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal",    HeaderText = "Subtotal", Width = 90, ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvCart.Columns.Add(new DataGridViewButtonColumn   { HeaderText = "",        Text = "X",   UseColumnTextForButtonValue = true, Width = 40, Name = "colRemove" });
            dgvCart.RowHeadersVisible = false;
            dgvCart.AllowUserToAddRows = false;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.AllowDrop = true;
            dgvCart.DataSource = _cart;
            dgvCart.CellEndEdit += DgvCart_CellEndEdit;
            dgvCart.CellContentClick += DgvCart_CellContentClick;
            dgvCart.DataError += (sender, args) => { args.Cancel = true; };
            dgvCart.DragEnter += DgvCart_DragEnter;
            dgvCart.DragDrop += DgvCart_DragDrop;
        }

        private void DgvCatalog_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvCatalog.HitTest(e.X, e.Y);
            _dragRowIndex = hit.RowIndex;
        }

        private void DgvCatalog_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || _dragRowIndex < 0) return;
            Product product = dgvCatalog.Rows[_dragRowIndex].DataBoundItem as Product;
            if (product == null) return;
            dgvCatalog.DoDragDrop(product, DragDropEffects.Copy);
            _dragRowIndex = -1;
        }

        private void DgvCart_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Product)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void DgvCart_DragDrop(object sender, DragEventArgs e)
        {
            Product product = e.Data.GetData(typeof(Product)) as Product;
            if (product != null) AddProductToCart(product);
        }

        private void PopulateCustomers()
        {
            _loadingCustomers = true;
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.Items.Clear();
            cmbCustomer.Items.Add(new Customer { Id = 0, Name = "Walk-in Customer" });
            foreach (Customer customer in CustomerService.All.OrderBy(c => c.Name))
            {
                cmbCustomer.Items.Add(customer);
            }
            cmbCustomer.SelectedIndex = 0;
            _selectedCustomer = null;
            _loadingCustomers = false;
        }

        private void SelectCustomerInCombo(Customer customer)
        {
            if (customer == null) return;
            _loadingCustomers = true;
            foreach (Customer item in cmbCustomer.Items)
            {
                if (item.Id == customer.Id)
                {
                    cmbCustomer.SelectedItem = item;
                    break;
                }
            }
            _loadingCustomers = false;
            _selectedCustomer = customer;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loadingCustomers) return;
            Customer selected = cmbCustomer.SelectedItem as Customer;
            _selectedCustomer = selected != null && selected.Id > 0 ? selected : null;
        }

        private void RefreshCatalog()
        {
            string searchText = txtSearch.Text;
            List<Product> filtered = ProductService.Search(searchText, "All Categories", "All Statuses");
            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = filtered;
        }

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart;
        }

        private void RecalculateTotals()
        {
            Order temp = new Order
            {
                Discount = _discount,
                Items = _cart.ToList()
            };
            temp.RecalculateTotals(SettingsService.Current.TaxRate);
            lblSubtotal.Text = temp.Subtotal.ToString("C2");
            lblDiscount.Text = temp.Discount.ToString("C2");
            lblTax.Text      = temp.Tax.ToString("C2");
            lblTotal.Text    = temp.Total.ToString("C2");
        }

        private void DgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _cart.Count) return;
            if (dgvCart.Columns[e.ColumnIndex].DataPropertyName != "Quantity") return;
            OrderItem item = _cart[e.RowIndex];
            if (item.Quantity < 1) item.Quantity = 1;
            Product product = ProductService.GetById(item.ProductId);
            if (product != null && item.Quantity > product.Quantity)
            {
                MessageBox.Show("Only " + product.Quantity + " in stock - quantity capped.",
                    "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                item.Quantity = product.Quantity;
            }
            RefreshCart();
            RecalculateTotals();
        }

        private void DgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _cart.Count) return;
            if (dgvCart.Columns[e.ColumnIndex].Name != "colRemove") return;
            _cart.RemoveAt(e.RowIndex);
            RecalculateTotals();
        }

        private void AddProductToCart(Product selectedProduct)
        {
            if (selectedProduct == null) return;
            if (selectedProduct.Quantity <= 0)
            {
                MessageBox.Show(selectedProduct.Name + " is out of stock.", "Out of Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OrderItem existingLine = _cart.FirstOrDefault(line => line.ProductId == selectedProduct.Id);
            if (existingLine != null)
            {
                if (existingLine.Quantity + 1 > selectedProduct.Quantity)
                {
                    MessageBox.Show("No more " + selectedProduct.Name + " left in stock.", "Stock Limit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                existingLine.Quantity++;
            }
            else
            {
                _cart.Add(new OrderItem
                {
                    ProductId = selectedProduct.Id,
                    ProductName = selectedProduct.Name,
                    UnitPrice = selectedProduct.SalePrice,
                    Quantity = 1
                });
            }
            RefreshCart();
            RecalculateTotals();
        }

        private void AddSelectedToCart()
        {
            if (dgvCatalog.CurrentRow == null) return;
            AddProductToCart(dgvCatalog.CurrentRow.DataBoundItem as Product);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) { RefreshCatalog(); }

        private void btnAddItem_Click(object sender, EventArgs e) { AddSelectedToCart(); }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter discount amount (in dollars):", "Apply Discount", _discount.ToString("0.00"));
            if (string.IsNullOrWhiteSpace(input)) return;
            if (!ValidationService.IsNonNegativeDecimal(input, out decimal discountAmount))
            {
                MessageBox.Show("Please enter a valid non-negative amount.", "Invalid Discount",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _discount = discountAmount;
            RecalculateTotals();
        }

        private void btnHoldOrder_Click(object sender, EventArgs e)
        {
            AppState.PendingOrder = BuildOrder();
            MessageBox.Show("Order placed on hold. Click Build Orders again to resume.",
                "Order Held", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _cart.Clear();
            _selectedCustomer = null;
            _discount = 0;
            cmbCustomer.SelectedIndex = 0;
            RecalculateTotals();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;
            DialogResult confirmClear = MessageBox.Show("Clear the cart?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmClear != DialogResult.Yes) return;
            _cart.Clear();
            _discount = 0;
            _selectedCustomer = null;
            cmbCustomer.SelectedIndex = 0;
            AppState.PendingOrder = null;
            RecalculateTotals();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Add at least one item before checking out.", "Empty Cart",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AppState.PendingOrder = BuildOrder();
            MainShellForm main = this.FindForm() as MainShellForm;
            if (main != null) main.LoadScreen(new CheckoutControl());
        }

        private Order BuildOrder()
        {
            Order order = new Order
            {
                Discount = _discount,
                CustomerId = _selectedCustomer != null ? _selectedCustomer.Id : 0,
                CustomerName = _selectedCustomer != null ? _selectedCustomer.Name : "Walk-in Customer",
                Items = _cart.ToList()
            };
            order.RecalculateTotals(SettingsService.Current.TaxRate);
            return order;
        }
    }
}
