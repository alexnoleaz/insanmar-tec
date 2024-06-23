namespace InsanmarTec.WinForms.Views.ProviderMaintainer
{
    partial class ProviderMaintainer_2
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
            txbBus = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txbBus
            // 
            txbBus.Font = new Font("Lucida Fax", 11.25F);
            txbBus.Location = new Point(125, 28);
            txbBus.Name = "txbBus";
            txbBus.Size = new Size(311, 25);
            txbBus.TabIndex = 4;
            txbBus.Text = "Ingrese el codigo a buscar";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Lucida Fax", 11.25F);
            button1.Location = new Point(453, 6);
            button1.Name = "button1";
            button1.Size = new Size(136, 66);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(568, 304);
            dataGridView1.TabIndex = 6;
            // 
            // ProviderMaintainer_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(620, 410);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txbBus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderMaintainer_2";
            Text = "ProviderMaintainer_2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbBus;
        private Button button1;
        private DataGridView dataGridView1;
    }
}