namespace InsanmarTec.WinForms.Notes
{
    partial class EntryNotesView
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            dgvEntryNotes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEntryNotes).BeginInit();
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
            btnAdd.TabIndex = 17;
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
            btnSearch.TabIndex = 16;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.AnimateReadOnly = false;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.Hint = "Buscar nota de entrada por código...";
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(6, 8);
            txtSearch.MaxLength = 50;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(391, 36);
            txtSearch.TabIndex = 15;
            txtSearch.Text = "";
            txtSearch.TrailingIcon = null;
            txtSearch.UseTallSize = false;
            // 
            // dgvEntryNotes
            // 
            dgvEntryNotes.AllowUserToAddRows = false;
            dgvEntryNotes.AllowUserToDeleteRows = false;
            dgvEntryNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEntryNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntryNotes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEntryNotes.BackgroundColor = Color.White;
            dgvEntryNotes.BorderStyle = BorderStyle.None;
            dgvEntryNotes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEntryNotes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(20, 45, 85);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(8, 86, 207);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEntryNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEntryNotes.ColumnHeadersHeight = 30;
            dgvEntryNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEntryNotes.EnableHeadersVisualStyles = false;
            dgvEntryNotes.GridColor = Color.FromArgb(20, 45, 85);
            dgvEntryNotes.Location = new Point(6, 52);
            dgvEntryNotes.Name = "dgvEntryNotes";
            dgvEntryNotes.ReadOnly = true;
            dgvEntryNotes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEntryNotes.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(20, 45, 85);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(8, 86, 207);
            dgvEntryNotes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvEntryNotes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvEntryNotes.Size = new Size(545, 398);
            dgvEntryNotes.TabIndex = 14;
            // 
            // EntryNotesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 458);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvEntryNotes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EntryNotesView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EntryNotesView";
            ((System.ComponentModel.ISupportInitialize)dgvEntryNotes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private DataGridView dgvEntryNotes;
    }
}