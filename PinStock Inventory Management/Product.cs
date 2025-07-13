using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinStock_Inventory_Management
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            Product_Load();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Product_Load(string filter = "")
        {
            //using(var con = Database.Getconnection())
            //{
            //    try
            //    {
            //        con.Open();
            //        string query = "SELECT * FROM Products";

            //        if (!string.IsNullOrEmpty(filter))
            //        {
            //            query += " WHERE ProductName LIKE @filter OR Brand LIKE @filter";
            //        }
            //        using (var cmd = new SqlCommand(query, con))
            //        {
            //            if (!string.IsNullOrEmpty(filter))
            //            {
            //                cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
            //            }
            //            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //            DataTable dt = new DataTable();
            //            sda.Fill(dt);
            //            dataGridView1.DataSource = dt;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show ("Are you sure you want to delete this product?","Confirm Delete",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                //using (var con = Database.Getconnection())
                //{
                   
                //        con.Open();
                //        string query = "DELETE FROM Products WHERE ProductName = @name";
                //        using (var cmd = new SqlCommand(query, con))
                //        {
                //            cmd.Parameters.AddWithValue("@name", textBox1.Text);
                //            cmd.ExecuteNonQuery();
                //        }
                //        MessageBox.Show("Product deleted successfully!");
                //        Product_Load();
             
                    
                //}
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            //using( var con = new SqlConnection("your_connection_string_here"))
            //{
            //    try
            //    {
            //        con.Open();
            //        string query = "INSERT INTO Products (ProductName,Brand, ProductPrice, ProductQuantity) VALUES (@name, @price, @quantity)";
            //        using (var cmd = new SqlCommand(query, con))
            //        {
            //            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            //            cmd.Parameters.AddWithValue("@brand", txtbrand.Text);
            //            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPName.Text));
            //            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(textBox3.Text));
            //            cmd.ExecuteNonQuery();
            //        }
            //        MessageBox.Show("Product added successfully!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtsearch.Text.Trim();
            Product_Load();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();

        }
    }
}
