namespace CourseSchedule
{
    partial class HourIntervalControl
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
            hourIntervalTextBox = new TextBox();
            label3 = new Label();
            orderNoNumeric = new NumericUpDown();
            Delete_Button = new Button();
            Update_Button = new Button();
            Add_Button = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderNoNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 57);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 37;
            label1.Text = "Hour Interval";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(184, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 634);
            dataGridView1.TabIndex = 36;
            // 
            // hourIntervalTextBox
            // 
            hourIntervalTextBox.Location = new Point(12, 83);
            hourIntervalTextBox.Name = "hourIntervalTextBox";
            hourIntervalTextBox.Size = new Size(149, 27);
            hourIntervalTextBox.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 126);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 39;
            label3.Text = "Order No";
            // 
            // orderNoNumeric
            // 
            orderNoNumeric.Location = new Point(12, 149);
            orderNoNumeric.Name = "orderNoNumeric";
            orderNoNumeric.Size = new Size(150, 27);
            orderNoNumeric.TabIndex = 38;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(45, 45, 48);
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Segoe UI", 10F);
            Delete_Button.ForeColor = Color.White;
            Delete_Button.Location = new Point(14, 330);
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
            Update_Button.Location = new Point(14, 271);
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
            Add_Button.Location = new Point(14, 212);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(150, 41);
            Add_Button.TabIndex = 40;
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
            label2.Size = new Size(82, 35);
            label2.TabIndex = 43;
            label2.Text = "Hours";
            // 
            // HourIntervalControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(label2);
            Controls.Add(Delete_Button);
            Controls.Add(Update_Button);
            Controls.Add(Add_Button);
            Controls.Add(label3);
            Controls.Add(orderNoNumeric);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(hourIntervalTextBox);
            Name = "HourIntervalControl";
            Size = new Size(1033, 720);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderNoNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox hourIntervalTextBox;
        private Label label3;
        private NumericUpDown orderNoNumeric;
        private Button Delete_Button;
        private Button Update_Button;
        private Button Add_Button;
        private Label label2;
    }
}
