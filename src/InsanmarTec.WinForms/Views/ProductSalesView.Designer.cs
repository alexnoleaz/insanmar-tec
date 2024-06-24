namespace InsanmarTec.WinForms.Views
{
    partial class ProductSalesView
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
            dataGridView1 = new DataGridView();
            btnCreate = new Button();
            btnDeactivate = new Button();
            btnUpdate = new Button();
            txtSearch = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(380, 219);
            dataGridView1.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.InactiveCaption;
            btnCreate.Font = new Font("Lucida Fax", 11.25F);
            btnCreate.Location = new Point(416, 106);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(140, 27);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = SystemColors.InactiveCaption;
            btnDeactivate.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeactivate.Location = new Point(416, 198);
            btnDeactivate.Margin = new Padding(3, 2, 3, 2);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(140, 27);
            btnDeactivate.TabIndex = 2;
            btnDeactivate.Text = "Inhabilitar";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.InactiveCaption;
            btnUpdate.Font = new Font("Lucida Fax", 11.25F);
            btnUpdate.Location = new Point(416, 290);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 25);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Editar";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.AllowPromptAsInput = true;
            txtSearch.AnimateReadOnly = false;
            txtSearch.AsciiOnly = false;
            txtSearch.BackgroundImageLayout = ImageLayout.None;
            txtSearch.BeepOnError = false;
            txtSearch.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.HidePromptOnLeave = false;
            txtSearch.HideSelection = true;
            txtSearch.Hint = "Buscar venta producto...";
            txtSearch.InsertKeyMode = InsertKeyMode.Default;
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(10, 30);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Mask = "";
            txtSearch.MaxLength = 32767;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PrefixSuffixText = null;
            txtSearch.PromptChar = '_';
            txtSearch.ReadOnly = false;
            txtSearch.RejectInputOnFirstFailure = false;
            txtSearch.ResetOnPrompt = true;
            txtSearch.ResetOnSpace = true;
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(405, 48);
            txtSearch.SkipLiterals = true;
            txtSearch.TabIndex = 4;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSearch.TrailingIcon = null;
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.ValidatingType = null;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.InactiveCaption;
            btnSearch.Font = new Font("Lucida Fax", 11.25F);
            btnSearch.Location = new Point(443, 42);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 36);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // ProductSalesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(620, 410);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDeactivate);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductSalesView";
            Text = "ProductSalesView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCreate;
        private Button btnDeactivate;
        private Button btnUpdate;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearch;
        private Button btnSearch;
    }
}