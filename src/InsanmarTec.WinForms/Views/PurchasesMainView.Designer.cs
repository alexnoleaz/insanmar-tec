namespace InsanmarTec.WinForms.Views
{
    partial class PurchasesMainView
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
            tcPurchases = new TabControl();
            tpPurchaseOrders = new TabPage();
            tpPurchases = new TabPage();
            tpEntryNotes = new TabPage();
            tcPurchases.SuspendLayout();
            SuspendLayout();
            // 
            // tcPurchases
            // 
            tcPurchases.Controls.Add(tpPurchaseOrders);
            tcPurchases.Controls.Add(tpPurchases);
            tcPurchases.Controls.Add(tpEntryNotes);
            tcPurchases.Dock = DockStyle.Fill;
            tcPurchases.Location = new Point(3, 0);
            tcPurchases.Name = "tcPurchases";
            tcPurchases.SelectedIndex = 0;
            tcPurchases.Size = new Size(794, 447);
            tcPurchases.TabIndex = 1;
            tcPurchases.SelectedIndexChanged += TCPurchasesOnSelectedIndexChanged;
            // 
            // tpPurchaseOrders
            // 
            tpPurchaseOrders.Location = new Point(4, 24);
            tpPurchaseOrders.Name = "tpPurchaseOrders";
            tpPurchaseOrders.Padding = new Padding(3);
            tpPurchaseOrders.Size = new Size(786, 419);
            tpPurchaseOrders.TabIndex = 0;
            tpPurchaseOrders.Text = "Órdenes de Compras";
            tpPurchaseOrders.UseVisualStyleBackColor = true;
            // 
            // tpPurchases
            // 
            tpPurchases.Location = new Point(4, 24);
            tpPurchases.Name = "tpPurchases";
            tpPurchases.Padding = new Padding(3);
            tpPurchases.Size = new Size(786, 419);
            tpPurchases.TabIndex = 1;
            tpPurchases.Text = "Compras";
            tpPurchases.UseVisualStyleBackColor = true;
            // 
            // tpEntryNotes
            // 
            tpEntryNotes.Location = new Point(4, 24);
            tpEntryNotes.Name = "tpEntryNotes";
            tpEntryNotes.Size = new Size(786, 419);
            tpEntryNotes.TabIndex = 2;
            tpEntryNotes.Text = "Notas de Entrada";
            tpEntryNotes.UseVisualStyleBackColor = true;
            // 
            // PurchasesMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcPurchases);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "PurchasesMainView";
            Padding = new Padding(3, 0, 3, 3);
            Text = "PurchasesView";
            Load += PurchasesMainViewOnLoad;
            tcPurchases.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcPurchases;
        private TabPage tpPurchaseOrders;
        private TabPage tpPurchases;
        private TabPage tpEntryNotes;
    }
}