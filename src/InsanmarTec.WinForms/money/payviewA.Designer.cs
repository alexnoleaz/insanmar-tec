namespace InsanmarTec.WinForms.money
{
    partial class payviewA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payviewA));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(256, 20);
            label1.TabIndex = 1;
            label1.Text = "Numero de documento de identidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 154);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre titular de la tarjeta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 3;
            label3.Text = "Numero de tarjeta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 228);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 4;
            label4.Text = "MM/AA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 228);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 5;
            label5.Text = "CVV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 269);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 6;
            label6.Text = "Total a Pagar";
            // 
            // button1
            // 
            button1.Location = new Point(74, 316);
            button1.Name = "button1";
            button1.Size = new Size(158, 63);
            button1.TabIndex = 7;
            button1.Text = "COMFIRMAR PAGO";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(274, 316);
            button2.Name = "button2";
            button2.Size = new Size(164, 63);
            button2.TabIndex = 8;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 42);
            label7.Name = "label7";
            label7.Size = new Size(273, 20);
            label7.TabIndex = 14;
            label7.Text = "Informacion de tarjeta Credito o Debito";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 27);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(74, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(81, 27);
            textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(212, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(81, 27);
            textBox4.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(113, 266);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(81, 27);
            textBox6.TabIndex = 21;
            // 
            // payviewA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(557, 402);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "payviewA";
            Text = "payviewA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox6;
    }
}