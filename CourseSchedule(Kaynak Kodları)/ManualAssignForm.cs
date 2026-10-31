using MetroFramework.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class ManualAssignForm : MetroForm
    {
        private int _groupID;
        private int _dayID;
        private int _hourID;

        public ManualAssignForm(int groupID, int dayID, int hourID)
        {
            InitializeComponent();
            _groupID = groupID;
            _dayID = dayID;
            _hourID = hourID;

            cbLessons.SelectedIndexChanged += cbLessons_SelectedIndexChanged;

            LoadLessons();
            LoadClassrooms();

            this.Text = "Manual Lesson Assignment";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoadLessons()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    select l.LessonID, l.LessonName 
                    from GroupLessons gl
                    join Lessons l on gl.LessonID = l.LessonID
                    where gl.GroupID = @GroupID", conn);
                cmd.Parameters.AddWithValue("@GroupID", _groupID);
                var reader = cmd.ExecuteReader();
                cbLessons.Items.Clear();
                while (reader.Read())
                {
                    cbLessons.Items.Add(new { ID = reader["LessonID"], Name = reader["LessonName"].ToString() });
                }
            }
            cbLessons.DisplayMember = "Name";
            cbLessons.ValueMember = "ID";
        }

        private void cbLessons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLessons.SelectedItem == null) return;
            dynamic selectedLesson = cbLessons.SelectedItem;
            int lessonID = selectedLesson.ID;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    select t.TeacherID, t.NameSurname 
                    from TeacherLessons tl
                    join Teachers t on tl.TeacherID = t.TeacherID
                    where tl.LessonID = @LessonID", conn);
                cmd.Parameters.AddWithValue("@LessonID", lessonID);
                var reader = cmd.ExecuteReader();
                cbTeachers.Items.Clear();
                while (reader.Read())
                {
                    cbTeachers.Items.Add(new { ID = reader["TeacherID"], Name = reader["NameSurname"].ToString() });
                }
            }
            cbTeachers.DisplayMember = "Name";
            cbTeachers.ValueMember = "ID";
        }

        private void LoadClassrooms()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select ClassroomID, ClassroomName from Classrooms", conn);
                var reader = cmd.ExecuteReader();
                cbClassrooms.Items.Clear();
                while (reader.Read())
                {
                    cbClassrooms.Items.Add(new { ID = reader["ClassroomID"], Name = reader["ClassroomName"].ToString() });
                }
            }
            cbClassrooms.DisplayMember = "Name";
            cbClassrooms.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbLessons.SelectedItem == null || cbTeachers.SelectedItem == null || cbClassrooms.SelectedItem == null)
            {
                MessageBox.Show("Please make all selections!");
                return;
            }

            dynamic selectedLesson = cbLessons.SelectedItem;
            dynamic selectedTeacher = cbTeachers.SelectedItem;
            dynamic selectedClassroom = cbClassrooms.SelectedItem;

            int lessonID = selectedLesson.ID;
            int teacherID = selectedTeacher.ID;
            int classroomID = selectedClassroom.ID;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmdCheck = new SqlCommand(@"
                    select 
                        (select count(*) from CourseSchedule where TeacherID = @TeacherID and DayID = @DayID and HourID = @HourID) as TeacherConflict,
                        (select count(*) from TeacherAvailability where TeacherID = @TeacherID and DayID = @DayID and HourID = @HourID and AvailabilityStatus = 0) as TeacherNotAvailable,
                        (select count(*) from CourseSchedule where ClassroomID = @ClassroomID and DayID = @DayID and HourID = @HourID) as ClassroomConflict,
                        (select Capacity from Classrooms where ClassroomID = @ClassroomID) as ClassCapacity,
                        (select NumberofPeople from StudentsGroups where GroupID = @GroupID) as GroupSize", conn);

                cmdCheck.Parameters.AddWithValue("@TeacherID", teacherID);
                cmdCheck.Parameters.AddWithValue("@ClassroomID", classroomID);
                cmdCheck.Parameters.AddWithValue("@DayID", _dayID);
                cmdCheck.Parameters.AddWithValue("@HourID", _hourID);
                cmdCheck.Parameters.AddWithValue("@GroupID", _groupID);

                var reader = cmdCheck.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToInt32(reader["TeacherConflict"]) > 0)
                    {
                        MessageBox.Show("Error: Selected teacher is assigned to another class at this time!", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close(); return;
                    }
                    if (Convert.ToInt32(reader["TeacherNotAvailable"]) > 0)
                    {
                        MessageBox.Show("Error: Teacher is not available at this day/hour!", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close(); return;
                    }
                    if (Convert.ToInt32(reader["ClassroomConflict"]) > 0)
                    {
                        MessageBox.Show("Error: Selected classroom is full at this time!", "Classroom Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close(); return;
                    }
                    if (Convert.ToInt32(reader["ClassCapacity"]) < Convert.ToInt32(reader["GroupSize"]))
                    {
                        MessageBox.Show("Error: Classroom capacity is smaller than the group size!", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close(); return;
                    }
                }
                reader.Close();

                var cmdInsert = new SqlCommand(@"
                    insert into CourseSchedule (GroupID, LessonID, HourID, DayID, ClassroomID, TeacherID, IsLocked, IsAutoGenerated) 
                    values (@GroupID, @LessonID, @HourID, @DayID, @ClassroomID, @TeacherID, 0, 0)", conn);

                cmdInsert.Parameters.AddWithValue("@GroupID", _groupID);
                cmdInsert.Parameters.AddWithValue("@LessonID", lessonID);
                cmdInsert.Parameters.AddWithValue("@HourID", _hourID);
                cmdInsert.Parameters.AddWithValue("@DayID", _dayID);
                cmdInsert.Parameters.AddWithValue("@ClassroomID", classroomID);
                cmdInsert.Parameters.AddWithValue("@TeacherID", teacherID);

                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Lesson manually assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}