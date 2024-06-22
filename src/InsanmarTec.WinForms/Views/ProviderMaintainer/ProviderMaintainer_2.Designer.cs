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
            richTextBox1 = new RichTextBox();
            txbBus = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 106);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(583, 276);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // txbBus
            // 
            txbBus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbBus.Location = new Point(126, 46);
            txbBus.Name = "txbBus";
            txbBus.Size = new Size(311, 25);
            txbBus.TabIndex = 4;
            txbBus.Text = "Ingrese el codigo a buscar";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(459, 25);
            button1.Name = "button1";
            button1.Size = new Size(136, 66);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // ProviderMaintainer_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(620, 410);
            Controls.Add(button1);
            Controls.Add(txbBus);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderMaintainer_2";
            Text = "ProviderMaintainer_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox txbBus;
        private Button button1;
    }
}