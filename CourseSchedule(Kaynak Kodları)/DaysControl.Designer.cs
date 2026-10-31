namespace CourseSchedule
{
    partial class DaysControl
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dayTitleTextBox = new TextBox();
            Delete_Button = new Button();
            Update_Button = new Button();
            Add_Button = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 60);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 17;
            label1.Text = "Day Title";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(190, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 634);
            dataGridView1.TabIndex = 16;
            // 
            // dayTitleTextBox
            // 
            dayTitleTextBox.Location = new Point(18, 86);
            dayTitleTextBox.Name = "dayTitleTextBox";
            dayTitleTextBox.Size = new Size(149, 27);
            dayTitleTextBox.TabIndex = 15;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(45, 45, 48);
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Segoe UI", 10F);
            Delete_Button.ForeColor = Color.White;
            Delete_Button.Location = new Point(17, 263);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(150, 41);
            Delete_Button.TabIndex = 20;
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
            Update_Button.Location = new Point(17, 204);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(150, 41);
            Update_Button.TabIndex = 19;
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
            Add_Button.Location = new Point(17, 145);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(150, 41);
            Add_Button.TabIndex = 18;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 35);
            label2.TabIndex = 21;
            label2.Text = "Days";
            // 
            // DaysControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(label2);
            Controls.Add(Delete_Button);
            Controls.Add(Update_Button);
            Controls.Add(Add_Button);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(dayTitleTextBox);
            Name = "DaysControl";
            Size = new Size(1033, 720);
            Load += DaysControl_Load;
            Click += Add_Button_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox dayTitleTextBox;
        private Button Delete_Button;
        private Button Update_Button;
        private Button Add_Button;
        private Label label2;
    }
}
