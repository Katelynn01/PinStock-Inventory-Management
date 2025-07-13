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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        //private void DisplayCustomer()
        //{
        //    try
        //    {
        //        Con.Open();
        //        string Query = "select * from Customer";
        //        SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
        //        SqlCommandBuild sql = new SqlCommandBuild(sda);
        //        var ds = new DataSet();
        //        sda.Fill(ds);
        //        dataGridView1.DataSource = ds.Tables[0];
        //        Con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        Con.Close();
        //    }
        //}

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Your code here
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
