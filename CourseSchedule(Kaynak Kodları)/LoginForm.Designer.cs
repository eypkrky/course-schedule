namespace CourseSchedule
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnAdmin = new Button();
            btnStudent = new Button();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(45, 45, 48);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderSize = 2;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 10F);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(286, 156);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(212, 38);
            btnAdmin.TabIndex = 9;
            btnAdmin.Text = "Admin Login";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.FromArgb(45, 45, 48);
            btnStudent.Cursor = Cursors.Hand;
            btnStudent.FlatAppearance.BorderSize = 2;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI", 10F);
            btnStudent.ForeColor = Color.White;
            btnStudent.Location = new Point(286, 233);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(212, 38);
            btnStudent.TabIndex = 8;
            btnStudent.Text = "Student Login";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnStudent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Style = MetroFramework.MetroColorStyle.White;
            Text = "Login Form";
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdmin;
        private Button btnStudent;
    }
}