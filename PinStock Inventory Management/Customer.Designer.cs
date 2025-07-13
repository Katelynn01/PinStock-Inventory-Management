namespace PinStock_Inventory_Management
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            logo = new PictureBox();
            customerlbl = new Label();
            Custidlbl = new Label();
            CNamelbl = new Label();
            label3 = new Label();
            txtCId = new TextBox();
            txtCName = new TextBox();
            txtCNum = new TextBox();
            textBox1 = new TextBox();
            dgProductList = new DataGridView();
            Addbtn = new Button();
            Updatebtn = new Button();
            Deletebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProductList).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(69, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 9;
            logo.TabStop = false;
            // 
            // customerlbl
            // 
            customerlbl.AutoSize = true;
            customerlbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerlbl.Location = new Point(87, 31);
            customerlbl.Name = "customerlbl";
            customerlbl.Size = new Size(181, 25);
            customerlbl.TabIndex = 11;
            customerlbl.Text = "Customer Dashboard";
            // 
            // Custidlbl
            // 
            Custidlbl.AutoSize = true;
            Custidlbl.Location = new Point(54, 123);
            Custidlbl.Name = "Custidlbl";
            Custidlbl.Size = new Size(91, 20);
            Custidlbl.TabIndex = 12;
            Custidlbl.Text = "Customer ID";
            // 
            // CNamelbl
            // 
            CNamelbl.AutoSize = true;
            CNamelbl.Location = new Point(54, 184);
            CNamelbl.Name = "CNamelbl";
            CNamelbl.Size = new Size(116, 20);
            CNamelbl.TabIndex = 13;
            CNamelbl.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 245);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 14;
            label3.Text = "Contact Number";
            // 
            // txtCId
            // 
            txtCId.Location = new Point(51, 150);
            txtCId.Name = "txtCId";
            txtCId.PlaceholderText = "Enter Customer ID";
            txtCId.ReadOnly = true;
            txtCId.Size = new Size(227, 27);
            txtCId.TabIndex = 24;
            // 
            // txtCName
            // 
            txtCName.Location = new Point(51, 212);
            txtCName.Name = "txtCName";
            txtCName.PlaceholderText = "Enter Customer Name";
            txtCName.Size = new Size(227, 27);
            txtCName.TabIndex = 25;
            // 
            // txtCNum
            // 
            txtCNum.Location = new Point(51, 272);
            txtCNum.Name = "txtCNum";
            txtCNum.PlaceholderText = "Enter Contact Number";
            txtCNum.Size = new Size(227, 27);
            txtCNum.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(367, 58);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Customer";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 27;
            // 
            // dgProductList
            // 
            dgProductList.BackgroundColor = Color.LavenderBlush;
            dgProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductList.GridColor = Color.Lavender;
            dgProductList.Location = new Point(419, 102);
            dgProductList.Name = "dgProductList";
            dgProductList.RowHeadersWidth = 51;
            dgProductList.Size = new Size(264, 310);
            dgProductList.TabIndex = 32;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(25, 361);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(81, 30);
            Addbtn.TabIndex = 33;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(126, 361);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(81, 30);
            Updatebtn.TabIndex = 34;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(226, 361);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(81, 30);
            Deletebtn.TabIndex = 35;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Addbtn);
            Controls.Add(dgProductList);
            Controls.Add(textBox1);
            Controls.Add(txtCNum);
            Controls.Add(txtCName);
            Controls.Add(txtCId);
            Controls.Add(label3);
            Controls.Add(CNamelbl);
            Controls.Add(Custidlbl);
            Controls.Add(customerlbl);
            Controls.Add(logo);
            Name = "Customer";
            Text = "Customer Dashboard";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label customerlbl;
        private Label Custidlbl;
        private Label CNamelbl;
        private Label label3;
        private TextBox txtCId;
        private TextBox txtCName;
        private TextBox txtCNum;
        private TextBox textBox1;
        private DataGridView dgProductList;
        private Button Addbtn;
        private Button Updatebtn;
        private Button Deletebtn;
    }
}