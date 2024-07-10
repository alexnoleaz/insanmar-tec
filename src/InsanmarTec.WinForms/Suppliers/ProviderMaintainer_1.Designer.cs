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
            product = new MaterialSkin.Controls.MaterialCard();
            txtCorr = new MaterialSkin.Controls.MaterialTextBox();
            cmbTypeClie = new MaterialSkin.Controls.MaterialComboBox();
            txtDescription = new MaterialSkin.Controls.MaterialTextBox();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            txtCustomer = new MaterialSkin.Controls.MaterialTextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            product.SuspendLayout();
            SuspendLayout();
            // 
            // product
            // 
            product.BackColor = Color.FromArgb(255, 255, 255);
            product.Controls.Add(materialTextBox3);
            product.Controls.Add(materialTextBox2);
            product.Controls.Add(txtCorr);
            product.Controls.Add(cmbTypeClie);
            product.Controls.Add(txtDescription);
            product.Controls.Add(lblTitle);
            product.Controls.Add(btnCancel);
            product.Controls.Add(txtCustomer);
            product.Controls.Add(btnSave);
            product.Controls.Add(txtName);
            product.Depth = 0;
            product.ForeColor = Color.FromArgb(222, 0, 0, 0);
            product.Location = new Point(4, 10);
            product.Margin = new Padding(14);
            product.MouseState = MaterialSkin.MouseState.HOVER;
            product.Name = "product";
            product.Padding = new Padding(14);
            product.Size = new Size(434, 388);
            product.TabIndex = 8;
            // 
            // txtCorr
            // 
            txtCorr.AnimateReadOnly = false;
            txtCorr.BorderStyle = BorderStyle.None;
            txtCorr.Depth = 0;
            txtCorr.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCorr.Hint = "Correo electrónico";
            txtCorr.LeadingIcon = null;
            txtCorr.Location = new Point(84, 255);
            txtCorr.MaxLength = 50;
            txtCorr.MouseState = MaterialSkin.MouseState.OUT;
            txtCorr.Multiline = false;
            txtCorr.Name = "txtCorr";
            txtCorr.Size = new Size(248, 50);
            txtCorr.TabIndex = 14;
            txtCorr.Text = "";
            txtCorr.TrailingIcon = null;
            // 
            // cmbTypeClie
            // 
            cmbTypeClie.AutoResize = false;
            cmbTypeClie.BackColor = Color.FromArgb(255, 255, 255);
            cmbTypeClie.Depth = 0;
            cmbTypeClie.DrawMode = DrawMode.OwnerDrawVariable;
            cmbTypeClie.DropDownHeight = 174;
            cmbTypeClie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeClie.DropDownWidth = 121;
            cmbTypeClie.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbTypeClie.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbTypeClie.FormattingEnabled = true;
            cmbTypeClie.Hint = "Tipo de cliente";
            cmbTypeClie.IntegralHeight = false;
            cmbTypeClie.ItemHeight = 43;
            cmbTypeClie.Location = new Point(120, 203);
            cmbTypeClie.MaxDropDownItems = 4;
            cmbTypeClie.MouseState = MaterialSkin.MouseState.OUT;
            cmbTypeClie.Name = "cmbTypeClie";
            cmbTypeClie.Size = new Size(173, 49);
            cmbTypeClie.StartIndex = 0;
            cmbTypeClie.TabIndex = 12;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Depth = 0;
            txtDescription.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescription.Hint = "Dirección";
            txtDescription.LeadingIcon = null;
            txtDescription.Location = new Point(37, 145);
            txtDescription.MaxLength = 50;
            txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtDescription.Multiline = false;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(367, 50);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            txtDescription.TrailingIcon = null;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitle.Location = new Point(37, 9);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(106, 19);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "DetallesCliente";
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(216, 332);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(96, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCustomer
            // 
            txtCustomer.AnimateReadOnly = false;
            txtCustomer.BorderStyle = BorderStyle.None;
            txtCustomer.Depth = 0;
            txtCustomer.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCustomer.Hint = "Codigo de Cliente";
            txtCustomer.LeadingIcon = null;
            txtCustomer.Location = new Point(37, 33);
            txtCustomer.MaxLength = 50;
            txtCustomer.MouseState = MaterialSkin.MouseState.OUT;
            txtCustomer.Multiline = false;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(173, 50);
            txtCustomer.TabIndex = 0;
            txtCustomer.Text = "";
            txtCustomer.TrailingIcon = null;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(120, 332);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(88, 36);
            btnSave.TabIndex = 4;
            btnSave.Text = "Guardar";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.Hint = "Nombre";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(216, 33);
            txtName.MaxLength = 50;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 50);
            txtName.TabIndex = 1;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.Hint = "Teléfono";
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(37, 89);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(173, 50);
            materialTextBox2.TabIndex = 15;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            materialTextBox3.AnimateReadOnly = false;
            materialTextBox3.BorderStyle = BorderStyle.None;
            materialTextBox3.Depth = 0;
            materialTextBox3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox3.Hint = "Teléfono adicional";
            materialTextBox3.LeadingIcon = null;
            materialTextBox3.Location = new Point(216, 89);
            materialTextBox3.MaxLength = 50;
            materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox3.Multiline = false;
            materialTextBox3.Name = "materialTextBox3";
            materialTextBox3.Size = new Size(188, 50);
            materialTextBox3.TabIndex = 16;
            materialTextBox3.Text = "";
            materialTextBox3.TrailingIcon = null;
            // 
            // ProviderMaintainer_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(445, 410);
            Controls.Add(product);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderMaintainer_1";
            Text = "ProviderMaintainer";
            Load += ProviderMaintainer_Load;
            product.ResumeLayout(false);
            product.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard product;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox txtCorr;
        private MaterialSkin.Controls.MaterialComboBox cmbTypeClie;
        private MaterialSkin.Controls.MaterialTextBox txtDescription;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialTextBox txtCustomer;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox txtName;
    }
}