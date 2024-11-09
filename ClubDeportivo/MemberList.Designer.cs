namespace ClubDeportivo
{
    partial class MemberList
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
            dtgvMember = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvMember).BeginInit();
            SuspendLayout();
            // 
            // dtgvMember
            // 
            dtgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMember.Location = new Point(55, 91);
            dtgvMember.Name = "dtgvMember";
            dtgvMember.Size = new Size(680, 290);
            dtgvMember.TabIndex = 0;
            dtgvMember.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Listado de Socios";
            label1.Click += label1_Click;
            // 
            // MemberList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dtgvMember);
            Name = "MemberList";
            Text = "MemberList";
            ((System.ComponentModel.ISupportInitialize)dtgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvMember;
        private Label label1;
    }
}