namespace InsanmarTec.WinForms.Views
{
    partial class InventoryView
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
            tcInventory = new TabControl();
            tpProducts = new TabPage();
            tpBrands = new TabPage();
            tpModels = new TabPage();
            tpQualities = new TabPage();
            tcInventory.SuspendLayout();
            SuspendLayout();
            // 
            // tcInventory
            // 
            tcInventory.Controls.Add(tpProducts);
            tcInventory.Controls.Add(tpBrands);
            tcInventory.Controls.Add(tpModels);
            tcInventory.Controls.Add(tpQualities);
            tcInventory.Dock = DockStyle.Fill;
            tcInventory.Location = new Point(3, 0);
            tcInventory.Name = "tcInventory";
            tcInventory.SelectedIndex = 0;
            tcInventory.Size = new Size(794, 447);
            tcInventory.TabIndex = 0;
            tcInventory.SelectedIndexChanged += TCInventorySelectedIndexChagend;
            // 
            // tpProducts
            // 
            tpProducts.Location = new Point(4, 24);
            tpProducts.Name = "tpProducts";
            tpProducts.Padding = new Padding(3);
            tpProducts.Size = new Size(786, 419);
            tpProducts.TabIndex = 0;
            tpProducts.Text = "Productos";
            tpProducts.UseVisualStyleBackColor = true;
            // 
            // tpBrands
            // 
            tpBrands.Location = new Point(4, 24);
            tpBrands.Name = "tpBrands";
            tpBrands.Padding = new Padding(3);
            tpBrands.Size = new Size(786, 419);
            tpBrands.TabIndex = 1;
            tpBrands.Text = "Marcas";
            tpBrands.UseVisualStyleBackColor = true;
            // 
            // tpModels
            // 
            tpModels.Location = new Point(4, 24);
            tpModels.Name = "tpModels";
            tpModels.Size = new Size(786, 419);
            tpModels.TabIndex = 2;
            tpModels.Text = "Modelos";
            tpModels.UseVisualStyleBackColor = true;
            // 
            // tpQualities
            // 
            tpQualities.Location = new Point(4, 24);
            tpQualities.Name = "tpQualities";
            tpQualities.Size = new Size(786, 419);
            tpQualities.TabIndex = 3;
            tpQualities.Text = "Calidades";
            tpQualities.UseVisualStyleBackColor = true;
            // 
            // InventoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcInventory);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "InventoryView";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Inventario";
            tcInventory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcInventory;
        private TabPage tpProducts;
        private TabPage tpBrands;
        private TabPage tpModels;
        private TabPage tpQualities;
    }
}