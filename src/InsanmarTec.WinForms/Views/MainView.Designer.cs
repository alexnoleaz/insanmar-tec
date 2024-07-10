namespace InsanmarTec.WinForms.Views
{
    partial class MainView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            tcMain = new MaterialSkin.Controls.MaterialTabControl();
            tpSales = new TabPage();
            tpPurchases = new TabPage();
            tpInventory = new TabPage();
            tpSettings = new TabPage();
            imageListNavBar = new ImageList(components);
            statusBar = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblUser = new ToolStripStatusLabel();
            tcMain.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tpSales);
            tcMain.Controls.Add(tpPurchases);
            tcMain.Controls.Add(tpInventory);
            tcMain.Controls.Add(tpSettings);
            tcMain.Depth = 0;
            tcMain.Dock = DockStyle.Fill;
            tcMain.ImageList = imageListNavBar;
            tcMain.Location = new Point(0, 64);
            tcMain.Margin = new Padding(3, 2, 3, 2);
            tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            tcMain.Multiline = true;
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(988, 518);
            tcMain.TabIndex = 0;
            tcMain.SelectedIndexChanged += TCMainOnSelectedIndexChanged;
            // 
            // tpSales
            // 
            tpSales.ImageKey = "sales.png";
            tpSales.Location = new Point(4, 39);
            tpSales.Margin = new Padding(3, 2, 3, 2);
            tpSales.Name = "tpSales";
            tpSales.Padding = new Padding(3, 2, 3, 2);
            tpSales.Size = new Size(980, 475);
            tpSales.TabIndex = 0;
            tpSales.Text = "Ventas";
            tpSales.UseVisualStyleBackColor = true;
            // 
            // tpPurchases
            // 
            tpPurchases.ImageKey = "purchase.png";
            tpPurchases.Location = new Point(4, 39);
            tpPurchases.Margin = new Padding(3, 2, 3, 2);
            tpPurchases.Name = "tpPurchases";
            tpPurchases.Size = new Size(699, 358);
            tpPurchases.TabIndex = 2;
            tpPurchases.Text = "Compras";
            tpPurchases.UseVisualStyleBackColor = true;
            // 
            // tpInventory
            // 
            tpInventory.ImageKey = "inventory.png";
            tpInventory.Location = new Point(4, 39);
            tpInventory.Margin = new Padding(3, 2, 3, 2);
            tpInventory.Name = "tpInventory";
            tpInventory.Padding = new Padding(3, 2, 3, 2);
            tpInventory.Size = new Size(699, 358);
            tpInventory.TabIndex = 1;
            tpInventory.Text = "Inventario";
            tpInventory.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            tpSettings.ImageKey = "settings.png";
            tpSettings.Location = new Point(4, 39);
            tpSettings.Margin = new Padding(3, 2, 3, 2);
            tpSettings.Name = "tpSettings";
            tpSettings.Padding = new Padding(3, 2, 3, 2);
            tpSettings.Size = new Size(699, 358);
            tpSettings.TabIndex = 3;
            tpSettings.Text = "Ajustes";
            tpSettings.UseVisualStyleBackColor = true;
            // 
            // imageListNavBar
            // 
            imageListNavBar.ColorDepth = ColorDepth.Depth32Bit;
            imageListNavBar.ImageStream = (ImageListStreamer)resources.GetObject("imageListNavBar.ImageStream");
            imageListNavBar.TransparentColor = Color.Transparent;
            imageListNavBar.Images.SetKeyName(0, "settings.png");
            imageListNavBar.Images.SetKeyName(1, "purchase.png");
            imageListNavBar.Images.SetKeyName(2, "sales.png");
            imageListNavBar.Images.SetKeyName(3, "inventory.png");
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblUser });
            statusBar.Location = new Point(0, 560);
            statusBar.Name = "statusBar";
            statusBar.Padding = new Padding(1, 0, 12, 0);
            statusBar.RenderMode = ToolStripRenderMode.Professional;
            statusBar.Size = new Size(988, 22);
            statusBar.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(53, 17);
            lblUser.Text = "Usuario: ";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 584);
            Controls.Add(statusBar);
            Controls.Add(tcMain);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcMain;
            DrawerWidth = 170;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainView";
            Padding = new Padding(0, 64, 3, 2);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
            FormClosing += MainFormOnClosing;
            Load += MainViewOnLoad;
            tcMain.ResumeLayout(false);
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcMain;
        private TabPage tpSales;
        private TabPage tpInventory;
        private TabPage tpPurchases;
        private TabPage tpSettings;
        private StatusStrip statusBar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ImageList imageListNavBar;
        private ToolStripStatusLabel lblUser;
    }
}