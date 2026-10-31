namespace CourseSchedule
{
    partial class CourseScheduleControl
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
            cbScheduleGroup = new ComboBox();
            label1 = new Label();
            btnClearSchedule = new Button();
            btnAutoGenerate = new Button();
            dgvSchedule = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 49);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 37;
            label2.Text = "Select Group";
            // 
            // cbScheduleGroup
            // 
            cbScheduleGroup.FormattingEnabled = true;
            cbScheduleGroup.Items.AddRange(new object[] { "Mandatory", "Elective" });
            cbScheduleGroup.Location = new Point(16, 72);
            cbScheduleGroup.Name = "cbScheduleGroup";
            cbScheduleGroup.Size = new Size(149, 28);
            cbScheduleGroup.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 35);
            label1.TabIndex = 38;
            label1.Text = "Course Schedule";
            // 
            // btnClearSchedule
            // 
            btnClearSchedule.BackColor = Color.FromArgb(45, 45, 48);
            btnClearSchedule.FlatStyle = FlatStyle.Flat;
            btnClearSchedule.Font = new Font("Segoe UI", 10F);
            btnClearSchedule.ForeColor = Color.White;
            btnClearSchedule.Location = new Point(16, 191);
            btnClearSchedule.Name = "btnClearSchedule";
            btnClearSchedule.Size = new Size(150, 41);
            btnClearSchedule.TabIndex = 40;
            btnClearSchedule.Text = "Clear Schedule";
            btnClearSchedule.UseVisualStyleBackColor = false;
            btnClearSchedule.Click += btnClearSchedule_Click;
            // 
            // btnAutoGenerate
            // 
            btnAutoGenerate.BackColor = Color.FromArgb(45, 45, 48);
            btnAutoGenerate.FlatStyle = FlatStyle.Flat;
            btnAutoGenerate.Font = new Font("Segoe UI", 10F);
            btnAutoGenerate.ForeColor = Color.White;
            btnAutoGenerate.Location = new Point(16, 132);
            btnAutoGenerate.Name = "btnAutoGenerate";
            btnAutoGenerate.Size = new Size(150, 41);
            btnAutoGenerate.TabIndex = 39;
            btnAutoGenerate.Text = "Auto Generate";
            btnAutoGenerate.UseVisualStyleBackColor = false;
            btnAutoGenerate.Click += btnAutoGenerate_Click;
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(186, 49);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.Size = new Size(847, 671);
            dgvSchedule.TabIndex = 41;
            // 
            // CourseScheduleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(dgvSchedule);
            Controls.Add(btnClearSchedule);
            Controls.Add(btnAutoGenerate);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cbScheduleGroup);
            Name = "CourseScheduleControl";
            Size = new Size(1033, 720);
            Load += CourseScheduleControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cbScheduleGroup;
        private Label label1;
        private Button btnClearSchedule;
        private Button btnAutoGenerate;
        private DataGridView dgvSchedule;
    }
}
