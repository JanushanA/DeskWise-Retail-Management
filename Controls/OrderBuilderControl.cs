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

        // BindingList lets the grid auto-refresh when items are added/removed.

        private readonly BindingList<OrderItem> _cart = new BindingList<OrderItem>();

        private decimal _discount;

        private Customer _selectedCustomer;

        // Initializes catalogue and cart grids

        public OrderBuilderControl()
        {
            InitializeComponent();
        }

        // Restores held order from AppState if present, then loads catalogue and totals

        private void OrderBuilderControl_Load(object sender, EventArgs e)
        {
            SetupGrids();

            // If we're resuming a previously held order, restore it.
            if (AppState.PendingOrder != null && AppState.PendingOrder.Items != null)
            {
                foreach (OrderItem pendingLine in AppState.PendingOrder.Items) _cart.Add(pendingLine);
                _discount = AppState.PendingOrder.Discount;
                if (AppState.PendingOrder.CustomerId > 0)
                {
                    _selectedCustomer = CustomerService.GetById(AppState.PendingOrder.CustomerId);
                }
            }
            RefreshCatalog();
            RefreshCart();
            UpdateCustomerLabel();
            RecalculateTotals();
        }

        // Configures catalogue grid (left) and editable cart grid (right)

        private void SetupGrids()
        {

            // Catalogue grid (left).
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

            // Cart grid (right). Quantity is editable.
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
            dgvCart.DataSource = _cart;
            dgvCart.CellEndEdit += DgvCart_CellEndEdit;
            dgvCart.CellContentClick += DgvCart_CellContentClick;
            dgvCart.DataError += (sender, args) => { args.Cancel = true; }; // swallow type-conversion errors
        }

        // Filters product catalogue by search box and binds to left grid

        private void RefreshCatalog()
        {
            string searchText = txtSearch.Text;
            List<Product> filtered = ProductService.Search(searchText, "All Categories", "All Statuses");
            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = filtered;
        }

        // Rebinds cart grid to in-memory BindingList

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart;
        }

        // Shows selected customer name and loyalty points, or walk-in label

        private void UpdateCustomerLabel()
        {
            lblCustomer.Text = _selectedCustomer != null
                ? "Customer: " + _selectedCustomer.Name + " (" + _selectedCustomer.LoyaltyPoints + " pts)"
                : "Customer: Walk-in";
        }

        // Updates subtotal, discount, tax, and total labels via Order.RecalculateTotals

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

        // Validates edited cart quantity against stock and refreshes totals

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

        // Removes cart line when user clicks the X button column

        private void DgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _cart.Count) return;
            if (dgvCart.Columns[e.ColumnIndex].Name != "colRemove") return;
            _cart.RemoveAt(e.RowIndex);
            RecalculateTotals();
        }

        // Adds selected catalogue product to cart or increments quantity if already present

        private void AddSelectedToCart()
        {
            if (dgvCatalog.CurrentRow == null) return;
            Product selectedProduct = dgvCatalog.CurrentRow.DataBoundItem as Product;
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

        // Refreshes catalogue when search text changes

        private void txtSearch_TextChanged(object sender, EventArgs e) { RefreshCatalog(); }

        // Adds highlighted catalogue row to cart

        private void btnAddItem_Click(object sender, EventArgs e) { AddSelectedToCart(); }

        // Prompts for dollar discount and recalculates totals

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

        // Lets user pick a customer by numeric ID from a simple input dialog

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (CustomerService.All.Count == 0)
            {
                MessageBox.Show("No customers exist yet.", "No Customers",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string listing = "Type the customer ID:\r\n\r\n" +
                string.Join("\r\n", CustomerService.All.Select(customer => customer.Id + " - " + customer.Name));
            string input = Microsoft.VisualBasic.Interaction.InputBox(listing, "Select Customer", "");
            if (string.IsNullOrWhiteSpace(input)) return;
            if (!int.TryParse(input, out int customerId))
            {
                MessageBox.Show("Please enter a numeric customer ID.", "Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Customer selectedCustomer = CustomerService.GetById(customerId);
            if (selectedCustomer == null)
            {
                MessageBox.Show("Customer not found.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _selectedCustomer = selectedCustomer;
            UpdateCustomerLabel();
        }

        // Saves current cart to AppState.PendingOrder and clears the builder UI

        private void btnHoldOrder_Click(object sender, EventArgs e)
        {
            AppState.PendingOrder = BuildOrder();
            MessageBox.Show("Order placed on hold. Click Build Orders again to resume.",
                "Order Held", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _cart.Clear();
            _selectedCustomer = null;
            _discount = 0;
            UpdateCustomerLabel();
            RecalculateTotals();
        }

        // Clears cart, customer, discount, and pending order after confirmation

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;
            DialogResult confirmClear = MessageBox.Show("Clear the cart?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmClear != DialogResult.Yes) return;
            _cart.Clear();
            _discount = 0;
            _selectedCustomer = null;
            AppState.PendingOrder = null;
            UpdateCustomerLabel();
            RecalculateTotals();
        }

        // Stores order in AppState and navigates to Checkout screen

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

        // Builds in-memory Order from cart, customer, and discount for hold or checkout

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
