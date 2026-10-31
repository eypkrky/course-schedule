namespace CourseSchedule
{
    partial class GroupsControl
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            NumberofPeopleNumeric = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Delete_Button = new Button();
            Update_Button = new Button();
            Add_Button = new Button();
            DepartmentCombo = new ComboBox();
            GroupName = new TextBox();
            tabPage2 = new TabPage();
            dgvGroupLessons = new DataGridView();
            btnDeleteGroupLesson = new Button();
            btnAddGroupLesson = new Button();
            label6 = new Label();
            numWeeklyCount = new NumericUpDown();
            label5 = new Label();
            cbLesson = new ComboBox();
            label3 = new Label();
            cbGroup = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberofPeopleNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroupLessons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeeklyCount).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1033, 714);
            tabControl1.TabIndex = 59;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(NumberofPeopleNumeric);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(Delete_Button);
            tabPage1.Controls.Add(Update_Button);
            tabPage1.Controls.Add(Add_Button);
            tabPage1.Controls.Add(DepartmentCombo);
            tabPage1.Controls.Add(GroupName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1025, 681);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Group Info";
            tabPage1.Click += tabPage1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 64);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 67;
            label4.Text = "Number of People";
            // 
            // NumberofPeopleNumeric
            // 
            NumberofPeopleNumeric.Location = new Point(15, 87);
            NumberofPeopleNumeric.Name = "NumberofPeopleNumeric";
            NumberofPeopleNumeric.Size = new Size(149, 27);
            NumberofPeopleNumeric.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 123);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 65;
            label2.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 5);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 64;
            label1.Text = "Group Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(187, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(835, 667);
            dataGridView1.TabIndex = 63;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(45, 45, 48);
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Segoe UI", 10F);
            Delete_Button.ForeColor = Color.White;
            Delete_Button.Location = new Point(15, 332);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(150, 41);
            Delete_Button.TabIndex = 62;
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
            Update_Button.Location = new Point(15, 273);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(150, 41);
            Update_Button.TabIndex = 61;
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
            Add_Button.Location = new Point(15, 214);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(150, 41);
            Add_Button.TabIndex = 60;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // DepartmentCombo
            // 
            DepartmentCombo.FormattingEnabled = true;
            DepartmentCombo.Items.AddRange(new object[] { "Mandatory", "Elective" });
            DepartmentCombo.Location = new Point(15, 149);
            DepartmentCombo.Name = "DepartmentCombo";
            DepartmentCombo.Size = new Size(149, 28);
            DepartmentCombo.TabIndex = 58;
            // 
            // GroupName
            // 
            GroupName.Location = new Point(15, 31);
            GroupName.Name = "GroupName";
            GroupName.Size = new Size(149, 27);
            GroupName.TabIndex = 59;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(dgvGroupLessons);
            tabPage2.Controls.Add(btnDeleteGroupLesson);
            tabPage2.Controls.Add(btnAddGroupLesson);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(numWeeklyCount);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(cbLesson);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cbGroup);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1025, 681);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Group Lessons";
            // 
            // dgvGroupLessons
            // 
            dgvGroupLessons.AllowUserToAddRows = false;
            dgvGroupLessons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroupLessons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroupLessons.Location = new Point(184, 8);
            dgvGroupLessons.Name = "dgvGroupLessons";
            dgvGroupLessons.RowHeadersWidth = 51;
            dgvGroupLessons.Size = new Size(835, 667);
            dgvGroupLessons.TabIndex = 74;
            dgvGroupLessons.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnDeleteGroupLesson
            // 
            btnDeleteGroupLesson.BackColor = Color.FromArgb(45, 45, 48);
            btnDeleteGroupLesson.FlatStyle = FlatStyle.Flat;
            btnDeleteGroupLesson.Font = new Font("Segoe UI", 10F);
            btnDeleteGroupLesson.ForeColor = Color.White;
            btnDeleteGroupLesson.Location = new Point(15, 347);
            btnDeleteGroupLesson.Name = "btnDeleteGroupLesson";
            btnDeleteGroupLesson.Size = new Size(150, 41);
            btnDeleteGroupLesson.TabIndex = 73;
            btnDeleteGroupLesson.Text = "Remove Lesson";
            btnDeleteGroupLesson.UseVisualStyleBackColor = false;
            btnDeleteGroupLesson.Click += btnDeleteGroupLesson_Click;
            // 
            // btnAddGroupLesson
            // 
            btnAddGroupLesson.BackColor = Color.FromArgb(45, 45, 48);
            btnAddGroupLesson.FlatStyle = FlatStyle.Flat;
            btnAddGroupLesson.Font = new Font("Segoe UI", 10F);
            btnAddGroupLesson.ForeColor = Color.White;
            btnAddGroupLesson.Location = new Point(15, 288);
            btnAddGroupLesson.Name = "btnAddGroupLesson";
            btnAddGroupLesson.Size = new Size(150, 41);
            btnAddGroupLesson.TabIndex = 72;
            btnAddGroupLesson.Text = "Assign Lesson";
            btnAddGroupLesson.UseVisualStyleBackColor = false;
            btnAddGroupLesson.Click += btnAddGroupLesson_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 194);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 71;
            label6.Text = "Weekly Hours";
            label6.Click += label6_Click;
            // 
            // numWeeklyCount
            // 
            numWeeklyCount.Location = new Point(16, 217);
            numWeeklyCount.Name = "numWeeklyCount";
            numWeeklyCount.Size = new Size(149, 27);
            numWeeklyCount.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 116);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 69;
            label5.Text = "Lesson";
            label5.Click += label5_Click;
            // 
            // cbLesson
            // 
            cbLesson.FormattingEnabled = true;
            cbLesson.Items.AddRange(new object[] { "Mandatory", "Elective" });
            cbLesson.Location = new Point(18, 139);
            cbLesson.Name = "cbLesson";
            cbLesson.Size = new Size(149, 28);
            cbLesson.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 38);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 67;
            label3.Text = "Group";
            label3.Click += label3_Click;
            // 
            // cbGroup
            // 
            cbGroup.FormattingEnabled = true;
            cbGroup.Items.AddRange(new object[] { "Mandatory", "Elective" });
            cbGroup.Location = new Point(18, 61);
            cbGroup.Name = "cbGroup";
            cbGroup.Size = new Size(149, 28);
            cbGroup.TabIndex = 66;
            // 
            // GroupsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 0);
            Controls.Add(tabControl1);
            Name = "GroupsControl";
            Size = new Size(1033, 720);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberofPeopleNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroupLessons).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeeklyCount).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label4;
        private NumericUpDown NumberofPeopleNumeric;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button Delete_Button;
        private Button Update_Button;
        private Button Add_Button;
        private ComboBox DepartmentCombo;
        private TextBox GroupName;
        private TabPage tabPage2;
        private DataGridView dgvGroupLessons;
        private Button btnDeleteGroupLesson;
        private Button btnAddGroupLesson;
        private Label label6;
        private NumericUpDown numWeeklyCount;
        private Label label5;
        private ComboBox cbLesson;
        private Label label3;
        private ComboBox cbGroup;
    }
}
