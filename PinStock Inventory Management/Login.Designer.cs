﻿using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PinStock_Inventory_Management
{
    partial class LogIn
    {
    
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            checkBox1 = new CheckBox();
            LoginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(520, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(318, 315);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(122, 40);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LogInBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 65);
            label1.Name = "label1";
            label1.Size = new Size(389, 35);
            label1.TabIndex = 1;
            label1.Text = "PinStock Inventory Management";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 192);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 254);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 187);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your Username";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 250);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your Password";
            textBox2.Size = new Size(270, 27);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            //center to screen
            this.Text = "LogIn";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        private Button LoginBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;

       
    }
    
        } 
