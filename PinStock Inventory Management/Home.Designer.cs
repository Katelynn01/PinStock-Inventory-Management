namespace PinStock_Inventory_Management
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ProductBtn = new Button();
            OrderBtn = new Button();
            CustomerBtn = new Button();
            logoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 65);
            label1.Name = "label1";
            label1.Size = new Size(389, 35);
            label1.TabIndex = 0;
            label1.Text = "PinStock Inventory Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(96, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 148);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(339, 197);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(123, 148);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(585, 197);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 124);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // ProductBtn
            // 
            ProductBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductBtn.Location = new Point(97, 332);
            ProductBtn.Name = "ProductBtn";
            ProductBtn.Size = new Size(125, 30);
            ProductBtn.TabIndex = 5;
            ProductBtn.Text = "Product";
            ProductBtn.UseVisualStyleBackColor = true;
            ProductBtn.Click += ProductBtn_Click;
            // 
            // OrderBtn
            // 
            OrderBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderBtn.Location = new Point(337, 332);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(125, 30);
            OrderBtn.TabIndex = 6;
            OrderBtn.Text = "Order";
            OrderBtn.UseVisualStyleBackColor = true;
            OrderBtn.Click += OrderBtn_Click_1;
            // 
            // CustomerBtn
            // 
            CustomerBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerBtn.Location = new Point(579, 332);
            CustomerBtn.Name = "CustomerBtn";
            CustomerBtn.Size = new Size(125, 30);
            CustomerBtn.TabIndex = 7;
            CustomerBtn.Text = "Customer";
            CustomerBtn.UseVisualStyleBackColor = true;
            CustomerBtn.Click += CustomerBtn_Click_1;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(701, 414);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(91, 27);
            logoutBtn.TabIndex = 8;
            logoutBtn.Text = "Log Out";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutBtn);
            Controls.Add(CustomerBtn);
            Controls.Add(OrderBtn);
            Controls.Add(ProductBtn);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

            //CenterToScreen
            this.Text = "Home";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button ProductBtn;
        private Button OrderBtn;
        private Button CustomerBtn;
        private Button logoutBtn;
    }
}