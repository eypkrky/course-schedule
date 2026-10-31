namespace CourseSchedule
{
    partial class FacultiesControl
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
            Delete_Button = new Button();
            Update_Button = new Button();
            Add_Button = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 60);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 12;
            label1.Text = "Faculty Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(183, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 634);
            dataGridView1.TabIndex = 11;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(45, 45, 48);
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Segoe UI", 10F);
            Delete_Button.ForeColor = Color.White;
            Delete_Button.Location = new Point(6, 268);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(159, 44);
            Delete_Button.TabIndex = 10;
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
            Update_Button.Location = new Point(6, 200);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(159, 44);
            Update_Button.TabIndex = 9;
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
            Add_Button.Location = new Point(6, 132);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(159, 44);
            Add_Button.TabIndex = 8;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 35);
            label2.TabIndex = 13;
            label2.Text = "Faculties Form";
            // 
            // FacultiesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 0);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Delete_Button);
            Controls.Add(Update_Button);
            Controls.Add(Add_Button);
            Controls.Add(textBox1);
            Name = "FacultiesControl";
            Size = new Size(1033, 720);
            Load += FacultiesControl_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button Delete_Button;
        private Button Update_Button;
        private Button Add_Button;
        private TextBox textBox1;
        private Label label2;
    }
}