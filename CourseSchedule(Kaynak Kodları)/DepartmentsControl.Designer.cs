namespace CourseSchedule
{
    partial class DepartmentsControl
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
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Delete_Button = new Button();
            Update_Button = new Button();
            Add_Button = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 120);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 15;
            label2.Text = "Faculty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 57);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 14;
            label1.Text = "Department Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(188, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 634);
            dataGridView1.TabIndex = 13;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(45, 45, 48);
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Segoe UI", 10F);
            Delete_Button.ForeColor = Color.White;
            Delete_Button.Location = new Point(15, 315);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(150, 41);
            Delete_Button.TabIndex = 12;
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
            Update_Button.Location = new Point(15, 256);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(150, 41);
            Update_Button.TabIndex = 11;
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
            Add_Button.Location = new Point(15, 197);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(150, 41);
            Add_Button.TabIndex = 10;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 28);
            comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 27);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 35);
            label3.TabIndex = 16;
            label3.Text = "Departments";
            // 
            // DepartmentsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 0);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Delete_Button);
            Controls.Add(Update_Button);
            Controls.Add(Add_Button);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "DepartmentsControl";
            Size = new Size(1033, 720);
            Load += DepartmentsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button Delete_Button;
        private Button Update_Button;
        private Button Add_Button;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
    }
}