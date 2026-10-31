using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class TeachresControl : UserControl
    {
        public TeachresControl()
        {
            InitializeComponent();

            LoadDepartments();
            LoadTeachers();
            LoadTeachersCombo();
            LoadLessonsCombo();
            LoadTeacherLessonsGrid();

            LoadDaysCombo();
            LoadHoursCombo();
            LoadAvailabilityGrid();
        }


        private void LoadDepartments()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select DepartmentID, DepartmentName from Departments", conn);
                var reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(new { ID = reader["DepartmentID"], Name = reader["DepartmentName"].ToString() });
                }
                reader.Close();
            }
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }

        private void LoadTeachers()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    select t.TeacherID, t.NameSurname, t.Title, d.DepartmentName 
                    from Teachers t 
                    join Departments d on t.DepartmentID = d.DepartmentID", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            dynamic selectedDept = comboBox1.SelectedItem;
            int deptID = selectedDept.ID;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("insert into Teachers (NameSurname, Title, DepartmentID) values (@Name, @Title, @DeptID)", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Title", textBox2.Text);
                cmd.Parameters.AddWithValue("@DeptID", deptID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Teacher added successfully!");
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;

                LoadTeachers();
                LoadTeachersCombo();
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            int teacherID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TeacherID"].Value);
            dynamic selectedDept = comboBox1.SelectedItem;
            int deptID = selectedDept.ID;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("update Teachers set NameSurname = @Name, Title = @Title, DepartmentID = @DeptID where TeacherID = @TeacherID", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Title", textBox2.Text);
                cmd.Parameters.AddWithValue("@DeptID", deptID);
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Teacher updated successfully.");
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;

                LoadTeachers();
                LoadTeachersCombo();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to delete.");
                return;
            }

            int teacherID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TeacherID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("delete from Teachers where TeacherID = @TeacherID", conn);
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Teacher deleted successfully.");
                    LoadTeachers();
                    LoadTeachersCombo();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete! This teacher has related data.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void LoadTeachersCombo()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select TeacherID, NameSurname from Teachers", conn);
                var reader = cmd.ExecuteReader();

                cbTeacher.Items.Clear();
                cbAvailTeacher.Items.Clear();

                while (reader.Read())
                {
                    var item = new { ID = reader["TeacherID"], Name = reader["NameSurname"].ToString() };
                    cbTeacher.Items.Add(item);
                    cbAvailTeacher.Items.Add(item);
                }
                reader.Close();
            }
            cbTeacher.DisplayMember = "Name";
            cbTeacher.ValueMember = "ID";

            cbAvailTeacher.DisplayMember = "Name";
            cbAvailTeacher.ValueMember = "ID";
        }


        private void LoadLessonsCombo()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select LessonID, LessonName from Lessons", conn);
                var reader = cmd.ExecuteReader();
                cbLesson.Items.Clear();
                while (reader.Read())
                {
                    cbLesson.Items.Add(new { ID = reader["LessonID"], Name = reader["LessonName"].ToString() });
                }
                reader.Close();
            }
            cbLesson.DisplayMember = "Name";
            cbLesson.ValueMember = "ID";
        }

        private void LoadTeacherLessonsGrid()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    select tl.TeacherLessonID, t.NameSurname as [Teacher Name], l.LessonName as [Lesson Name]
                    from TeacherLessons tl
                    join Teachers t on tl.TeacherID = t.TeacherID
                    join Lessons l on tl.LessonID = l.LessonID", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dgvTeacherLessons.DataSource = table;
            }
        }

        private void btnAddTeacherLesson_Click(object sender, EventArgs e)
        {
            if (cbTeacher.SelectedItem == null || cbLesson.SelectedItem == null)
            {
                MessageBox.Show("Please select both a Teacher and a Lesson!");
                return;
            }

            dynamic selectedTeacher = cbTeacher.SelectedItem;
            dynamic selectedLesson = cbLesson.SelectedItem;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("insert into TeacherLessons (TeacherID, LessonID) values (@TeacherID, @LessonID)", conn);
                cmd.Parameters.AddWithValue("@TeacherID", selectedTeacher.ID);
                cmd.Parameters.AddWithValue("@LessonID", selectedLesson.ID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Lesson assigned to teacher successfully!");
                cbTeacher.SelectedIndex = -1;
                cbLesson.SelectedIndex = -1;

                LoadTeacherLessonsGrid();
            }
        }

        private void btnDeleteTeacherLesson_Click(object sender, EventArgs e)
        {
            if (dgvTeacherLessons.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to remove.");
                return;
            }

            int teacherLessonID = Convert.ToInt32(dgvTeacherLessons.SelectedRows[0].Cells["TeacherLessonID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("delete from TeacherLessons where TeacherLessonID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", teacherLessonID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Assignment removed successfully.");
                    LoadTeacherLessonsGrid();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void LoadDaysCombo()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select DayID, DayTitle from tbl_Days", conn);
                var reader = cmd.ExecuteReader();
                cbAvailDay.Items.Clear();
                while (reader.Read())
                {
                    cbAvailDay.Items.Add(new { ID = reader["DayID"], Name = reader["DayTitle"].ToString() });
                }
                reader.Close();
            }
            cbAvailDay.DisplayMember = "Name";
            cbAvailDay.ValueMember = "ID";
        }

        private void LoadHoursCombo()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select HourID, HourInterval from tbl_Hours order by OrderNo", conn);
                var reader = cmd.ExecuteReader();
                cbAvailHour.Items.Clear();
                while (reader.Read())
                {
                    cbAvailHour.Items.Add(new { ID = reader["HourID"], Name = reader["HourInterval"].ToString() });
                }
                reader.Close();
            }
            cbAvailHour.DisplayMember = "Name";
            cbAvailHour.ValueMember = "ID";
        }

        private void LoadAvailabilityGrid()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    select 
                        ta.UnID, 
                        t.NameSurname as [Teacher], 
                        d.DayTitle as [Day], 
                        h.HourInterval as [Hour], 
                        case when ta.AvailabilityStatus = 1 then 'Yes' else 'No' end as [Available]
                    from TeacherAvailability ta
                    join Teachers t on ta.TeacherID = t.TeacherID
                    join tbl_Days d on ta.DayID = d.DayID
                    join tbl_Hours h on ta.HourID = h.HourID", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dgvAvailability.DataSource = table;
            }
        }

        private void btnAddAvail_Click(object sender, EventArgs e)
        {
            if (cbAvailTeacher.SelectedItem == null || cbAvailDay.SelectedItem == null || cbAvailHour.SelectedItem == null)
            {
                MessageBox.Show("Please select Teacher, Day and Hour!");
                return;
            }

            dynamic selectedTeacher = cbAvailTeacher.SelectedItem;
            dynamic selectedDay = cbAvailDay.SelectedItem;
            dynamic selectedHour = cbAvailHour.SelectedItem;
            bool status = chkIsAvailable.Checked;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("insert into TeacherAvailability (TeacherID, DayID, HourID, AvailabilityStatus) values (@TeacherID, @DayID, @HourID, @Status)", conn);
                cmd.Parameters.AddWithValue("@TeacherID", selectedTeacher.ID);
                cmd.Parameters.AddWithValue("@DayID", selectedDay.ID);
                cmd.Parameters.AddWithValue("@HourID", selectedHour.ID);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Availability status set successfully!");
                cbAvailDay.SelectedIndex = -1;
                cbAvailHour.SelectedIndex = -1;
                chkIsAvailable.Checked = false;

                LoadAvailabilityGrid();
            }
        }

        private void btnDeleteAvail_Click(object sender, EventArgs e)
        {
            if (dgvAvailability.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a status to remove.");
                return;
            }

            int unID = Convert.ToInt32(dgvAvailability.SelectedRows[0].Cells["UnID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("delete from TeacherAvailability where UnID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", unID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Status removed successfully.");
                    LoadAvailabilityGrid();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}