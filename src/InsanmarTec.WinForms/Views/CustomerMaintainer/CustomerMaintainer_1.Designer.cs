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
            product = new MaterialSkin.Controls.MaterialCard();
            txtDirection = new MaterialSkin.Controls.MaterialTextBox();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            txtCod = new MaterialSkin.Controls.MaterialTextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            txtPhoneadd = new MaterialSkin.Controls.MaterialTextBox();
            product.SuspendLayout();
            SuspendLayout();
            // 
            // product
            // 
            product.BackColor = Color.FromArgb(255, 255, 255);
            product.Controls.Add(txtPhoneadd);
            product.Controls.Add(txtPhone);
            product.Controls.Add(txtDirection);
            product.Controls.Add(lblTitle);
            product.Controls.Add(btnCancel);
            product.Controls.Add(txtCod);
            product.Controls.Add(btnSave);
            product.Controls.Add(txtName);
            product.Depth = 0;
            product.ForeColor = Color.FromArgb(222, 0, 0, 0);
            product.Location = new Point(10, 9);
            product.Margin = new Padding(14);
            product.MouseState = MaterialSkin.MouseState.HOVER;
            product.Name = "product";
            product.Padding = new Padding(14);
            product.Size = new Size(434, 388);
            product.TabIndex = 8;
            // 
            // txtDirection
            // 
            txtDirection.AnimateReadOnly = false;
            txtDirection.BorderStyle = BorderStyle.None;
            txtDirection.Depth = 0;
            txtDirection.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDirection.Hint = "Dirección";
            txtDirection.LeadingIcon = null;
            txtDirection.Location = new Point(84, 144);
            txtDirection.MaxLength = 50;
            txtDirection.MouseState = MaterialSkin.MouseState.OUT;
            txtDirection.Multiline = false;
            txtDirection.Name = "txtDirection";
            txtDirection.Size = new Size(264, 50);
            txtDirection.TabIndex = 10;
            txtDirection.Text = "";
            txtDirection.TrailingIcon = null;
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
            // txtCod
            // 
            txtCod.AnimateReadOnly = false;
            txtCod.BorderStyle = BorderStyle.None;
            txtCod.Depth = 0;
            txtCod.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCod.Hint = "Codigo de Cliente";
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
            // txtPhone
            // 
            txtPhone.AnimateReadOnly = false;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.Hint = "Teléfono";
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(37, 89);
            txtPhone.MaxLength = 50;
            txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(173, 50);
            txtPhone.TabIndex = 15;
            txtPhone.Text = "";
            txtPhone.TrailingIcon = null;
            // 
            // txtPhoneadd
            // 
            txtPhoneadd.AnimateReadOnly = false;
            txtPhoneadd.BorderStyle = BorderStyle.None;
            txtPhoneadd.Depth = 0;
            txtPhoneadd.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhoneadd.Hint = "Teléfono adicional";
            txtPhoneadd.LeadingIcon = null;
            txtPhoneadd.Location = new Point(216, 88);
            txtPhoneadd.MaxLength = 50;
            txtPhoneadd.MouseState = MaterialSkin.MouseState.OUT;
            txtPhoneadd.Multiline = false;
            txtPhoneadd.Name = "txtPhoneadd";
            txtPhoneadd.Size = new Size(188, 50);
            txtPhoneadd.TabIndex = 16;
            txtPhoneadd.Text = "";
            txtPhoneadd.TrailingIcon = null;
            // 
            // CustomerMaintainer_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(455, 410);
            Controls.Add(product);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerMaintainer_1";
            Text = "Form1";
            product.ResumeLayout(false);
            product.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard product;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox cmbQuality;
        private MaterialSkin.Controls.MaterialComboBox cmbModel;
        private MaterialSkin.Controls.MaterialTextBox txtDirection;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialTextBox txtCod;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtPhoneadd;
    }
}