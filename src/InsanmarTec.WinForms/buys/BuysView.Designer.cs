namespace InsanmarTec.WinForms.buys
{
    partial class BuysView
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
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            dgvBuys = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBuys).BeginInit();
            SuspendLayout();
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
            btnSearch.Location = new Point(510, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(41, 36);
            btnSearch.TabIndex = 11;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.AnimateReadOnly = false;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.Hint = "Buscar compra por codigo...";
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(6, 12);
            txtSearch.MaxLength = 50;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(508, 36);
            txtSearch.TabIndex = 10;
            txtSearch.Text = "";
            txtSearch.TrailingIcon = null;
            txtSearch.UseTallSize = false;
            // 
            // dgvBuys
            // 
            dgvBuys.AllowUserToAddRows = false;
            dgvBuys.AllowUserToDeleteRows = false;
            dgvBuys.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBuys.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuys.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBuys.BackgroundColor = Color.White;
            dgvBuys.BorderStyle = BorderStyle.None;
            dgvBuys.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBuys.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(20, 45, 85);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(8, 86, 207);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBuys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBuys.ColumnHeadersHeight = 30;
            dgvBuys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBuys.EnableHeadersVisualStyles = false;
            dgvBuys.GridColor = Color.FromArgb(20, 45, 85);
            dgvBuys.Location = new Point(6, 56);
            dgvBuys.Name = "dgvBuys";
            dgvBuys.ReadOnly = true;
            dgvBuys.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBuys.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(20, 45, 85);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(8, 86, 207);
            dgvBuys.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBuys.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvBuys.Size = new Size(545, 398);
            dgvBuys.TabIndex = 9;
            // 
            // BuysView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 458);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvBuys);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuysView";
            Text = "BuysView";
            ((System.ComponentModel.ISupportInitialize)dgvBuys).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private DataGridView dgvBuys;
    }
}