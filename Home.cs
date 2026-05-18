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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ShowScreen(UserControl newScreen)
        {
            Form1 mainForm = (Form1)this.FindForm();
            foreach (Control ctrl in mainForm.pnlContent.Controls)
            {
                ctrl.Dispose();
            }

            mainForm.pnlContent.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            mainForm. pnlContent.Controls.Add(newScreen);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowScreen(new Inventory());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowScreen(new CheckOut());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowScreen(new Report());
        }
    }
}
