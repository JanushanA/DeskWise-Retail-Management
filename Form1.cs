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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowScreen(new Home());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowScreen(new Inventory());
        }

        private void ShowScreen(UserControl newScreen)
        {
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }

            pnlContent.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newScreen);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            ShowScreen(new CheckOut());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowScreen(new Home());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowScreen(new Report());
        }
    }
}
