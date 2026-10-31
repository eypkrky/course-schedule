namespace CourseSchedule
{
    partial class LessonsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            DepartmentCombo = new ComboBox();
            Duration = new TextBox();
            label3 = new Label();
            CreditNumberic = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            Delete_Button = new Button();
            Update_Button = new Button();
            Add_Button = new Button();
            LessonCombo = new ComboBox();
            label6 = new Label();
            LessonName = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)CreditNumberic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 270);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 38;
            label5.Text = "Department";
            // 
            // DepartmentCombo
            // 
            DepartmentCombo.FormattingEnabled = true;
            DepartmentCombo.Location = new Point(11, 293);
            DepartmentCombo.Name = "DepartmentCombo";
            DepartmentCombo.Size = new Size(149, 28);
            DepartmentCombo.TabIndex = 28;
            // 
            // Duration
            // 
            Duration.Location = new Point(11, 130);
            Duration.Name = "Duration";
            Duration.Size = new Size(149, 27);
            Duration.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 160);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 37;
            label3.Text = "Credit";
            // 
            // CreditNumberic
            // 
            CreditNumberic.Location = new Point(11, 183);
            CreditNumberic.Name = "CreditNumberic";
            CreditNumberic.Size = new Size(150, 27);
            CreditNumberic.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 106);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 36;
            label4.Text = "Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 216);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 35;
            label2.Text = "Lesson Type";
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(45, 45, 48);
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Segoe UI", 10F);
            Delete_Button.ForeColor = Color.White;
            Delete_Button.Location = new Point(11, 471);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(150, 41);
            Delete_Button.TabIndex = 32;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // Update_Button
            // 
            Update_Button.BackColor = Color.FromArgb(45, 45, 48);
            Update_Button.FlatStyle = FlatStyle.Flat;
            Update_Button.Font = new Font("Segoe UI", 10F);
            Update_Button.ForeColor = Color.White;
            Update_Button.Location = new Point(11, 412);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(150, 41);
            Update_Button.TabIndex = 31;
            Update_Button.Text = "Update";
            Update_Button.UseVisualStyleBackColor = false;
            Update_Button.Click += Update_Button_Click;
            // 
            // Add_Button
            // 
            Add_Button.BackColor = Color.FromArgb(45, 45, 48);
            Add_Button.FlatStyle = FlatStyle.Flat;
            Add_Button.Font = new Font("Segoe UI", 10F);
            Add_Button.ForeColor = Color.White;
            Add_Button.Location = new Point(11, 353);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(150, 41);
            Add_Button.TabIndex = 30;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // LessonCombo
            // 
            LessonCombo.FormattingEnabled = true;
            LessonCombo.Items.AddRange(new object[] { "Mandatory", "Elective" });
            LessonCombo.Location = new Point(11, 239);
            LessonCombo.Name = "LessonCombo";
            LessonCombo.Size = new Size(149, 28);
            LessonCombo.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(-2, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 35);
            label6.TabIndex = 39;
            label6.Text = "Lessons";
            // 
            // LessonName
            // 
            LessonName.Location = new Point(11, 76);
            LessonName.Name = "LessonName";
            LessonName.Size = new Size(149, 27);
            LessonName.TabIndex = 29;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(183, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 634);
            dataGridView1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 50);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 34;
            label1.Text = "Lesson Name";
            // 
            // LessonsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 0);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DepartmentCombo);
            Controls.Add(Duration);
            Controls.Add(label3);
            Controls.Add(CreditNumberic);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Delete_Button);
            Controls.Add(Update_Button);
            Controls.Add(Add_Button);
            Controls.Add(LessonCombo);
            Controls.Add(LessonName);
            Name = "LessonsControl";
            Size = new Size(1033, 720);
            Load += LessonsControl_Load;
            ((System.ComponentModel.ISupportInitialize)CreditNumberic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox DepartmentCombo;
        private TextBox Duration;
        private Label label3;
        private NumericUpDown CreditNumberic;
        private Label label4;
        private Label label2;
        private Button Delete_Button;
        private Button Update_Button;
        private Button Add_Button;
        private ComboBox LessonCombo;
        private Label label6;
        private TextBox LessonName;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
