using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class CourseScheduleControl : UserControl
    {
        public CourseScheduleControl()
        {
            InitializeComponent();

            cbScheduleGroup.SelectedIndexChanged += cbScheduleGroup_SelectedIndexChanged;

            // DataGridView Görsel Ayarları (Hücre içi metinler alt alta insin diye)
            dgvSchedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSchedule.ReadOnly = true;
            dgvSchedule.AllowUserToAddRows = false;

            LoadGroupsCombo();
            InitializeGrid();
        }

        private void LoadGroupsCombo()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select GroupID, GroupName from StudentsGroups", conn);
                var reader = cmd.ExecuteReader();
                cbScheduleGroup.Items.Clear();
                while (reader.Read())
                {
                    cbScheduleGroup.Items.Add(new { ID = reader["GroupID"], Name = reader["GroupName"].ToString() });
                }
            }
            cbScheduleGroup.DisplayMember = "Name";
            cbScheduleGroup.ValueMember = "ID";
        }

        private void InitializeGrid()
        {
            dgvSchedule.Columns.Clear();
            dgvSchedule.Rows.Clear();

            dgvSchedule.Columns.Add("Col_Hour", "Saat");

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmdDays = new SqlCommand("select DayID, DayTitle from tbl_Days order by DayID", conn);
                var readerDays = cmdDays.ExecuteReader();
                while (readerDays.Read())
                {
                    string colName = "Day_" + readerDays["DayID"].ToString();
                    string colTitle = readerDays["DayTitle"].ToString()!;
                    dgvSchedule.Columns.Add(colName, colTitle);
                }
                readerDays.Close();

                var cmdHours = new SqlCommand("select HourID, HourInterval from tbl_Hours order by OrderNo", conn);
                var readerHours = cmdHours.ExecuteReader();
                while (readerHours.Read())
                {
                    int rowIndex = dgvSchedule.Rows.Add();
                    dgvSchedule.Rows[rowIndex].Cells[0].Value = readerHours["HourInterval"].ToString();
                    dgvSchedule.Rows[rowIndex].Tag = readerHours["HourID"]; // Saat ID'sini satırın gizli tag'inde tutuyoruz
                }
            }
        }

        private void cbScheduleGroup_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbScheduleGroup.SelectedItem == null) return;

            dynamic selectedGroup = cbScheduleGroup.SelectedItem;
            int groupID = selectedGroup.ID;

            RefreshScheduleDisplay(groupID);
        }

        private void RefreshScheduleDisplay(int groupID)
        {
            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                for (int i = 1; i < dgvSchedule.Columns.Count; i++)
                {
                    row.Cells[i].Value = "";
                    row.Cells[i].Style.BackColor = Color.White;
                }
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    select cs.DayID, cs.HourID, l.LessonName, t.NameSurname, c.ClassroomName 
                    from CourseSchedule cs 
                    join Lessons l on cs.LessonID = l.LessonID 
                    join Teachers t on cs.TeacherID = t.TeacherID 
                    join Classrooms c on cs.ClassroomID = c.ClassroomID 
                    where cs.GroupID = @GroupID", conn);

                cmd.Parameters.AddWithValue("@GroupID", groupID);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int dayID = Convert.ToInt32(reader["DayID"]);
                    int hourID = Convert.ToInt32(reader["HourID"]);
                    string cellText = $"{reader["LessonName"]}\n{reader["NameSurname"]}\n{reader["ClassroomName"]}";

                    string colName = "Day_" + dayID;
                    foreach (DataGridViewRow row in dgvSchedule.Rows)
                    {
                        if (row.Tag != null && (int)row.Tag == hourID)
                        {
                            row.Cells[colName].Value = cellText;
                            row.Cells[colName].Style.BackColor = Color.LightGreen; // Dolu hücreleri yeşil yap
                            break;
                        }
                    }
                }
            }
            dgvSchedule.ClearSelection();
        }


        private void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int placedLessonsCount = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    var cmdPending = new SqlCommand(@"
                        select gl.GroupID, gl.LessonID, gl.WeeklyCount, g.NumberofPeople, l.LessonType,
                               (select count(*) from CourseSchedule cs where cs.GroupID = gl.GroupID and cs.LessonID = gl.LessonID) as ScheduledCount
                        from GroupLessons gl
                        join StudentsGroups g on gl.GroupID = g.GroupID
                        join Lessons l on gl.LessonID = l.LessonID", conn);

                    var adapter = new SqlDataAdapter(cmdPending);
                    var dtPending = new DataTable();
                    adapter.Fill(dtPending);

                    var dtDays = GetDataTable("select DayID from tbl_Days order by DayID", conn);
                    var dtHours = GetDataTable("select HourID from tbl_Hours order by OrderNo", conn);

                    foreach (DataRow pRow in dtPending.Rows)
                    {
                        int groupID = Convert.ToInt32(pRow["GroupID"]);
                        int lessonID = Convert.ToInt32(pRow["LessonID"]);
                        int reqCapacity = Convert.ToInt32(pRow["NumberofPeople"]);
                        string reqType = pRow["LessonType"].ToString()!.Trim();

                        int weeklyCount = Convert.ToInt32(pRow["WeeklyCount"]);
                        int scheduledCount = Convert.ToInt32(pRow["ScheduledCount"]);
                        int needed = weeklyCount - scheduledCount;

                        for (int i = 0; i < needed; i++)
                        {
                            bool placed = false;
                            foreach (DataRow dRow in dtDays.Rows)
                            {
                                foreach (DataRow hRow in dtHours.Rows)
                                {
                                    int dayID = Convert.ToInt32(dRow["DayID"]);
                                    int hourID = Convert.ToInt32(hRow["HourID"]);

                                    var cmdFind = new SqlCommand(@"
                                        select top 1 t.TeacherID, c.ClassroomID
                                        from TeacherLessons tl
                                        join Teachers t on tl.TeacherID = t.TeacherID
                                        cross join Classrooms c
                                        where tl.LessonID = @LessonID
                                          and c.Capacity >= @ReqCapacity
                                          and c.ClassType = @ReqType
                                          and not exists (select 1 from CourseSchedule cs where cs.TeacherID = t.TeacherID and cs.DayID = @DayID and cs.HourID = @HourID)
                                          and not exists (select 1 from TeacherAvailability ta where ta.TeacherID = t.TeacherID and ta.DayID = @DayID and ta.HourID = @HourID and ta.AvailabilityStatus = 0)
                                          and not exists (select 1 from CourseSchedule cs where cs.ClassroomID = c.ClassroomID and cs.DayID = @DayID and cs.HourID = @HourID)
                                          and not exists (select 1 from CourseSchedule cs where cs.GroupID = @GroupID and cs.DayID = @DayID and cs.HourID = @HourID)
                                          and (select count(*) from CourseSchedule cs2 where cs2.GroupID = @GroupID and cs2.LessonID = @LessonID and cs2.DayID = @DayID) < 2", conn);

                                    cmdFind.Parameters.AddWithValue("@LessonID", lessonID);
                                    cmdFind.Parameters.AddWithValue("@ReqCapacity", reqCapacity);
                                    cmdFind.Parameters.AddWithValue("@ReqType", reqType);
                                    cmdFind.Parameters.AddWithValue("@DayID", dayID);
                                    cmdFind.Parameters.AddWithValue("@HourID", hourID);
                                    cmdFind.Parameters.AddWithValue("@GroupID", groupID);

                                    var readerFind = cmdFind.ExecuteReader();
                                    if (readerFind.Read())
                                    {
                                        int teacherID = Convert.ToInt32(readerFind["TeacherID"]);
                                        int classroomID = Convert.ToInt32(readerFind["ClassroomID"]);
                                        readerFind.Close();

                                        var cmdInsert = new SqlCommand("insert into CourseSchedule (GroupID, LessonID, HourID, DayID, ClassroomID, TeacherID, IsLocked, IsAutoGenerated) values (@GroupID, @LessonID, @HourID, @DayID, @ClassroomID, @TeacherID, 0, 1)", conn);
                                        cmdInsert.Parameters.AddWithValue("@GroupID", groupID);
                                        cmdInsert.Parameters.AddWithValue("@LessonID", lessonID);
                                        cmdInsert.Parameters.AddWithValue("@HourID", hourID);
                                        cmdInsert.Parameters.AddWithValue("@DayID", dayID);
                                        cmdInsert.Parameters.AddWithValue("@ClassroomID", classroomID);
                                        cmdInsert.Parameters.AddWithValue("@TeacherID", teacherID);
                                        cmdInsert.ExecuteNonQuery();

                                        placed = true;
                                        placedLessonsCount++;
                                        break;
                                    }
                                    if (!readerFind.IsClosed) readerFind.Close();
                                }
                                if (placed) break;
                            }
                        }
                    }
                }

                MessageBox.Show($"Auto-Generation complete! Successfully placed {placedLessonsCount} lessons into the schedule.", "Algorithm Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cbScheduleGroup.SelectedItem != null)
                {
                    dynamic selectedGroup = cbScheduleGroup.SelectedItem;
                    RefreshScheduleDisplay(selectedGroup.ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during scheduling: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnClearSchedule_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the ENTIRE schedule? This cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("delete from CourseSchedule", conn);
                    cmd.ExecuteNonQuery();
                }

                if (cbScheduleGroup.SelectedItem != null)
                {
                    dynamic selectedGroup = cbScheduleGroup.SelectedItem;
                    RefreshScheduleDisplay(selectedGroup.ID);
                }
                MessageBox.Show("Schedule cleared successfully.");
            }
        }

        private DataTable GetDataTable(string query, SqlConnection conn)
        {
            var cmd = new SqlCommand(query, conn);
            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void CourseScheduleControl_Load(object sender, EventArgs e)
        {
            dgvSchedule.CellDoubleClick += dgvSchedule_CellDoubleClick;

            if (Form1.UserRole == "Student")
            {
                btnAutoGenerate.Visible = false;
                btnClearSchedule.Visible = false;

                dgvSchedule.CellDoubleClick -= dgvSchedule_CellDoubleClick;
            }
        }
        private void dgvSchedule_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0) return;
            if (cbScheduleGroup.SelectedItem == null) return;

            dynamic selectedGroup = cbScheduleGroup.SelectedItem;
            int groupID = selectedGroup.ID;

            int hourID = Convert.ToInt32(dgvSchedule.Rows[e.RowIndex].Tag);
            string colName = dgvSchedule.Columns[e.ColumnIndex].Name;
            int dayID = Convert.ToInt32(colName.Replace("Day_", ""));

            var cellValue = dgvSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
            {
                var result = MessageBox.Show("Are you sure you want to remove this lesson from the schedule?", "Remove Lesson", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        var cmd = new SqlCommand("delete from CourseSchedule where GroupID = @GroupID and DayID = @DayID and HourID = @HourID", conn);
                        cmd.Parameters.AddWithValue("@GroupID", groupID);
                        cmd.Parameters.AddWithValue("@DayID", dayID);
                        cmd.Parameters.AddWithValue("@HourID", hourID);
                        cmd.ExecuteNonQuery();
                    }
                    RefreshScheduleDisplay(groupID);
                }
            }
            else
            {
                using (var manualForm = new ManualAssignForm(groupID, dayID, hourID))
                {
                    if (manualForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshScheduleDisplay(groupID);
                    }
                }
            }
        }
    }
}