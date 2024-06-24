namespace InsanmarTec.WinForms.Views
{
    partial class ProductSalesDetails
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
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            txtProductCode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.BackColor = SystemColors.InactiveCaption;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(11, 299);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(88, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.BackColor = SystemColors.InactiveCaption;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(169, 299);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(96, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancel.UseAccentColor = true;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtProductCode
            // 
            txtProductCode.AllowPromptAsInput = true;
            txtProductCode.AnimateReadOnly = false;
            txtProductCode.AsciiOnly = false;
            txtProductCode.BackgroundImageLayout = ImageLayout.None;
            txtProductCode.BeepOnError = false;
            txtProductCode.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtProductCode.Depth = 0;
            txtProductCode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProductCode.HidePromptOnLeave = false;
            txtProductCode.HideSelection = true;
            txtProductCode.Hint = "código de producto";
            txtProductCode.InsertKeyMode = InsertKeyMode.Default;
            txtProductCode.LeadingIcon = null;
            txtProductCode.Location = new Point(21, 62);
            txtProductCode.Margin = new Padding(3, 2, 3, 2);
            txtProductCode.Mask = "";
            txtProductCode.MaxLength = 32767;
            txtProductCode.MouseState = MaterialSkin.MouseState.OUT;
            txtProductCode.Name = "txtProductCode";
            txtProductCode.PasswordChar = '\0';
            txtProductCode.PrefixSuffixText = null;
            txtProductCode.PromptChar = '_';
            txtProductCode.ReadOnly = false;
            txtProductCode.RejectInputOnFirstFailure = false;
            txtProductCode.ResetOnPrompt = true;
            txtProductCode.ResetOnSpace = true;
            txtProductCode.RightToLeft = RightToLeft.No;
            txtProductCode.SelectedText = "";
            txtProductCode.SelectionLength = 0;
            txtProductCode.SelectionStart = 0;
            txtProductCode.ShortcutsEnabled = true;
            txtProductCode.Size = new Size(273, 48);
            txtProductCode.SkipLiterals = true;
            txtProductCode.TabIndex = 2;
            txtProductCode.TabStop = false;
            txtProductCode.TextAlign = HorizontalAlignment.Left;
            txtProductCode.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtProductCode.TrailingIcon = null;
            txtProductCode.UseSystemPasswordChar = false;
            txtProductCode.ValidatingType = null;
            // 
            // ProductSalesDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(620, 410);
            Controls.Add(txtProductCode);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductSalesDetails";
            Text = "ProductSalesDetails";
            Load += ProductSalesDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtProductCode;
    }
}