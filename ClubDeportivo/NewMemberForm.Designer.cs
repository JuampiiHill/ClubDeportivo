namespace ClubDeportivo
{
    partial class NewMemberForm
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
            btnRegister = new Button();
            lblName = new Label();
            lblLastName = new Label();
            lblDoc = new Label();
            lblBirth = new Label();
            lblEmail = new Label();
            cboGender = new ComboBox();
            lblGender = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtDocument = new TextBox();
            txtEmail = new TextBox();
            btnExit = new Button();
            btnClean = new Button();
            dtpBirth = new DateTimePicker();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(231, 285);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(83, 59);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(63, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 27);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(63, 120);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(65, 27);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Apellido";
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoc.Location = new Point(63, 175);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(87, 27);
            lblDoc.TabIndex = 3;
            lblDoc.Text = "Documento";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirth.Location = new Point(389, 120);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(146, 27);
            lblBirth.TabIndex = 4;
            lblBirth.Text = "Fecha de Nacimiento";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(389, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cboGender.Location = new Point(536, 70);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(197, 29);
            cboGender.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(389, 72);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(58, 27);
            lblGender.TabIndex = 7;
            lblGender.Text = "Género";
            // 
            // txtName
            // 
            txtName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(168, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 35);
            txtName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(167, 112);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(199, 35);
            txtLastName.TabIndex = 9;
            // 
            // txtDocument
            // 
            txtDocument.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocument.Location = new Point(168, 167);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(198, 35);
            txtDocument.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(536, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 35);
            txtEmail.TabIndex = 12;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(691, 405);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 33);
            btnExit.TabIndex = 13;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClean
            // 
            btnClean.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClean.Location = new Point(536, 285);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(83, 58);
            btnClean.TabIndex = 14;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // dtpBirth
            // 
            dtpBirth.CustomFormat = "yyyy-mm-dd";
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(536, 124);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 23);
            dtpBirth.TabIndex = 15;
            dtpBirth.ValueChanged += dtpBirth_ValueChanged;
            // 
            // NewMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpBirth);
            Controls.Add(btnClean);
            Controls.Add(btnExit);
            Controls.Add(txtEmail);
            Controls.Add(txtDocument);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(lblGender);
            Controls.Add(cboGender);
            Controls.Add(lblEmail);
            Controls.Add(lblBirth);
            Controls.Add(lblDoc);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(btnRegister);
            Name = "NewMemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label lblName;
        private Label lblLastName;
        private Label lblDoc;
        private Label lblBirth;
        private Label lblEmail;
        private ComboBox cboGender;
        private Label lblGender;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtDocument;
        private TextBox txtEmail;
        private Button btnExit;
        private Button btnClean;
        private DateTimePicker dtpBirth;
    }
}