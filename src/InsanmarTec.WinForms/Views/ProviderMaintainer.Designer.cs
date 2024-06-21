namespace InsanmarTec.WinForms.Views
{
    partial class ProviderMaintainer
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
            CodPro = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            RUCProv = new Label();
            textBox2 = new TextBox();
            RazSoc = new Label();
            Rub = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CodPro
            // 
            CodPro.AutoSize = true;
            CodPro.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodPro.Location = new Point(17, 31);
            CodPro.Name = "CodPro";
            CodPro.Size = new Size(128, 16);
            CodPro.TabIndex = 0;
            CodPro.Text = "Codigo Proveedor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Rub);
            groupBox1.Controls.Add(RazSoc);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(RUCProv);
            groupBox1.Controls.Add(CodPro);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 225);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Proveedor";
            // 
            // RUCProv
            // 
            RUCProv.AutoSize = true;
            RUCProv.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RUCProv.Location = new Point(370, 31);
            RUCProv.Name = "RUCProv";
            RUCProv.Size = new Size(38, 16);
            RUCProv.TabIndex = 2;
            RUCProv.Text = "RUC:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(414, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 3;
            // 
            // RazSoc
            // 
            RazSoc.AutoSize = true;
            RazSoc.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RazSoc.Location = new Point(17, 114);
            RazSoc.Name = "RazSoc";
            RazSoc.Size = new Size(93, 16);
            RazSoc.TabIndex = 4;
            RazSoc.Text = "Razon Social:";
            // 
            // Rub
            // 
            Rub.AutoSize = true;
            Rub.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rub.Location = new Point(17, 159);
            Rub.Name = "Rub";
            Rub.Size = new Size(47, 16);
            Rub.TabIndex = 5;
            Rub.Text = "Rubro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 71);
            label1.Name = "label1";
            label1.Size = new Size(130, 16);
            label1.TabIndex = 6;
            label1.Text = "Nombre Completo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(370, 78);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 8;
            label2.Text = "DNI:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(411, 76);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 23);
            textBox4.TabIndex = 9;
            // 
            // ProviderMaintainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(636, 449);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderMaintainer";
            Text = "ProviderMaintainer";
            Load += ProviderMaintainer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label CodPro;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label RUCProv;
        private Label RazSoc;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private Label Rub;
    }
}