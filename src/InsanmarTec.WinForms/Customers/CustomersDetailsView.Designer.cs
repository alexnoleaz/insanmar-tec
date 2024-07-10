namespace InsanmarTec.WinForms.Views
{
    partial class CustomersDetailsView
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
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtDni = new MaterialSkin.Controls.MaterialTextBox();
            product.SuspendLayout();
            SuspendLayout();
            // 
            // product
            // 
            product.BackColor = Color.FromArgb(255, 255, 255);
            product.Controls.Add(txtDni);
            product.Controls.Add(txtEmail);
            product.Controls.Add(txtPhone);
            product.Controls.Add(txtAddress);
            product.Controls.Add(txtLastName);
            product.Controls.Add(txtFirstName);
            product.Controls.Add(lblTitle);
            product.Controls.Add(btnCancel);
            product.Controls.Add(btnSave);
            product.Depth = 0;
            product.ForeColor = Color.FromArgb(222, 0, 0, 0);
            product.Location = new Point(9, 5);
            product.Margin = new Padding(14);
            product.MouseState = MaterialSkin.MouseState.HOVER;
            product.Name = "product";
            product.Padding = new Padding(14);
            product.Size = new Size(339, 420);
            product.TabIndex = 8;
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
            btnCancel.Location = new Point(175, 375);
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
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(79, 375);
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
            // txtFirstName
            // 
            txtFirstName.AnimateReadOnly = false;
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Depth = 0;
            txtFirstName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFirstName.Hint = "Nombres";
            txtFirstName.LeadingIcon = null;
            txtFirstName.Location = new Point(37, 31);
            txtFirstName.MaxLength = 50;
            txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            txtFirstName.Multiline = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(264, 50);
            txtFirstName.TabIndex = 6;
            txtFirstName.Text = "";
            txtFirstName.TrailingIcon = null;
            // 
            // txtLastName
            // 
            txtLastName.AnimateReadOnly = false;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Depth = 0;
            txtLastName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLastName.Hint = "Apellidos";
            txtLastName.LeadingIcon = null;
            txtLastName.Location = new Point(37, 87);
            txtLastName.MaxLength = 50;
            txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            txtLastName.Multiline = false;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(264, 50);
            txtLastName.TabIndex = 7;
            txtLastName.Text = "";
            txtLastName.TrailingIcon = null;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.Hint = "Dirección";
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(37, 143);
            txtAddress.MaxLength = 150;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(264, 50);
            txtAddress.TabIndex = 8;
            txtAddress.Text = "";
            txtAddress.TrailingIcon = null;
            // 
            // txtPhone
            // 
            txtPhone.AnimateReadOnly = false;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.Hint = "Telefono";
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(37, 199);
            txtPhone.MaxLength = 9;
            txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(264, 50);
            txtPhone.TabIndex = 9;
            txtPhone.Text = "";
            txtPhone.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Correo electrónico";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(37, 255);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 50);
            txtEmail.TabIndex = 10;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // txtDni
            // 
            txtDni.AnimateReadOnly = false;
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Depth = 0;
            txtDni.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDni.Hint = "DNI";
            txtDni.LeadingIcon = null;
            txtDni.Location = new Point(37, 311);
            txtDni.MaxLength = 8;
            txtDni.MouseState = MaterialSkin.MouseState.OUT;
            txtDni.Multiline = false;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(264, 50);
            txtDni.TabIndex = 11;
            txtDni.Text = "";
            txtDni.TrailingIcon = null;
            // 
            // CustomersDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(356, 431);
            Controls.Add(product);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomersDetailsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            product.ResumeLayout(false);
            product.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard product;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialComboBox cmbQuality;
        private MaterialSkin.Controls.MaterialComboBox cmbModel;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtDni;
    }
}