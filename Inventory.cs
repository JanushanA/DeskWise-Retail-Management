using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp10
{
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
        }
        string id;
        string name;
        string price;
        string brand;
        string quantity;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            name = txtName.Text;
            price = txtPrice.Text;
            brand = txtBrand.Text;
            quantity = txtQuantity.Text;

            dgvInventory.Rows.Add(id, name, quantity ,brand, price);
           

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            name = txtName.Text;
            price = txtPrice.Text;
            brand = txtBrand.Text;
            quantity = txtQuantity.Text;

            dgvInventory.CurrentRow.SetValues(id, name, quantity, brand, price);
        }

       

       
    }
}
