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
            imageListNavBar = new ImageList(components);
            statusBar = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblUser = new ToolStripStatusLabel();
            tpSettings = new TabPage();
            tpInventory = new TabPage();
            tpPurchases = new TabPage();
            tpSales = new TabPage();
            tcMain = new MaterialSkin.Controls.MaterialTabControl();
            statusBar.SuspendLayout();
            tcMain.SuspendLayout();
            SuspendLayout();
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
            imageListNavBar.Images.SetKeyName(4, "money.jpg");
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblUser });
            statusBar.Location = new Point(0, 750);
            statusBar.Name = "statusBar";
            statusBar.RenderMode = ToolStripRenderMode.Professional;
            statusBar.Size = new Size(1130, 26);
            statusBar.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 20);
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(66, 20);
            lblUser.Text = "Usuario: ";
            // 
            // tpSettings
            // 
            tpSettings.ImageKey = "settings.png";
            tpSettings.Location = new Point(4, 39);
            tpSettings.Name = "tpSettings";
            tpSettings.Padding = new Padding(3);
            tpSettings.Size = new Size(1122, 648);
            tpSettings.TabIndex = 3;
            tpSettings.Text = "Ajustes";
            tpSettings.UseVisualStyleBackColor = true;
            // 
            // tpInventory
            // 
            tpInventory.ImageKey = "inventory.png";
            tpInventory.Location = new Point(4, 39);
            tpInventory.Name = "tpInventory";
            tpInventory.Padding = new Padding(3);
            tpInventory.Size = new Size(1122, 648);
            tpInventory.TabIndex = 1;
            tpInventory.Text = "Inventario";
            tpInventory.UseVisualStyleBackColor = true;
            // 
            // tpPurchases
            // 
            tpPurchases.ImageKey = "purchase.png";
            tpPurchases.Location = new Point(4, 39);
            tpPurchases.Name = "tpPurchases";
            tpPurchases.Size = new Size(1122, 648);
            tpPurchases.TabIndex = 2;
            tpPurchases.Text = "Compras";
            tpPurchases.UseVisualStyleBackColor = true;
            // 
            // tpSales
            // 
            tpSales.ImageKey = "sales.png";
            tpSales.Location = new Point(4, 39);
            tpSales.Name = "tpSales";
            tpSales.Padding = new Padding(3);
            tpSales.Size = new Size(1122, 648);
            tpSales.TabIndex = 0;
            tpSales.Text = "Ventas";
            tpSales.UseVisualStyleBackColor = true;
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
            tcMain.Location = new Point(0, 85);
            tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            tcMain.Multiline = true;
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(1130, 691);
            tcMain.TabIndex = 0;
            tcMain.SelectedIndexChanged += TCMainOnSelectedIndexChanged;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 779);
            Controls.Add(statusBar);
            Controls.Add(tcMain);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcMain;
            DrawerWidth = 170;
            MaximizeBox = false;
            Name = "MainView";
            Padding = new Padding(0, 85, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
            FormClosing += MainFormOnClosing;
            Load += MainViewOnLoad;
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            tcMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusBar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ImageList imageListNavBar;
        private ToolStripStatusLabel lblUser;
        private TabPage tpSettings;
        private TabPage tpInventory;
        private TabPage tpPurchases;
        private TabPage tpSales;
        private MaterialSkin.Controls.MaterialTabControl tcMain;
    }
}