namespace InsanmarTec.WinForms.buys
{
    partial class PurchaseOrderDetailsView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnFinish = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            dgvPurchaseOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOrder).BeginInit();
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
            btnAdd.Location = new Point(86, 401);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 36);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Agregar";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnFinish
            // 
            btnFinish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinish.BackColor = Color.FromArgb(8, 86, 207);
            btnFinish.Cursor = Cursors.Hand;
            btnFinish.FlatAppearance.BorderSize = 0;
            btnFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 60, 140);
            btnFinish.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 100, 190);
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinish.ForeColor = Color.White;
            btnFinish.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnFinish.IconColor = Color.White;
            btnFinish.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinish.IconSize = 32;
            btnFinish.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinish.Location = new Point(302, 401);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(109, 36);
            btnFinish.TabIndex = 12;
            btnFinish.Text = "Finalizar ";
            btnFinish.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(8, 86, 207);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 60, 140);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 100, 190);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.White;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 32;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(424, 401);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancelar";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(308, 27);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(225, 343);
            materialListView1.TabIndex = 14;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // dgvPurchaseOrder
            // 
            dgvPurchaseOrder.AllowUserToAddRows = false;
            dgvPurchaseOrder.AllowUserToDeleteRows = false;
            dgvPurchaseOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPurchaseOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchaseOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPurchaseOrder.BackgroundColor = Color.White;
            dgvPurchaseOrder.BorderStyle = BorderStyle.None;
            dgvPurchaseOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPurchaseOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 45, 85);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(8, 86, 207);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPurchaseOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPurchaseOrder.ColumnHeadersHeight = 30;
            dgvPurchaseOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPurchaseOrder.EnableHeadersVisualStyles = false;
            dgvPurchaseOrder.GridColor = Color.FromArgb(20, 45, 85);
            dgvPurchaseOrder.Location = new Point(6, 30);
            dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            dgvPurchaseOrder.ReadOnly = true;
            dgvPurchaseOrder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPurchaseOrder.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(20, 45, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(8, 86, 207);
            dgvPurchaseOrder.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPurchaseOrder.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvPurchaseOrder.Size = new Size(285, 340);
            dgvPurchaseOrder.TabIndex = 15;
            // 
            // PurchaseOrderDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 458);
            Controls.Add(dgvPurchaseOrder);
            Controls.Add(materialListView1);
            Controls.Add(btnCancel);
            Controls.Add(btnFinish);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PurchaseOrderDetailsView";
            Padding = new Padding(3, 0, 3, 3);
            Text = "NoteEntryView";
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnFinish;
        private FontAwesome.Sharp.IconButton btnCancel;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private DataGridView dgvPurchaseOrder;
    }
}