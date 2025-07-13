namespace PinStock_Inventory_Management
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            pictureBox1 = new PictureBox();
            productlbl = new Label();
            productIdlbl = new Label();
            PNamelbl = new Label();
            categorylbl = new Label();
            brandlbl = new Label();
            Quantitylbl = new Label();
            Pricelbl = new Label();
            statuslbl = new Label();
            textBox1 = new TextBox();
            txtPName = new TextBox();
            txtbrand = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            Addbtn = new Button();
            Updatebtn = new Button();
            Deletebtn = new Button();
            categorycombobox = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            PListlbl = new Label();
            searchlbl = new Label();
            txtsearch = new TextBox();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // productlbl
            // 
            productlbl.AutoSize = true;
            productlbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productlbl.Location = new Point(87, 31);
            productlbl.Name = "productlbl";
            productlbl.Size = new Size(166, 25);
            productlbl.TabIndex = 11;
            productlbl.Text = "Product Dashboard";
            // 
            // productIdlbl
            // 
            productIdlbl.AutoSize = true;
            productIdlbl.Location = new Point(30, 120);
            productIdlbl.Name = "productIdlbl";
            productIdlbl.Size = new Size(79, 20);
            productIdlbl.TabIndex = 12;
            productIdlbl.Text = "Product ID";
            // 
            // PNamelbl
            // 
            PNamelbl.AutoSize = true;
            PNamelbl.Location = new Point(30, 160);
            PNamelbl.Name = "PNamelbl";
            PNamelbl.Size = new Size(104, 20);
            PNamelbl.TabIndex = 13;
            PNamelbl.Text = "Product Name";
            // 
            // categorylbl
            // 
            categorylbl.AutoSize = true;
            categorylbl.Location = new Point(30, 200);
            categorylbl.Name = "categorylbl";
            categorylbl.Size = new Size(69, 20);
            categorylbl.TabIndex = 14;
            categorylbl.Text = "Category";
            // 
            // brandlbl
            // 
            brandlbl.AutoSize = true;
            brandlbl.Location = new Point(30, 240);
            brandlbl.Name = "brandlbl";
            brandlbl.Size = new Size(48, 20);
            brandlbl.TabIndex = 15;
            brandlbl.Text = "Brand";
            brandlbl.Click += label4_Click;
            // 
            // Quantitylbl
            // 
            Quantitylbl.AutoSize = true;
            Quantitylbl.Location = new Point(30, 280);
            Quantitylbl.Name = "Quantitylbl";
            Quantitylbl.Size = new Size(65, 20);
            Quantitylbl.TabIndex = 16;
            Quantitylbl.Text = "Quantity";
            // 
            // Pricelbl
            // 
            Pricelbl.AutoSize = true;
            Pricelbl.Location = new Point(30, 320);
            Pricelbl.Name = "Pricelbl";
            Pricelbl.Size = new Size(41, 20);
            Pricelbl.TabIndex = 17;
            Pricelbl.Text = "Price";
            // 
            // statuslbl
            // 
            statuslbl.AutoSize = true;
            statuslbl.Location = new Point(30, 360);
            statuslbl.Name = "statuslbl";
            statuslbl.Size = new Size(49, 20);
            statuslbl.TabIndex = 18;
            statuslbl.Text = "Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 120);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 19;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(152, 160);
            txtPName.Name = "txtPName";
            txtPName.PlaceholderText = "Enter Product Name";
            txtPName.Size = new Size(250, 27);
            txtPName.TabIndex = 20;
            // 
            // txtbrand
            // 
            txtbrand.Location = new Point(152, 240);
            txtbrand.Name = "txtbrand";
            txtbrand.PlaceholderText = "Enter Brand";
            txtbrand.Size = new Size(250, 27);
            txtbrand.TabIndex = 22;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(152, 280);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter Quantity";
            txtQuantity.Size = new Size(250, 27);
            txtQuantity.TabIndex = 23;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(152, 320);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Enter Price";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 24;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(115, 408);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(81, 30);
            Addbtn.TabIndex = 26;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(234, 408);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(81, 30);
            Updatebtn.TabIndex = 27;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(356, 408);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(81, 30);
            Deletebtn.TabIndex = 28;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // categorycombobox
            // 
            categorycombobox.ForeColor = SystemColors.GrayText;
            categorycombobox.FormattingEnabled = true;
            categorycombobox.Location = new Point(152, 200);
            categorycombobox.Name = "categorycombobox";
            categorycombobox.Size = new Size(250, 28);
            categorycombobox.TabIndex = 29;
            categorycombobox.Text = "Select Category";
            // 
            // comboBox2
            // 
            comboBox2.ForeColor = SystemColors.GrayText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Available", "Low Stock ", "Unavailable" });
            comboBox2.Location = new Point(152, 360);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 30;
            comboBox2.Text = "Enter Status";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Lavender;
            dataGridView1.Location = new Point(479, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(264, 310);
            dataGridView1.TabIndex = 31;
            // 
            // PListlbl
            // 
            PListlbl.AutoSize = true;
            PListlbl.Location = new Point(568, 73);
            PListlbl.Name = "PListlbl";
            PListlbl.Size = new Size(86, 20);
            PListlbl.TabIndex = 32;
            PListlbl.Text = "Product List";
            // 
            // searchlbl
            // 
            searchlbl.AutoSize = true;
            searchlbl.Location = new Point(436, 40);
            searchlbl.Name = "searchlbl";
            searchlbl.Size = new Size(60, 20);
            searchlbl.TabIndex = 33;
            searchlbl.Text = "Search: ";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(502, 36);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Search Product";
            txtsearch.Size = new Size(224, 27);
            txtsearch.TabIndex = 34;
            txtsearch.TextChanged += txtsearch_TextChanged;
            txtsearch.Enter += txtsearch_TextChanged;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(697, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 35;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(txtsearch);
            Controls.Add(searchlbl);
            Controls.Add(PListlbl);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(categorycombobox);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Addbtn);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtbrand);
            Controls.Add(txtPName);
            Controls.Add(textBox1);
            Controls.Add(statuslbl);
            Controls.Add(Pricelbl);
            Controls.Add(Quantitylbl);
            Controls.Add(brandlbl);
            Controls.Add(categorylbl);
            Controls.Add(PNamelbl);
            Controls.Add(productIdlbl);
            Controls.Add(productlbl);
            Controls.Add(pictureBox1);
            Name = "Product";
            Text = "Product Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

            this.Text = "Product";
            this.StartPosition = FormStartPosition.CenterScreen;
        
        }

        #endregion

        private PictureBox pictureBox1;
        private Label productlbl;
        private Label productIdlbl;
        private Label PNamelbl;
        private Label categorylbl;
        private Label brandlbl;
        private Label Quantitylbl;
        private Label Pricelbl;
        private Label statuslbl;
        private TextBox textBox1;
        private TextBox txtPName;
        private TextBox textBox3;
        private TextBox txtbrand;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox textBox7;
        private Button Addbtn;
        private Button Updatebtn;
        private Button Deletebtn;
        private ComboBox categorycombobox;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Label PListlbl;
        private Label searchlbl;
        private TextBox txtsearch;
        private Button backBtn;
    }
}