﻿namespace InsanmarTec.WinForms.money
{
    partial class TransferA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferA));
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 30);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 7;
            label5.Text = "Trasferencia Bancaria";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(247, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 9;
            label2.Text = "Entidad Financiera";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 118);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 10;
            label1.Text = "Numero de Cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 156);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 11;
            label3.Text = "Nombres Completos ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 193);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 12;
            label4.Text = "Total a Pagar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(123, 193);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 27);
            textBox4.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(82, 247);
            button1.Name = "button1";
            button1.Size = new Size(146, 75);
            button1.TabIndex = 17;
            button1.Text = "COMFIRMAR PAGAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(273, 247);
            button2.Name = "button2";
            button2.Size = new Size(146, 75);
            button2.TabIndex = 18;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // TransferA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(539, 355);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransferA";
            Text = "TransferA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}