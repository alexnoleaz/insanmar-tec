namespace InsanmarTec.WinForms.Views
{
    partial class ProviderMaintainer_1
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
            corelec = new TextBox();
            groupBox1 = new GroupBox();
            btnGrab = new Button();
            rubro1 = new ComboBox();
            datTimPickProv = new DateTimePicker();
            razsoci = new TextBox();
            label4 = new Label();
            label3 = new Label();
            nomcomp = new TextBox();
            codprov = new TextBox();
            telef = new TextBox();
            label2 = new Label();
            ruc1 = new TextBox();
            label1 = new Label();
            Rub = new Label();
            RazSoc = new Label();
            direc = new TextBox();
            RUCProv = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CodPro
            // 
            CodPro.AutoSize = true;
            CodPro.BackColor = SystemColors.InactiveCaption;
            CodPro.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodPro.Location = new Point(30, 60);
            CodPro.Name = "CodPro";
            CodPro.Size = new Size(147, 17);
            CodPro.TabIndex = 0;
            CodPro.Text = "Codigo Proveedor:";
            // 
            // corelec
            // 
            corelec.Location = new Point(291, 277);
            corelec.Name = "corelec";
            corelec.Size = new Size(271, 25);
            corelec.TabIndex = 1;
            corelec.TextChanged += corelec_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGrab);
            groupBox1.Controls.Add(rubro1);
            groupBox1.Controls.Add(datTimPickProv);
            groupBox1.Controls.Add(razsoci);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nomcomp);
            groupBox1.Controls.Add(codprov);
            groupBox1.Controls.Add(telef);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ruc1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Rub);
            groupBox1.Controls.Add(RazSoc);
            groupBox1.Controls.Add(direc);
            groupBox1.Controls.Add(RUCProv);
            groupBox1.Controls.Add(CodPro);
            groupBox1.Controls.Add(corelec);
            groupBox1.Font = new Font("Lucida Fax", 11.25F);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 392);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Proveedor";
            // 
            // btnGrab
            // 
            btnGrab.BackColor = SystemColors.InactiveCaption;
            btnGrab.Font = new Font("Lucida Fax", 11.25F);
            btnGrab.Location = new Point(231, 341);
            btnGrab.Name = "btnGrab";
            btnGrab.Size = new Size(118, 54);
            btnGrab.TabIndex = 18;
            btnGrab.Text = "Grabar";
            btnGrab.UseVisualStyleBackColor = false;
            btnGrab.Click += btnGrab_Click;
            // 
            // rubro1
            // 
            rubro1.FormattingEnabled = true;
            rubro1.Location = new Point(291, 211);
            rubro1.Name = "rubro1";
            rubro1.Size = new Size(176, 25);
            rubro1.TabIndex = 17;
            rubro1.SelectedIndexChanged += rubro1_SelectedIndexChanged;
            // 
            // datTimPickProv
            // 
            datTimPickProv.Location = new Point(263, 0);
            datTimPickProv.Name = "datTimPickProv";
            datTimPickProv.Size = new Size(322, 25);
            datTimPickProv.TabIndex = 16;
            datTimPickProv.ValueChanged += datTimPickProv_ValueChanged;
            // 
            // razsoci
            // 
            razsoci.Location = new Point(30, 277);
            razsoci.Name = "razsoci";
            razsoci.Size = new Size(209, 25);
            razsoci.TabIndex = 15;
            razsoci.TextChanged += razsoci_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Lucida Fax", 11.25F);
            label4.Location = new Point(291, 258);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 13;
            label4.Text = "Correo electrónico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Lucida Fax", 11.25F);
            label3.Location = new Point(30, 126);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 12;
            label3.Text = "Teléfono:";
            // 
            // nomcomp
            // 
            nomcomp.Location = new Point(291, 79);
            nomcomp.Name = "nomcomp";
            nomcomp.Size = new Size(271, 25);
            nomcomp.TabIndex = 11;
            nomcomp.TextChanged += nomcomp_TextChanged;
            // 
            // codprov
            // 
            codprov.Location = new Point(30, 79);
            codprov.Name = "codprov";
            codprov.Size = new Size(170, 25);
            codprov.TabIndex = 10;
            codprov.TextChanged += codprov_TextChanged;
            // 
            // telef
            // 
            telef.Location = new Point(30, 145);
            telef.Name = "telef";
            telef.Size = new Size(176, 25);
            telef.TabIndex = 9;
            telef.TextChanged += telef_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Lucida Fax", 11.25F);
            label2.Location = new Point(291, 126);
            label2.Name = "label2";
            label2.Size = new Size(85, 17);
            label2.TabIndex = 8;
            label2.Text = "Dirección:";
            // 
            // ruc1
            // 
            ruc1.Location = new Point(30, 211);
            ruc1.Name = "ruc1";
            ruc1.Size = new Size(224, 25);
            ruc1.TabIndex = 7;
            ruc1.TextChanged += ruc1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 60);
            label1.Name = "label1";
            label1.Size = new Size(151, 17);
            label1.TabIndex = 6;
            label1.Text = "Nombre Completo:";
            // 
            // Rub
            // 
            Rub.AutoSize = true;
            Rub.BackColor = SystemColors.InactiveCaption;
            Rub.Font = new Font("Lucida Fax", 11.25F);
            Rub.Location = new Point(291, 192);
            Rub.Name = "Rub";
            Rub.Size = new Size(54, 17);
            Rub.TabIndex = 5;
            Rub.Text = "Rubro";
            // 
            // RazSoc
            // 
            RazSoc.AutoSize = true;
            RazSoc.BackColor = SystemColors.InactiveCaption;
            RazSoc.Font = new Font("Lucida Fax", 11.25F);
            RazSoc.Location = new Point(30, 258);
            RazSoc.Name = "RazSoc";
            RazSoc.Size = new Size(107, 17);
            RazSoc.TabIndex = 4;
            RazSoc.Text = "Razon Social:";
            // 
            // direc
            // 
            direc.Location = new Point(291, 145);
            direc.Name = "direc";
            direc.Size = new Size(271, 25);
            direc.TabIndex = 3;
            direc.TextChanged += direc_TextChanged;
            // 
            // RUCProv
            // 
            RUCProv.AutoSize = true;
            RUCProv.BackColor = SystemColors.InactiveCaption;
            RUCProv.Font = new Font("Lucida Fax", 11.25F);
            RUCProv.Location = new Point(30, 192);
            RUCProv.Name = "RUCProv";
            RUCProv.Size = new Size(45, 17);
            RUCProv.TabIndex = 2;
            RUCProv.Text = "RUC:";
            // 
            // ProviderMaintainer_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(620, 410);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderMaintainer_1";
            Text = "ProviderMaintainer";
            Load += ProviderMaintainer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label CodPro;
        private TextBox corelec;
        private GroupBox groupBox1;
        private Label RUCProv;
        private Label RazSoc;
        private TextBox direc;
        private TextBox ruc1;
        private Label label1;
        private Label Rub;
        private Label label2;
        private TextBox telef;
        private TextBox nomcomp;
        private TextBox codprov;
        private Label label4;
        private Label label3;
        private TextBox razsoci;
        private ComboBox rubro1;
        private DateTimePicker datTimPickProv;
        private Button btnGrab;
    }
}