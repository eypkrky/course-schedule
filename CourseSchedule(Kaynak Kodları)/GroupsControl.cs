using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class GroupsControl : UserControl
    {
        public GroupsControl()
        {
            InitializeComponent();

            // Tab 1 (Group Info) Yüklemeleri
            LoadDepartments();
            LoadGroups();

            // Tab 2 (Group Lessons) Yüklemeleri
            LoadGroupsCombo();
            LoadLessonsCombo();
            LoadGroupLessonsGrid();
        }

        // ====================================================================
        // TAB 1: GROUP INFO (Eski Kodların Güncellenmiş Hali)
        // ====================================================================

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

        private void LoadGroups()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    select g.GroupID, g.GroupName, g.NumberofPeople, d.DepartmentName 
                    from StudentsGroups g 
                    join Departments d on g.DepartmentID = d.DepartmentID", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (GroupName.Text == "" || DepartmentCombo.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            dynamic selectedDepartment = DepartmentCombo.SelectedItem;
            int departmentID = selectedDepartment.ID;
            int numberOfPeople = (int)NumberofPeopleNumeric.Value;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("insert into StudentsGroups (GroupName, NumberofPeople, DepartmentID) values (@GroupName, @NumberofPeople, @DepartmentID)", conn);
                cmd.Parameters.AddWithValue("@GroupName", GroupName.Text);
                cmd.Parameters.AddWithValue("@NumberofPeople", numberOfPeople);
                cmd.Parameters.AddWithValue("@DepartmentID", departmentID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Group added successfully!");
                GroupName.Text = "";
                NumberofPeopleNumeric.Value = 0;
                DepartmentCombo.SelectedIndex = -1;

                LoadGroups();
                LoadGroupsCombo(); // Tab 2'deki listeyi de günceller
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a group to update.");
                return;
            }

            if (GroupName.Text == "" || DepartmentCombo.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            int groupID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["GroupID"].Value);
            dynamic selectedDepartment = DepartmentCombo.SelectedItem;
            int departmentID = selectedDepartment.ID;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("update StudentsGroups set GroupName = @GroupName, NumberofPeople = @NumberofPeople, DepartmentID = @DepartmentID where GroupID = @GroupID", conn);
                cmd.Parameters.AddWithValue("@GroupName", GroupName.Text);
                cmd.Parameters.AddWithValue("@NumberofPeople", (int)NumberofPeopleNumeric.Value);
                cmd.Parameters.AddWithValue("@DepartmentID", departmentID);
                cmd.Parameters.AddWithValue("@GroupID", groupID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Group updated successfully.");
                GroupName.Text = "";
                NumberofPeopleNumeric.Value = 0;
                DepartmentCombo.SelectedIndex = -1;

                LoadGroups();
                LoadGroupsCombo(); // Tab 2'deki listeyi de günceller
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a group to delete.");
                return;
            }

            int groupID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["GroupID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("delete from StudentsGroups where GroupID = @GroupID", conn);
                    cmd.Parameters.AddWithValue("@GroupID", groupID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Group deleted successfully.");
                    LoadGroups();
                    LoadGroupsCombo(); // Tab 2'deki listeyi de günceller
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete! This group has related data.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // ====================================================================
        // TAB 2: GROUP LESSONS (Yeni Köprü Tablo İşlemleri)
        // ====================================================================

        private void LoadGroupsCombo()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select GroupID, GroupName from StudentsGroups", conn);
                var reader = cmd.ExecuteReader();
                cbGroup.Items.Clear();
                while (reader.Read())
                {
                    cbGroup.Items.Add(new { ID = reader["GroupID"], Name = reader["GroupName"].ToString() });
                }
                reader.Close();
            }
            cbGroup.DisplayMember = "Name";
            cbGroup.ValueMember = "ID";
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

        private void LoadGroupLessonsGrid()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    select gl.GroupLessonID, g.GroupName as [Group Name], l.LessonName as [Lesson Name], gl.WeeklyCount as [Weekly Hours]
                    from GroupLessons gl
                    join StudentsGroups g on gl.GroupID = g.GroupID
                    join Lessons l on gl.LessonID = l.LessonID", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dgvGroupLessons.DataSource = table;
            }
        }

        private void btnAddGroupLesson_Click(object sender, EventArgs e)
        {
            if (cbGroup.SelectedItem == null || cbLesson.SelectedItem == null || numWeeklyCount.Value <= 0)
            {
                MessageBox.Show("Please select Group, Lesson, and set Weekly Hours greater than 0!");
                return;
            }

            dynamic selectedGroup = cbGroup.SelectedItem;
            dynamic selectedLesson = cbLesson.SelectedItem;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("insert into GroupLessons (WeeklyCount, LessonID, GroupID) values (@WeeklyCount, @LessonID, @GroupID)", conn);
                cmd.Parameters.AddWithValue("@WeeklyCount", (int)numWeeklyCount.Value);
                cmd.Parameters.AddWithValue("@LessonID", selectedLesson.ID);
                cmd.Parameters.AddWithValue("@GroupID", selectedGroup.ID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Lesson assigned to group successfully!");
                cbGroup.SelectedIndex = -1;
                cbLesson.SelectedIndex = -1;
                numWeeklyCount.Value = 0;

                LoadGroupLessonsGrid();
            }
        }

        private void btnDeleteGroupLesson_Click(object sender, EventArgs e)
        {
            if (dgvGroupLessons.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to remove.");
                return;
            }

            int groupLessonID = Convert.ToInt32(dgvGroupLessons.SelectedRows[0].Cells["GroupLessonID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("delete from GroupLessons where GroupLessonID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", groupLessonID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Assignment removed successfully.");
                    LoadGroupLessonsGrid();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}