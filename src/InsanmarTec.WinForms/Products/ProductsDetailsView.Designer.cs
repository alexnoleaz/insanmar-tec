namespace InsanmarTec.WinForms.Views.ProductMaintainer
{
    partial class ProductsDetailsView
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
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            txtCod = new MaterialSkin.Controls.MaterialTextBox();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            cmbType = new MaterialSkin.Controls.MaterialComboBox();
            product = new MaterialSkin.Controls.MaterialCard();
            txtDescription = new MaterialSkin.Controls.MaterialTextBox();
            cmbBrand = new MaterialSkin.Controls.MaterialComboBox();
            cmbModel = new MaterialSkin.Controls.MaterialComboBox();
            cmbQuality = new MaterialSkin.Controls.MaterialComboBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            product.SuspendLayout();
            SuspendLayout();
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
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(120, 317);
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
            // txtCod
            // 
            txtCod.AnimateReadOnly = false;
            txtCod.BorderStyle = BorderStyle.None;
            txtCod.Depth = 0;
            txtCod.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCod.Hint = "Codigo de Producto";
            txtCod.LeadingIcon = null;
            txtCod.Location = new Point(37, 33);
            txtCod.MaxLength = 50;
            txtCod.MouseState = MaterialSkin.MouseState.OUT;
            txtCod.Multiline = false;
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(173, 50);
            txtCod.TabIndex = 0;
            txtCod.Text = "";
            txtCod.TrailingIcon = null;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(216, 317);
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitle.Location = new Point(37, 9);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(122, 19);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "DetallesProducto";
            lblTitle.Click += lblTitle_Click;
            // 
            // cmbType
            // 
            cmbType.AutoResize = false;
            cmbType.BackColor = Color.FromArgb(255, 255, 255);
            cmbType.Depth = 0;
            cmbType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbType.DropDownHeight = 174;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.DropDownWidth = 121;
            cmbType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbType.FormattingEnabled = true;
            cmbType.Hint = "Tipo de Producto";
            cmbType.IntegralHeight = false;
            cmbType.ItemHeight = 43;
            cmbType.Location = new Point(37, 89);
            cmbType.MaxDropDownItems = 4;
            cmbType.MouseState = MaterialSkin.MouseState.OUT;
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(173, 49);
            cmbType.StartIndex = 0;
            cmbType.TabIndex = 9;
            // 
            // product
            // 
            product.BackColor = Color.FromArgb(255, 255, 255);
            product.Controls.Add(materialTextBox1);
            product.Controls.Add(cmbQuality);
            product.Controls.Add(cmbModel);
            product.Controls.Add(cmbBrand);
            product.Controls.Add(txtDescription);
            product.Controls.Add(cmbType);
            product.Controls.Add(lblTitle);
            product.Controls.Add(btnCancel);
            product.Controls.Add(txtCod);
            product.Controls.Add(btnSave);
            product.Controls.Add(txtName);
            product.Depth = 0;
            product.ForeColor = Color.FromArgb(222, 0, 0, 0);
            product.Location = new Point(5, 3);
            product.Margin = new Padding(14);
            product.MouseState = MaterialSkin.MouseState.HOVER;
            product.Name = "product";
            product.Padding = new Padding(14);
            product.Size = new Size(434, 388);
            product.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Depth = 0;
            txtDescription.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescription.Hint = "Descripción";
            txtDescription.LeadingIcon = null;
            txtDescription.Location = new Point(84, 144);
            txtDescription.MaxLength = 50;
            txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtDescription.Multiline = false;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(264, 50);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            txtDescription.TrailingIcon = null;
            // 
            // cmbBrand
            // 
            cmbBrand.AutoResize = false;
            cmbBrand.BackColor = Color.FromArgb(255, 255, 255);
            cmbBrand.Depth = 0;
            cmbBrand.DrawMode = DrawMode.OwnerDrawVariable;
            cmbBrand.DropDownHeight = 174;
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrand.DropDownWidth = 121;
            cmbBrand.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbBrand.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Hint = "Tipo de Marca";
            cmbBrand.IntegralHeight = false;
            cmbBrand.ItemHeight = 43;
            cmbBrand.Location = new Point(216, 89);
            cmbBrand.MaxDropDownItems = 4;
            cmbBrand.MouseState = MaterialSkin.MouseState.OUT;
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(188, 49);
            cmbBrand.StartIndex = 0;
            cmbBrand.TabIndex = 11;
            // 
            // cmbModel
            // 
            cmbModel.AutoResize = false;
            cmbModel.BackColor = Color.FromArgb(255, 255, 255);
            cmbModel.Depth = 0;
            cmbModel.DrawMode = DrawMode.OwnerDrawVariable;
            cmbModel.DropDownHeight = 174;
            cmbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModel.DropDownWidth = 121;
            cmbModel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbModel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbModel.FormattingEnabled = true;
            cmbModel.Hint = "Tipo de Modelo";
            cmbModel.IntegralHeight = false;
            cmbModel.ItemHeight = 43;
            cmbModel.Location = new Point(37, 203);
            cmbModel.MaxDropDownItems = 4;
            cmbModel.MouseState = MaterialSkin.MouseState.OUT;
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(173, 49);
            cmbModel.StartIndex = 0;
            cmbModel.TabIndex = 12;
            // 
            // cmbQuality
            // 
            cmbQuality.AutoResize = false;
            cmbQuality.BackColor = Color.FromArgb(255, 255, 255);
            cmbQuality.Depth = 0;
            cmbQuality.DrawMode = DrawMode.OwnerDrawVariable;
            cmbQuality.DropDownHeight = 174;
            cmbQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuality.DropDownWidth = 121;
            cmbQuality.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbQuality.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbQuality.FormattingEnabled = true;
            cmbQuality.Hint = "Tipo de Calidad";
            cmbQuality.IntegralHeight = false;
            cmbQuality.ItemHeight = 43;
            cmbQuality.Location = new Point(216, 203);
            cmbQuality.MaxDropDownItems = 4;
            cmbQuality.MouseState = MaterialSkin.MouseState.OUT;
            cmbQuality.Name = "cmbQuality";
            cmbQuality.Size = new Size(188, 49);
            cmbQuality.StartIndex = 0;
            cmbQuality.TabIndex = 13;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "Precio";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(84, 258);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(248, 50);
            materialTextBox1.TabIndex = 14;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // ProductMaintainer_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(444, 400);
            Controls.Add(product);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductMaintainer_1";
            Text = "ProductMaintainer_1";
            product.ResumeLayout(false);
            product.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox txtCod;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialComboBox cmbType;
        private MaterialSkin.Controls.MaterialCard product;
        private MaterialSkin.Controls.MaterialTextBox txtDescription;
        private MaterialSkin.Controls.MaterialComboBox cmbModel;
        private MaterialSkin.Controls.MaterialComboBox cmbBrand;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox cmbQuality;
    }
}