using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinStock_Inventory_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void ProductBtn_Click(object sender, EventArgs e)
        {
            Product obj = new Product();
            obj.Show();
            this.Hide();
        }
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            Order obj = new Order();
            obj.Show();
            this.Hide();
        }
        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }
    }
}
