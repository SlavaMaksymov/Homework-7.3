﻿namespace Homework_7_2
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(268, 243);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 0;
            button1.Text = "Зашифрувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(418, 243);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 1;
            button2.Text = "Очистити все";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(418, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(381, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "3";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 191);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "Зсув:";
            label1.Click += label1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(268, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(418, 301);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 8;
            button3.Text = "Дешифрувати";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Шифратор";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox4;
        private Button button3;
    }
}