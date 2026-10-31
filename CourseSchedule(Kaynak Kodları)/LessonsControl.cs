using MetroFramework.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class LessonsControl : UserControl
    {
        public LessonsControl()
        {
            InitializeComponent();
            LoadLessonTypes();
            LoadDepartments();
            LoadLessons();
        }

        private void Lesson_Load(object sender, EventArgs e)
        {
            LoadLessonTypes();
            LoadDepartments();
            LoadLessons();
        }

        private void LoadLessonTypes()
        {
            LessonCombo.Items.Clear();
            LessonCombo.Items.Add("Teorik");
            LessonCombo.Items.Add("Uygulama");
            LessonCombo.Items.Add("Lab");
        }

        private void LoadDepartments()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select DepartmentID, DepartmentName from Departments", conn);
                var reader = cmd.ExecuteReader();
                DepartmentCombo.Items.Clear();

                while (reader.Read())
                {
                    DepartmentCombo.Items.Add(new { ID = reader["DepartmentID"], Name = reader["DepartmentName"].ToString() });
                }
                reader.Close();
            }

            DepartmentCombo.DisplayMember = "Name";
            DepartmentCombo.ValueMember = "ID";
        }

        private void LoadLessons()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "select l.LessonID, l.LessonName, l.Duration, l.LessonType, l.Credit, d.DepartmentName from Lessons l join Departments d on l.DepartmentID = d.DepartmentID", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (LessonName.Text == "" || Duration.Text == "" || DepartmentCombo.SelectedItem == null || LessonCombo.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            dynamic selectedDepartment = DepartmentCombo.SelectedItem;
            int DepartmentID = selectedDepartment.ID;
            string lessonType = LessonCombo.SelectedItem?.ToString() ?? "";
            int credit = (int)CreditNumberic.Value;
            int duration = Convert.ToInt32(Duration.Text);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "insert into Lessons (LessonName, Duration, LessonType, Credit, DepartmentID) values (@LessonName, @Duration, @LessonType, @Credit, @DepartmentID)", conn);

                cmd.Parameters.AddWithValue("@LessonName", LessonName.Text);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@LessonType", lessonType);
                cmd.Parameters.AddWithValue("@Credit", credit);
                cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Lesson added successfully!");

                LessonName.Text = "";
                Duration.Text = "";
                CreditNumberic.Value = 0;
                DepartmentCombo.SelectedIndex = -1;
                LessonCombo.SelectedIndex = -1;

                LoadLessons();
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lesson to update.");
                return;
            }

            if (LessonName.Text == "" || Duration.Text == "" || DepartmentCombo.SelectedItem == null || LessonCombo.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            int LessonID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["LessonID"].Value);
            dynamic selectedDepartment = DepartmentCombo.SelectedItem;
            int DepartmentID = selectedDepartment.ID;
            int duration = Convert.ToInt32(Duration.Text);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "update Lessons set LessonName = @LessonName, Duration = @Duration, LessonType = @LessonType, Credit = @Credit, DepartmentID = @DepartmentID where LessonID = @LessonID", conn);
                cmd.Parameters.AddWithValue("@LessonName", LessonName.Text);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@LessonType", LessonCombo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Credit", (int)CreditNumberic.Value);
                cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                cmd.Parameters.AddWithValue("@LessonID", LessonID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lesson updated successfully.");

                LessonName.Text = "";
                Duration.Text = "";
                CreditNumberic.Value = 0;
                DepartmentCombo.SelectedIndex = -1;
                LessonCombo.SelectedIndex = -1;
                LoadLessons();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lesson to delete.");
                return;
            }

            int lessonID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["LessonID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("delete from Lessons where LessonID = @LessonID", conn);
                    cmd.Parameters.AddWithValue("@LessonID", lessonID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lesson deleted successfully.");
                    LoadLessons();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete! This lesson is already assigned to a teacher or a group. Please remove those assignments first.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LessonsControl_Load(object sender, EventArgs e)
        {

        }
    }
}