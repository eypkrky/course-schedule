using MetroFramework.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseSchedule
{
    public partial class ClassroomsControl : UserControl
    {
        public ClassroomsControl()
        {
            InitializeComponent();
            LoadClassroomTypes();
            LoadClassrooms();
        }

        private void ClassroomControl_Load(object sender, EventArgs e)
        {
            LoadClassroomTypes();
            LoadClassrooms();
        }

        private void LoadClassroomTypes()
        {
            TypeCombo.Items.Clear();
            TypeCombo.Items.Add("Normal");
            TypeCombo.Items.Add("Lab");
        }

        private void LoadClassrooms()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("select * from Classrooms", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (ClassroomName.Text == "" || TypeCombo.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            int capacity = (int)CapacityNumberic.Value;
            string classType = TypeCombo.SelectedItem?.ToString() ?? "";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "insert into Classrooms (ClassroomName, Capacity, ClassType) values (@ClassroomName, @Capacity, @ClassType)", conn);
                cmd.Parameters.AddWithValue("@ClassroomName", ClassroomName.Text);
                cmd.Parameters.AddWithValue("@Capacity", capacity);
                cmd.Parameters.AddWithValue("@ClassType", classType);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Classroom added successfully!");

                ClassroomName.Text = "";
                CapacityNumberic.Value = 0;
                TypeCombo.SelectedIndex = -1;
                LoadClassrooms();
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a classroom to update.");
                return;
            }

            if (ClassroomName.Text == "" || TypeCombo.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            int ClassroomID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ClassroomID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "update Classrooms set ClassroomName = @ClassroomName, Capacity = @Capacity, ClassType = @ClassType where ClassroomID = @ClassroomID", conn);
                cmd.Parameters.AddWithValue("@ClassroomName", ClassroomName.Text);
                cmd.Parameters.AddWithValue("@Capacity", (int)CapacityNumberic.Value);
                cmd.Parameters.AddWithValue("@ClassType", TypeCombo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ClassroomID", ClassroomID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Classroom updated successfully.");

                ClassroomName.Text = "";
                CapacityNumberic.Value = 0;
                TypeCombo.SelectedIndex = -1;
                LoadClassrooms();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a classroom to delete.");
                return;
            }

            int ClassroomID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ClassroomID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "delete from Classrooms where ClassroomID = @ClassroomID", conn);
                    cmd.Parameters.AddWithValue("@ClassroomID", ClassroomID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Classroom deleted successfully.");
                    LoadClassrooms();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // SQL Foreign Key (İlişki) Hatası
                {
                    MessageBox.Show("Cannot delete! This classroom is currently assigned to a lesson in the schedule. Please remove it from the schedule first.", "Delete Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClassroomsControl_Load(object sender, EventArgs e)
        {

        }
    }
}