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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " && textBox2.Text == " ")
            {
                MessageBox.Show("Invalid Username or Password.");
            } else if (textBox1.Text == "Admin" && textBox2.Text == "admin123")
                {
                Home obj = new Home();
                obj.Show();
                this.Hide();
                MessageBox.Show("LogIn Successfully!");
            }else 
            { 
                MessageBox.Show("Invalid Username or Password."); 
            }
                     
        }
        private void Login_Load(object sender, EventArgs e)
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
