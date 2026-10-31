namespace CourseSchedule
{
    partial class ManualAssignForm
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
            label2 = new Label();
            cbLessons = new ComboBox();
            label1 = new Label();
            cbTeachers = new ComboBox();
            label3 = new Label();
            cbClassrooms = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 60);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 39;
            label2.Text = "Lesson";
            // 
            // cbLessons
            // 
            cbLessons.FormattingEnabled = true;
            cbLessons.Items.AddRange(new object[] { "Mandatory", "Elective" });
            cbLessons.Location = new Point(10, 83);
            cbLessons.Name = "cbLessons";
            cbLessons.Size = new Size(149, 28);
            cbLessons.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 126);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 41;
            label1.Text = "Teacher";
            // 
            // cbTeachers
            // 
            cbTeachers.FormattingEnabled = true;
            cbTeachers.Items.AddRange(new object[] { "Mandatory", "Elective" });
            cbTeachers.Location = new Point(10, 149);
            cbTeachers.Name = "cbTeachers";
            cbTeachers.Size = new Size(149, 28);
            cbTeachers.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 192);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 43;
            label3.Text = "Classroom";
            // 
            // cbClassrooms
            // 
            cbClassrooms.FormattingEnabled = true;
            cbClassrooms.Items.AddRange(new object[] { "Mandatory", "Elective" });
            cbClassrooms.Location = new Point(10, 215);
            cbClassrooms.Name = "cbClassrooms";
            cbClassrooms.Size = new Size(149, 28);
            cbClassrooms.TabIndex = 42;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(45, 45, 48);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(185, 139);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 44);
            btnSave.TabIndex = 44;
            btnSave.Text = "Save Schedule";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // ManualAssignForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 253);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(cbClassrooms);
            Controls.Add(label1);
            Controls.Add(cbTeachers);
            Controls.Add(label2);
            Controls.Add(cbLessons);
            Name = "ManualAssignForm";
            Style = MetroFramework.MetroColorStyle.White;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cbLessons;
        private Label label1;
        private ComboBox cbTeachers;
        private Label label3;
        private ComboBox cbClassrooms;
        private Button btnSave;
    }
}