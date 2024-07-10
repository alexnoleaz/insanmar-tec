namespace InsanmarTec.WinForms.Qualily
{
    partial class QualityView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            dgvQuality = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvQuality).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(8, 86, 207);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 60, 140);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 100, 190);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 32;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(442, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 36);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Agregar";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(75, 146, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 120, 215);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 166, 255);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 32;
            btnSearch.Location = new Point(395, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(41, 36);
            btnSearch.TabIndex = 12;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.AnimateReadOnly = false;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.Hint = "Buscar calidad por nombre...";
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(6, 8);
            txtSearch.MaxLength = 50;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(391, 36);
            txtSearch.TabIndex = 11;
            txtSearch.Text = "";
            txtSearch.TrailingIcon = null;
            txtSearch.UseTallSize = false;
            // 
            // dgvQuality
            // 
            dgvQuality.AllowUserToAddRows = false;
            dgvQuality.AllowUserToDeleteRows = false;
            dgvQuality.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQuality.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuality.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvQuality.BackgroundColor = Color.White;
            dgvQuality.BorderStyle = BorderStyle.None;
            dgvQuality.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvQuality.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(20, 45, 85);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(8, 86, 207);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvQuality.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvQuality.ColumnHeadersHeight = 30;
            dgvQuality.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvQuality.EnableHeadersVisualStyles = false;
            dgvQuality.GridColor = Color.FromArgb(20, 45, 85);
            dgvQuality.Location = new Point(6, 52);
            dgvQuality.Name = "dgvQuality";
            dgvQuality.ReadOnly = true;
            dgvQuality.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvQuality.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(20, 45, 85);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(8, 86, 207);
            dgvQuality.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvQuality.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvQuality.Size = new Size(545, 398);
            dgvQuality.TabIndex = 10;
            // 
            // QualityView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 458);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvQuality);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QualityView";
            Padding = new Padding(3, 0, 3, 3);
            Text = "QualityView";
            ((System.ComponentModel.ISupportInitialize)dgvQuality).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private DataGridView dgvQuality;
    }
}