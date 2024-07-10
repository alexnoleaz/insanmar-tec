namespace InsanmarTec.WinForms.money
{
    partial class cashPaymentA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashPaymentA));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 92);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombres Completos ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 140);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 3;
            label1.Text = "Documento de Identidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 184);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 4;
            label3.Text = "Total a Pagar ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 35);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 5;
            label4.Text = "Pago en Efectivo ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 27);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 27);
            textBox3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(247, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(95, 252);
            button1.Name = "button1";
            button1.Size = new Size(146, 75);
            button1.TabIndex = 14;
            button1.Text = "COMFIRMAR PAGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(285, 252);
            button2.Name = "button2";
            button2.Size = new Size(146, 75);
            button2.TabIndex = 15;
            button2.Text = "PAGAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // cashPaymentA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(557, 402);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cashPaymentA";
            Text = "cashPaymentA";
            Load += cashPaymentA_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}