namespace InsanmarTec.WinForms.Views
{
    partial class SalesMainView
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
            tpSales = new TabPage();
            tpExitNotes = new TabPage();
            tpCustomers = new TabPage();
            tcPurchases.SuspendLayout();
            SuspendLayout();
            // 
            // tcPurchases
            // 
            tcPurchases.Controls.Add(tpSales);
            tcPurchases.Controls.Add(tpExitNotes);
            tcPurchases.Controls.Add(tpCustomers);
            tcPurchases.Dock = DockStyle.Fill;
            tcPurchases.Location = new Point(3, 0);
            tcPurchases.Name = "tcPurchases";
            tcPurchases.SelectedIndex = 0;
            tcPurchases.Size = new Size(794, 447);
            tcPurchases.TabIndex = 2;
            tcPurchases.SelectedIndexChanged += TCSalesOnSelectedIndexChagend;
            // 
            // tpSales
            // 
            tpSales.Location = new Point(4, 24);
            tpSales.Name = "tpSales";
            tpSales.Padding = new Padding(3);
            tpSales.Size = new Size(786, 419);
            tpSales.TabIndex = 1;
            tpSales.Text = "Ventas";
            tpSales.UseVisualStyleBackColor = true;
            // 
            // tpExitNotes
            // 
            tpExitNotes.Location = new Point(4, 24);
            tpExitNotes.Name = "tpExitNotes";
            tpExitNotes.Size = new Size(786, 419);
            tpExitNotes.TabIndex = 2;
            tpExitNotes.Text = "Notas de Salida";
            tpExitNotes.UseVisualStyleBackColor = true;
            // 
            // tpCustomers
            // 
            tpCustomers.Location = new Point(4, 24);
            tpCustomers.Name = "tpCustomers";
            tpCustomers.Size = new Size(786, 419);
            tpCustomers.TabIndex = 3;
            tpCustomers.Text = "Clientes";
            tpCustomers.UseVisualStyleBackColor = true;
            // 
            // SalesMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcPurchases);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "SalesMainView";
            Padding = new Padding(3, 0, 3, 3);
            Text = "SalesView";
            Load += SalesMainViewOnLoad;
            tcPurchases.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcPurchases;
        private TabPage tpSales;
        private TabPage tpExitNotes;
        private TabPage tpCustomers;
    }
}