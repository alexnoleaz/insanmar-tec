namespace InsanmarTec.WinForms.Views
{
    partial class CustomerMaintainer_1
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
            groupBox1 = new GroupBox();
            CMBTIPCLI = new ComboBox();
            BTNGRABAR = new Button();
            CORELEC = new TextBox();
            DIREC = new TextBox();
            TELEADI = new TextBox();
            TELE1 = new TextBox();
            NOMCOMP = new TextBox();
            DNI1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            datTiPickCUM = new DateTimePicker();
            datTiPickFECH = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CMBTIPCLI);
            groupBox1.Controls.Add(BTNGRABAR);
            groupBox1.Controls.Add(CORELEC);
            groupBox1.Controls.Add(DIREC);
            groupBox1.Controls.Add(TELEADI);
            groupBox1.Controls.Add(TELE1);
            groupBox1.Controls.Add(NOMCOMP);
            groupBox1.Controls.Add(DNI1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(datTiPickCUM);
            groupBox1.Controls.Add(datTiPickFECH);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 386);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Cliente";
            // 
            // CMBTIPCLI
            // 
            CMBTIPCLI.FormattingEnabled = true;
            CMBTIPCLI.Location = new Point(22, 260);
            CMBTIPCLI.Name = "CMBTIPCLI";
            CMBTIPCLI.Size = new Size(192, 25);
            CMBTIPCLI.TabIndex = 18;
            CMBTIPCLI.SelectedIndexChanged += CMBTIPCLI_SelectedIndexChanged;
            // 
            // BTNGRABAR
            // 
            BTNGRABAR.BackColor = SystemColors.InactiveCaption;
            BTNGRABAR.Location = new Point(461, 273);
            BTNGRABAR.Name = "BTNGRABAR";
            BTNGRABAR.Size = new Size(108, 59);
            BTNGRABAR.TabIndex = 17;
            BTNGRABAR.Text = "Grabar";
            BTNGRABAR.UseVisualStyleBackColor = false;
            BTNGRABAR.Click += BTNGRABAR_Click;
            // 
            // CORELEC
            // 
            CORELEC.Location = new Point(22, 325);
            CORELEC.Name = "CORELEC";
            CORELEC.Size = new Size(381, 25);
            CORELEC.TabIndex = 16;
            CORELEC.TextChanged += CORELEC_TextChanged;
            // 
            // DIREC
            // 
            DIREC.Location = new Point(22, 195);
            DIREC.Name = "DIREC";
            DIREC.Size = new Size(497, 25);
            DIREC.TabIndex = 14;
            DIREC.TextChanged += DIREC_TextChanged;
            // 
            // TELEADI
            // 
            TELEADI.Location = new Point(278, 130);
            TELEADI.Name = "TELEADI";
            TELEADI.Size = new Size(196, 25);
            TELEADI.TabIndex = 13;
            TELEADI.TextChanged += TELEADI_TextChanged;
            // 
            // TELE1
            // 
            TELE1.Location = new Point(22, 130);
            TELE1.Name = "TELE1";
            TELE1.Size = new Size(196, 25);
            TELE1.TabIndex = 12;
            TELE1.TextChanged += TELE1_TextChanged;
            // 
            // NOMCOMP
            // 
            NOMCOMP.Location = new Point(278, 65);
            NOMCOMP.Name = "NOMCOMP";
            NOMCOMP.Size = new Size(269, 25);
            NOMCOMP.TabIndex = 11;
            NOMCOMP.TextChanged += NOMCOMP_TextChanged;
            // 
            // DNI1
            // 
            DNI1.Location = new Point(22, 65);
            DNI1.Name = "DNI1";
            DNI1.Size = new Size(196, 25);
            DNI1.TabIndex = 10;
            DNI1.TextChanged += DNI1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.InactiveCaption;
            label8.Location = new Point(22, 305);
            label8.Name = "label8";
            label8.Size = new Size(152, 17);
            label8.TabIndex = 9;
            label8.Text = "Correo electrónico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.InactiveCaption;
            label7.Location = new Point(278, 240);
            label7.Name = "label7";
            label7.Size = new Size(107, 17);
            label7.TabIndex = 8;
            label7.Text = "Cumpleaños:";
            // 
            // datTiPickCUM
            // 
            datTiPickCUM.Format = DateTimePickerFormat.Short;
            datTiPickCUM.Location = new Point(278, 260);
            datTiPickCUM.Name = "datTiPickCUM";
            datTiPickCUM.Size = new Size(125, 25);
            datTiPickCUM.TabIndex = 7;
            datTiPickCUM.ValueChanged += datTiPickCUM_ValueChanged;
            // 
            // datTiPickFECH
            // 
            datTiPickFECH.Location = new Point(278, 0);
            datTiPickFECH.Name = "datTiPickFECH";
            datTiPickFECH.Size = new Size(318, 25);
            datTiPickFECH.TabIndex = 6;
            datTiPickFECH.ValueChanged += datTiPickFECH_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.InactiveCaption;
            label6.Location = new Point(22, 240);
            label6.Name = "label6";
            label6.Size = new Size(128, 17);
            label6.TabIndex = 5;
            label6.Text = "Tipo de Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.InactiveCaption;
            label5.Location = new Point(278, 110);
            label5.Name = "label5";
            label5.Size = new Size(151, 17);
            label5.TabIndex = 4;
            label5.Text = "Teléfono adicional:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Location = new Point(22, 175);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Location = new Point(22, 110);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 2;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Location = new Point(278, 45);
            label2.Name = "label2";
            label2.Size = new Size(148, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Location = new Point(22, 45);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // CustomerMaintainer_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(620, 410);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerMaintainer_1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker datTiPickFECH;
        private Label label8;
        private Label label7;
        private DateTimePicker datTiPickCUM;
        private Button BTNGRABAR;
        private TextBox CORELEC;
        private TextBox DIREC;
        private TextBox TELEADI;
        private TextBox TELE1;
        private TextBox NOMCOMP;
        private TextBox DNI1;
        private ComboBox CMBTIPCLI;
    }
}