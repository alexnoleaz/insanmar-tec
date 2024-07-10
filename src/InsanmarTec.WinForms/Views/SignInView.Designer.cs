namespace InsanmarTec.WinForms.Views
{
    partial class SignInView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            signInCard = new MaterialSkin.Controls.MaterialCard();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            btnSignIn = new MaterialSkin.Controls.MaterialButton();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            errorProvider = new ErrorProvider(components);
            lblMessage = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            signInCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 280);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.insanmar_logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // signInCard
            // 
            signInCard.BackColor = Color.FromArgb(255, 255, 255);
            signInCard.Controls.Add(txtPassword);
            signInCard.Controls.Add(txtUsername);
            signInCard.Controls.Add(btnSignIn);
            signInCard.Depth = 0;
            signInCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            signInCard.Location = new Point(230, 61);
            signInCard.Margin = new Padding(14);
            signInCard.MouseState = MaterialSkin.MouseState.HOVER;
            signInCard.Name = "signInCard";
            signInCard.Padding = new Padding(14);
            signInCard.Size = new Size(329, 201);
            signInCard.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Contraseña";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(41, 88);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(251, 50);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            txtPassword.UseAccent = false;
            // 
            // txtUsername
            // 
            txtUsername.AnimateReadOnly = false;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.Hint = "Nombre de usuario";
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(41, 23);
            txtUsername.MaxLength = 50;
            txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(251, 50);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "";
            txtUsername.TrailingIcon = null;
            txtUsername.UseAccent = false;
            // 
            // btnSignIn
            // 
            btnSignIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSignIn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnSignIn.Depth = 0;
            btnSignIn.HighEmphasis = true;
            btnSignIn.Icon = null;
            btnSignIn.Location = new Point(106, 146);
            btnSignIn.Margin = new Padding(4, 6, 4, 6);
            btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            btnSignIn.Name = "btnSignIn";
            btnSignIn.NoAccentTextColor = Color.Empty;
            btnSignIn.Size = new Size(128, 36);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Iniciar sesión";
            btnSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSignIn.UseAccentColor = false;
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += SignInOnClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblTitle.Location = new Point(234, 20);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(323, 29);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Iniciar Sesión en InsanmarTec";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(244, 42);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 16);
            lblMessage.TabIndex = 6;
            // 
            // SignInView
            // 
            AcceptButton = btnSignIn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 280);
            Controls.Add(lblMessage);
            Controls.Add(lblTitle);
            Controls.Add(signInCard);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignInView";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsanmarTec - Iniciar sesión";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            signInCard.ResumeLayout(false);
            signInCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard signInCard;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private ErrorProvider errorProvider;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private Label lblMessage;
    }
}