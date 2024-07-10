namespace InsanmarTec.WinForms.Brands
{
    partial class BrandsDetailsView
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
            components = new System.ComponentModel.Container();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            txtDescription = new MaterialSkin.Controls.MaterialTextBox();
            txtCategory = new MaterialSkin.Controls.MaterialTextBox();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            errorProvider = new ErrorProvider(components);
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.Hint = "Nombre";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(37, 33);
            txtName.MaxLength = 50;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 50);
            txtName.TabIndex = 0;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Depth = 0;
            txtDescription.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescription.Hint = "Descripción";
            txtDescription.LeadingIcon = null;
            txtDescription.Location = new Point(37, 89);
            txtDescription.MaxLength = 50;
            txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtDescription.Multiline = false;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(264, 50);
            txtDescription.TabIndex = 1;
            txtDescription.Text = "";
            txtDescription.TrailingIcon = null;
            // 
            // txtCategory
            // 
            txtCategory.AnimateReadOnly = false;
            txtCategory.BorderStyle = BorderStyle.None;
            txtCategory.Depth = 0;
            txtCategory.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCategory.Hint = "Categoría";
            txtCategory.LeadingIcon = null;
            txtCategory.Location = new Point(37, 145);
            txtCategory.MaxLength = 50;
            txtCategory.MouseState = MaterialSkin.MouseState.OUT;
            txtCategory.Multiline = false;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(264, 50);
            txtCategory.TabIndex = 2;
            txtCategory.Text = "";
            txtCategory.TrailingIcon = null;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitle.Location = new Point(37, 9);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 19);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "materialLabel1";
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(71, 204);
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
            btnSave.Click += SaveOnClick;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(167, 204);
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
            btnCancel.Click += CancelOnClick;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblTitle);
            materialCard1.Controls.Add(btnCancel);
            materialCard1.Controls.Add(txtName);
            materialCard1.Controls.Add(btnSave);
            materialCard1.Controls.Add(txtDescription);
            materialCard1.Controls.Add(txtCategory);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(9, 5);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(339, 253);
            materialCard1.TabIndex = 6;
            // 
            // BrandsDetailsView
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 266);
            Controls.Add(materialCard1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BrandsDetailsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrandsDetails";
            Load += BrandsDateilsOnLoad;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtDescription;
        private MaterialSkin.Controls.MaterialTextBox txtCategory;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private ErrorProvider errorProvider;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}