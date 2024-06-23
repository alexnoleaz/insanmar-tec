namespace InsanmarTec.WinForms.Views.CustomerMaintainer
{
    partial class CustomerMaintainer_2
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
            datGrViCLI2 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            DNI1 = new DataGridViewTextBoxColumn();
            nombrecompleto = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            telefonoadicional = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            tipocliente = new DataGridViewTextBoxColumn();
            correoelectronico = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            fechacumple = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datGrViCLI2).BeginInit();
            SuspendLayout();
            // 
            // datGrViCLI2
            // 
            datGrViCLI2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            datGrViCLI2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datGrViCLI2.Columns.AddRange(new DataGridViewColumn[] { DNI1, nombrecompleto, telefono, telefonoadicional, direccion, tipocliente, correoelectronico, fecha, fechacumple });
            datGrViCLI2.Location = new Point(12, 79);
            datGrViCLI2.Name = "datGrViCLI2";
            datGrViCLI2.Size = new Size(596, 319);
            datGrViCLI2.TabIndex = 0;
            datGrViCLI2.CellContentClick += datGrViCLI2_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(108, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 25);
            textBox1.TabIndex = 1;
            textBox1.Text = "Ingrese el DNI a buscar";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(462, 12);
            button1.Name = "button1";
            button1.Size = new Size(110, 48);
            button1.TabIndex = 2;
            button1.Text = "Grabar";
            button1.UseVisualStyleBackColor = false;
            // 
            // DNI1
            // 
            DNI1.HeaderText = "DNI";
            DNI1.Name = "DNI1";
            // 
            // nombrecompleto
            // 
            nombrecompleto.HeaderText = "Nombre Completo";
            nombrecompleto.Name = "nombrecompleto";
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            // 
            // telefonoadicional
            // 
            telefonoadicional.HeaderText = "Teléfono Adicional";
            telefonoadicional.Name = "telefonoadicional";
            // 
            // direccion
            // 
            direccion.HeaderText = "Dirección";
            direccion.Name = "direccion";
            // 
            // tipocliente
            // 
            tipocliente.HeaderText = "Tipo Cliente";
            tipocliente.Name = "tipocliente";
            tipocliente.Resizable = DataGridViewTriState.True;
            // 
            // correoelectronico
            // 
            correoelectronico.HeaderText = "Correo Electronico";
            correoelectronico.Name = "correoelectronico";
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            // 
            // fechacumple
            // 
            fechacumple.HeaderText = "Fecha de cumpleaños";
            fechacumple.Name = "fechacumple";
            // 
            // CustomerMaintainer_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(620, 410);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(datGrViCLI2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerMaintainer_2";
            Text = "CustomerMaintainer_2";
            ((System.ComponentModel.ISupportInitialize)datGrViCLI2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datGrViCLI2;
        private TextBox textBox1;
        private Button button1;
        private DataGridViewTextBoxColumn DNI1;
        private DataGridViewTextBoxColumn nombrecompleto;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn telefonoadicional;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn tipocliente;
        private DataGridViewTextBoxColumn correoelectronico;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn fechacumple;
    }
}