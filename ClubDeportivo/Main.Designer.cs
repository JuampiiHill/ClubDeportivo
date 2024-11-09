namespace ClubDeportivo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnNewMember = new Button();
            btnActivities = new Button();
            MemberList = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnNewMember
            // 
            btnNewMember.BackColor = SystemColors.ScrollBar;
            btnNewMember.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewMember.Location = new Point(79, 167);
            btnNewMember.Name = "btnNewMember";
            btnNewMember.Size = new Size(160, 78);
            btnNewMember.TabIndex = 0;
            btnNewMember.Text = "Inscribir Socio";
            btnNewMember.UseVisualStyleBackColor = false;
            btnNewMember.Click += btnNewMember_Click;
            // 
            // btnActivities
            // 
            btnActivities.BackColor = Color.LimeGreen;
            btnActivities.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActivities.Location = new Point(325, 167);
            btnActivities.Name = "btnActivities";
            btnActivities.Size = new Size(156, 78);
            btnActivities.TabIndex = 1;
            btnActivities.Text = "Asignar Activdad";
            btnActivities.UseVisualStyleBackColor = false;
            // 
            // MemberList
            // 
            MemberList.BackColor = Color.LimeGreen;
            MemberList.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MemberList.Location = new Point(560, 167);
            MemberList.Name = "MemberList";
            MemberList.Size = new Size(167, 78);
            MemberList.TabIndex = 2;
            MemberList.Text = "Estado de Socios";
            MemberList.UseVisualStyleBackColor = false;
            MemberList.Click += MemberList_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientInactiveCaption;
            btnExit.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(605, 396);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(77, 27);
            btnExit.TabIndex = 3;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(MemberList);
            Controls.Add(btnActivities);
            Controls.Add(btnNewMember);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewMember;
        private Button btnActivities;
        private Button MemberList;
        private Button btnExit;
    }
}