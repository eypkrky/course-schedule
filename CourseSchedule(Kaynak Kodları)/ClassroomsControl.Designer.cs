namespace CourseSchedule
{
    partial class ClassroomsControl
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
            CapacityNumberic = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Delete_Button = new Button();
            Update_Button = new Button();
            Add_Button = new Button();
            TypeCombo = new ComboBox();
            ClassroomName = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)CapacityNumberic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CapacityNumberic
            // 
            CapacityNumberic.Location = new Point(16, 143);
            CapacityNumberic.Name = "CapacityNumberic";
            CapacityNumberic.Size = new Size(149, 27);
            CapacityNumberic.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 120);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 46;
            label4.Text = "Capacity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 179);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 45;
            label2.Text = "Classroom Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 61);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 44;
            label1.Text = "Classroom Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(188, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 634);
            dataGridView1.TabIndex = 43;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(45, 45, 48);
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Segoe UI", 10F);
            Delete_Button.ForeColor = Color.White;
            Delete_Button.Location = new Point(16, 388);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(150, 41);
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
            Update_Button.Location = new Point(16, 329);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(150, 41);
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
            Add_Button.Location = new Point(16, 270);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(150, 41);
            Add_Button.TabIndex = 40;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // TypeCombo
            // 
            TypeCombo.FormattingEnabled = true;
            TypeCombo.Items.AddRange(new object[] { "Mandatory", "Elective" });
            TypeCombo.Location = new Point(16, 205);
            TypeCombo.Name = "TypeCombo";
            TypeCombo.Size = new Size(149, 28);
            TypeCombo.TabIndex = 38;
            // 
            // ClassroomName
            // 
            ClassroomName.Location = new Point(16, 87);
            ClassroomName.Name = "ClassroomName";
            ClassroomName.Size = new Size(149, 27);
            ClassroomName.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 35);
            label3.TabIndex = 48;
            label3.Text = "Classrooms";
            // 
            // ClassroomsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 0);
            Controls.Add(label3);
            Controls.Add(CapacityNumberic);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Delete_Button);
            Controls.Add(Update_Button);
            Controls.Add(Add_Button);
            Controls.Add(TypeCombo);
            Controls.Add(ClassroomName);
            Name = "ClassroomsControl";
            Size = new Size(1033, 720);
            Load += ClassroomsControl_Load;
            ((System.ComponentModel.ISupportInitialize)CapacityNumberic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown CapacityNumberic;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button Delete_Button;
        private Button Update_Button;
        private Button Add_Button;
        private ComboBox TypeCombo;
        private TextBox ClassroomName;
        private Label label3;
    }
}