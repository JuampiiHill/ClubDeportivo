namespace ClubDeportivo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            lblWelcome = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(46, 269);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(76, 32);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = SystemColors.GradientInactiveCaption;
            lblWelcome.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(46, 62);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(111, 36);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Bienvenido";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.GradientInactiveCaption;
            lblUser.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(46, 138);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(52, 22);
            lblUser.TabIndex = 2;
            lblUser.Text = "Usuario";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.ControlText;
            txtUser.Location = new Point(46, 163);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(129, 29);
            txtUser.TabIndex = 3;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = SystemColors.GradientInactiveCaption;
            lblPass.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(46, 195);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(71, 22);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = SystemColors.ControlText;
            txtPass.Location = new Point(46, 220);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(129, 29);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(587, 341);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblWelcome;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblPass;
        private TextBox txtPass;
    }
}
