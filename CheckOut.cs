using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class CheckOut : UserControl
    {
        public CheckOut()
        {
            InitializeComponent();
            SetUpOrderSystem(); 
        }

        private BindingList<Product> _availableProducts;
        private BindingList<OrderItem> _currentOrderItems = new BindingList<OrderItem>();
        private string _csvPath = "./shop-product-catalog.csv";

        private void SetUpOrderSystem()
        {
            dgvAvailable.ReadOnly = true;
            dgvAvailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailable.MultiSelect = false;

            dgvCurrentOrder.ReadOnly = true;
            dgvCurrentOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrentOrder.MultiSelect = false;

            dgvAvailable.AutoGenerateColumns = false;
            dgvAvailable.Columns.Clear();
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Name = "colID", Width = 50 });
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product Name", Name = "colName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dgvAvailable.AutoGenerateColumns = false;
            dgvAvailable.Columns.Clear();
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Name = "colID", Width = 50 });
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product Name", Name = "colName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dgvCurrentOrder.DataSource = _currentOrderItems;
            dgvCurrentOrder.AllowDrop = true;
        }

        private void dgvAvailable_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvAvailable.SelectedRows.Count > 0)
            {
                var product = (Product)dgvAvailable.SelectedRows[0].DataBoundItem;
                dgvAvailable.DoDragDrop(product, DragDropEffects.Copy);
            }
        }

        private void dgvCurrentOrder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Product)))
                e.Effect = DragDropEffects.Copy;
        }

        private void dgvCurrentOrder_DragDrop(object sender, DragEventArgs e)
        {
            Product droppedProduct = (Product)e.Data.GetData(typeof(Product));
            AddProductToOrder(droppedProduct);
        }

        private void AddProductToOrder(Product product)
        {
            var existingItem = _currentOrderItems.FirstOrDefault(i => i.ProductID == product.ProductID);
            
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
               
                _currentOrderItems.Add(new OrderItem
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    UnitPrice = product.ProductPrice,
                    Quantity = 1
                });
            }
           
            _currentOrderItems.ResetBindings();

            UpdateTotal();
        }


        private void UpdateTotal()
        {
            
            decimal total = _currentOrderItems.Sum(i => i.Subtotal);
            lblTotal.Text = $"Total: ${total:F2}";
        }



    }

}
