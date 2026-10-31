namespace CourseSchedule
{
    partial class TeachresControl
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
            AssignedLessons = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            Delete_Button = new Button();
            Update_Button = new Button();
            Add_Button = new Button();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            dgvTeacherLessons = new DataGridView();
            label7 = new Label();
            btnAddTeacherLesson = new Button();
            btnDeleteTeacherLesson = new Button();
            label6 = new Label();
            cbLesson = new ComboBox();
            label5 = new Label();
            cbTeacher = new ComboBox();
            tabPage3 = new TabPage();
            dgvAvailability = new DataGridView();
            btnDeleteAvail = new Button();
            btnAddAvail = new Button();
            chkIsAvailable = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            cbAvailTeacher = new ComboBox();
            label8 = new Label();
            cbAvailHour = new ComboBox();
            label9 = new Label();
            cbAvailDay = new ComboBox();
            AssignedLessons.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeacherLessons).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailability).BeginInit();
            SuspendLayout();
            // 
            // AssignedLessons
            // 
            AssignedLessons.Controls.Add(tabPage1);
            AssignedLessons.Controls.Add(tabPage2);
            AssignedLessons.Controls.Add(tabPage3);
            AssignedLessons.Cursor = Cursors.Hand;
            AssignedLessons.Location = new Point(0, 0);
            AssignedLessons.Name = "AssignedLessons";
            AssignedLessons.SelectedIndex = 0;
            AssignedLessons.Size = new Size(1033, 720);
            AssignedLessons.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(Delete_Button);
            tabPage1.Controls.Add(Update_Button);
            tabPage1.Controls.Add(Add_Button);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1025, 687);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Teacher Info";
            tabPage1.Click += tabPage1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 35);
            label4.TabIndex = 49;
            label4.Text = "Teacher Info";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(192, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 634);
            dataGridView1.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 168);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 47;
            label3.Text = "Department";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 109);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 45;
            label2.Text = "Title";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 27);
            textBox2.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 43;
            label1.Text = "Teacher Name";
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(45, 45, 48);
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Segoe UI", 10F);
            Delete_Button.ForeColor = Color.White;
            Delete_Button.Location = new Point(15, 405);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(159, 44);
            Delete_Button.TabIndex = 42;
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
            Update_Button.Location = new Point(15, 337);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(159, 44);
            Update_Button.TabIndex = 41;
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
            Add_Button.Location = new Point(15, 269);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(159, 44);
            Add_Button.TabIndex = 40;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 39;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(dgvTeacherLessons);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btnAddTeacherLesson);
            tabPage2.Controls.Add(btnDeleteTeacherLesson);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(cbLesson);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(cbTeacher);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1025, 687);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Assigned Lessons";
            // 
            // dgvTeacherLessons
            // 
            dgvTeacherLessons.AllowUserToAddRows = false;
            dgvTeacherLessons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeacherLessons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacherLessons.Location = new Point(196, 47);
            dgvTeacherLessons.Name = "dgvTeacherLessons";
            dgvTeacherLessons.RowHeadersWidth = 51;
            dgvTeacherLessons.Size = new Size(823, 634);
            dgvTeacherLessons.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(210, 35);
            label7.TabIndex = 55;
            label7.Text = "Assigned Lessons";
            // 
            // btnAddTeacherLesson
            // 
            btnAddTeacherLesson.BackColor = Color.FromArgb(45, 45, 48);
            btnAddTeacherLesson.FlatStyle = FlatStyle.Flat;
            btnAddTeacherLesson.Font = new Font("Segoe UI", 10F);
            btnAddTeacherLesson.ForeColor = Color.White;
            btnAddTeacherLesson.Location = new Point(16, 276);
            btnAddTeacherLesson.Name = "btnAddTeacherLesson";
            btnAddTeacherLesson.Size = new Size(159, 44);
            btnAddTeacherLesson.TabIndex = 53;
            btnAddTeacherLesson.Text = "Remove Lesson";
            btnAddTeacherLesson.UseVisualStyleBackColor = false;
            btnAddTeacherLesson.Click += btnDeleteTeacherLesson_Click;
            // 
            // btnDeleteTeacherLesson
            // 
            btnDeleteTeacherLesson.BackColor = Color.FromArgb(45, 45, 48);
            btnDeleteTeacherLesson.FlatStyle = FlatStyle.Flat;
            btnDeleteTeacherLesson.Font = new Font("Segoe UI", 10F);
            btnDeleteTeacherLesson.ForeColor = Color.White;
            btnDeleteTeacherLesson.Location = new Point(16, 208);
            btnDeleteTeacherLesson.Name = "btnDeleteTeacherLesson";
            btnDeleteTeacherLesson.Size = new Size(159, 44);
            btnDeleteTeacherLesson.TabIndex = 52;
            btnDeleteTeacherLesson.Text = "Assign Lesson";
            btnDeleteTeacherLesson.UseVisualStyleBackColor = false;
            btnDeleteTeacherLesson.Click += btnAddTeacherLesson_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 113);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 51;
            label6.Text = "Lesson";
            // 
            // cbLesson
            // 
            cbLesson.FormattingEnabled = true;
            cbLesson.Location = new Point(16, 141);
            cbLesson.Name = "cbLesson";
            cbLesson.Size = new Size(159, 28);
            cbLesson.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 47);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 49;
            label5.Text = "Teacher";
            // 
            // cbTeacher
            // 
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new Point(16, 75);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new Size(159, 28);
            cbTeacher.TabIndex = 48;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Black;
            tabPage3.Controls.Add(dgvAvailability);
            tabPage3.Controls.Add(btnDeleteAvail);
            tabPage3.Controls.Add(btnAddAvail);
            tabPage3.Controls.Add(chkIsAvailable);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(cbAvailTeacher);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(cbAvailHour);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(cbAvailDay);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1025, 687);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Availability";
            // 
            // dgvAvailability
            // 
            dgvAvailability.AllowUserToAddRows = false;
            dgvAvailability.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailability.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailability.Location = new Point(196, 47);
            dgvAvailability.Name = "dgvAvailability";
            dgvAvailability.RowHeadersWidth = 51;
            dgvAvailability.Size = new Size(823, 634);
            dgvAvailability.TabIndex = 62;
            // 
            // btnDeleteAvail
            // 
            btnDeleteAvail.BackColor = Color.FromArgb(45, 45, 48);
            btnDeleteAvail.FlatStyle = FlatStyle.Flat;
            btnDeleteAvail.Font = new Font("Segoe UI", 10F);
            btnDeleteAvail.ForeColor = Color.White;
            btnDeleteAvail.Location = new Point(19, 396);
            btnDeleteAvail.Name = "btnDeleteAvail";
            btnDeleteAvail.Size = new Size(159, 44);
            btnDeleteAvail.TabIndex = 61;
            btnDeleteAvail.Text = "Remove";
            btnDeleteAvail.UseVisualStyleBackColor = false;
            btnDeleteAvail.Click += btnDeleteAvail_Click;
            // 
            // btnAddAvail
            // 
            btnAddAvail.BackColor = Color.FromArgb(45, 45, 48);
            btnAddAvail.FlatStyle = FlatStyle.Flat;
            btnAddAvail.Font = new Font("Segoe UI", 10F);
            btnAddAvail.ForeColor = Color.White;
            btnAddAvail.Location = new Point(19, 328);
            btnAddAvail.Name = "btnAddAvail";
            btnAddAvail.Size = new Size(159, 44);
            btnAddAvail.TabIndex = 60;
            btnAddAvail.Text = "Set Status";
            btnAddAvail.UseVisualStyleBackColor = false;
            btnAddAvail.Click += btnAddAvail_Click;
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Font = new Font("Segoe UI", 10F);
            chkIsAvailable.ForeColor = Color.White;
            chkIsAvailable.Location = new Point(19, 261);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(117, 27);
            chkIsAvailable.TabIndex = 59;
            chkIsAvailable.Text = "Is Available";
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(134, 35);
            label11.TabIndex = 58;
            label11.Text = "Availability";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(19, 47);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 57;
            label10.Text = "Teacher";
            label10.Click += label10_Click;
            // 
            // cbAvailTeacher
            // 
            cbAvailTeacher.FormattingEnabled = true;
            cbAvailTeacher.Location = new Point(19, 70);
            cbAvailTeacher.Name = "cbAvailTeacher";
            cbAvailTeacher.Size = new Size(159, 28);
            cbAvailTeacher.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(19, 191);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 55;
            label8.Text = "Hour";
            label8.Click += label8_Click;
            // 
            // cbAvailHour
            // 
            cbAvailHour.FormattingEnabled = true;
            cbAvailHour.Location = new Point(19, 214);
            cbAvailHour.Name = "cbAvailHour";
            cbAvailHour.Size = new Size(159, 28);
            cbAvailHour.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(19, 119);
            label9.Name = "label9";
            label9.Size = new Size(35, 20);
            label9.TabIndex = 53;
            label9.Text = "Day";
            // 
            // cbAvailDay
            // 
            cbAvailDay.FormattingEnabled = true;
            cbAvailDay.Location = new Point(19, 142);
            cbAvailDay.Name = "cbAvailDay";
            cbAvailDay.Size = new Size(159, 28);
            cbAvailDay.TabIndex = 52;
            // 
            // TeachresControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 0);
            Controls.Add(AssignedLessons);
            Name = "TeachresControl";
            Size = new Size(1033, 720);
            AssignedLessons.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeacherLessons).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailability).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl AssignedLessons;
        private TabPage tabPage1;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Button Delete_Button;
        private Button Update_Button;
        private Button Add_Button;
        private TextBox textBox1;
        private TabPage tabPage2;
        private Label label6;
        private ComboBox cbLesson;
        private Label label5;
        private ComboBox cbTeacher;
        private Button btnAddTeacherLesson;
        private Button btnDeleteTeacherLesson;
        private Label label7;
        private DataGridView dgvTeacherLessons;
        private TabPage tabPage3;
        private Label label11;
        private Label label10;
        private ComboBox cbAvailTeacher;
        private Label label8;
        private ComboBox cbAvailHour;
        private Label label9;
        private ComboBox cbAvailDay;
        private Button btnDeleteAvail;
        private Button btnAddAvail;
        private CheckBox chkIsAvailable;
        private DataGridView dgvAvailability;
    }
}