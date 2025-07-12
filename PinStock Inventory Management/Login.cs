using System.Runtime.CompilerServices;

namespace PinStock_Inventory_Management
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " && textBox2.Text == " ")
            {
                MessageBox.Show("Invalid Username or Password.");
            } else if (textBox1.Text == "Admin" && textBox2.Text == "admin123")
                {
                MessageBox.Show("LogIn Successfully!");
                Home obj = new Home();
                this.Hide();
                obj.Show();
            }else 
            { 
                MessageBox.Show("Invalid Username or Password."); 
            }
                     
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else { 
                textBox2.UseSystemPasswordChar = true;
            
            }
        }
        
        
    }
}
