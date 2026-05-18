using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace WindowsFormsApp10
{
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
        }
        
        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        string filePath = "H:/Programming/WindowsFormsApp10/shop-product-catalog.csv";

 
       private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (!ValidateInputs()) return;

            
            int newId = _inventoryList.Count + 1000;
            string name = txtName.Text;
            string brand = txtBrand.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            Product newProduct = new Product(newId, name, brand, price, quantity);
            _inventoryList.Add(newProduct);

            
            _bindingSource.ResetBindings(false);

            
            ClearFields();
        }

        private bool ValidateInputs()
        {
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product Name contains invalid characters.");
                return false;
            }

            
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

           
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return false;
            }

            return true;
        }



        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            if (!int.TryParse(txtID.Text, out int idToUpdate))
            {
                MessageBox.Show("Please select a product from the grid to update.");
                return;
            }

            
            var productToUpdate = _inventoryList.FirstOrDefault(p => p.ProductID == idToUpdate);

            if (productToUpdate != null)
            {
                
                if (ValidateInputs())
                {
                    
                    productToUpdate.ProductName = txtName.Text;
                    productToUpdate.ProductBrand = txtBrand.Text;
                    productToUpdate.ProductPrice = decimal.Parse(txtPrice.Text);
                    productToUpdate.ProductQuantity = int.Parse(txtQuantity.Text);

                   
                    _bindingSource.ResetBindings(false);
                    dgvInventory.Refresh();

                 
                    ClearFields();
                    MessageBox.Show("Product updated successfully in the list.");
                }
            }
            else
            {
                MessageBox.Show("Product ID not found in inventory.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string searchTerm = txtDelete.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a Product ID or Name to delete.");
                return;
            }

          
            Product productToDelete = _inventoryList.FirstOrDefault(p =>
                p.ProductID.ToString() == searchTerm ||
                p.ProductName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

            if (productToDelete != null)
            {
                
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {productToDelete.ProductName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    
                    _inventoryList.Remove(productToDelete);



                    txtDelete.Clear();
                    MessageBox.Show("Product deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("No product found matching that ID or Name.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = filePath;

                
                List<Product> listToSave = _inventoryList.ToList();

               
                InventoryService.SaveToCSV(path, listToSave);

                MessageBox.Show("Changes saved to CSV successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            string path = filePath;


            var tempData = InventoryService.LoadFromCSV(path);


            

            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
                
            }


            dgvInventory.DataSource = _inventoryList;
        }

        private void ProductQuantity()
        {
            var tempData = InventoryService.LoadFromCSV(filePath);



        }

       
    }
}
