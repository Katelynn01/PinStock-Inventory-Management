namespace PinStock_Inventory_Management
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            logo = new PictureBox();
            orderlbl = new Label();
            orderIdlbl = new Label();
            custId = new Label();
            custname = new Label();
            datelbl = new Label();
            backBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            printbtn = new Button();
            viewbtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            custlistlbl = new Label();
            dgOrderList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgOrderList).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(69, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 8;
            logo.TabStop = false;
            // 
            // orderlbl
            // 
            orderlbl.AutoSize = true;
            orderlbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderlbl.Location = new Point(87, 31);
            orderlbl.Name = "orderlbl";
            orderlbl.Size = new Size(148, 25);
            orderlbl.TabIndex = 10;
            orderlbl.Text = "Order Dashboard";
            // 
            // orderIdlbl
            // 
            orderIdlbl.AutoSize = true;
            orderIdlbl.Location = new Point(15, 126);
            orderIdlbl.Name = "orderIdlbl";
            orderIdlbl.Size = new Size(66, 20);
            orderIdlbl.TabIndex = 11;
            orderIdlbl.Text = "Order ID";
            // 
            // custId
            // 
            custId.AutoSize = true;
            custId.Location = new Point(12, 182);
            custId.Name = "custId";
            custId.Size = new Size(91, 20);
            custId.TabIndex = 12;
            custId.Text = "Customer ID";
            // 
            // custname
            // 
            custname.AutoSize = true;
            custname.Location = new Point(12, 239);
            custname.Name = "custname";
            custname.Size = new Size(116, 20);
            custname.TabIndex = 13;
            custname.Text = "Customer Name";
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Location = new Point(15, 298);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(83, 20);
            datelbl.TabIndex = 14;
            datelbl.Text = "Order Date";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(697, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 16;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 321);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(277, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // printbtn
            // 
            printbtn.Location = new Point(40, 381);
            printbtn.Name = "printbtn";
            printbtn.Size = new Size(111, 27);
            printbtn.TabIndex = 19;
            printbtn.Text = "Print Order";
            printbtn.UseVisualStyleBackColor = true;
            // 
            // viewbtn
            // 
            viewbtn.Location = new Point(181, 381);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(111, 27);
            viewbtn.TabIndex = 20;
            viewbtn.Text = "View Order";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += viewbtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 262);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Customer Name";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 205);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Customer ID";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 148);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter Order ID";
            textBox3.Size = new Size(227, 27);
            textBox3.TabIndex = 23;
            // 
            // custlistlbl
            // 
            custlistlbl.AutoSize = true;
            custlistlbl.Location = new Point(542, 77);
            custlistlbl.Name = "custlistlbl";
            custlistlbl.Size = new Size(73, 20);
            custlistlbl.TabIndex = 17;
            custlistlbl.Text = "Order List";
            // 
            // dgOrderList
            // 
            dgOrderList.BackgroundColor = Color.LavenderBlush;
            dgOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderList.GridColor = Color.Lavender;
            dgOrderList.Location = new Point(400, 113);
            dgOrderList.Name = "dgOrderList";
            dgOrderList.RowHeadersWidth = 51;
            dgOrderList.Size = new Size(360, 269);
            dgOrderList.TabIndex = 26;
            dgOrderList.DoubleClick += dataGridView1_DoubleClick;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(dgOrderList);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(viewbtn);
            Controls.Add(printbtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(custlistlbl);
            Controls.Add(backBtn);
            Controls.Add(datelbl);
            Controls.Add(custname);
            Controls.Add(custId);
            Controls.Add(orderIdlbl);
            Controls.Add(orderlbl);
            Controls.Add(logo);
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Dashboard";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label orderlbl;
        private Label orderIdlbl;
        private Label custId;
        private Label custname;
        private Label datelbl;
        private Button backBtn;
        private DateTimePicker dateTimePicker1;
        private Button printbtn;
        private Button viewbtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label custlistlbl;
        private DataGridView dgOrderList;
    }
}