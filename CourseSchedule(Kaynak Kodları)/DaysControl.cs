using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class DaysControl : UserControl
    {
        public DaysControl()
        {
            InitializeComponent();
            LoadDays();
        }

        private void LoadDays()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM tbl_Days", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dayTitleTextBox.Text))
            {
                MessageBox.Show("Please enter day title!");
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO tbl_Days (DayTitle) VALUES (@DayTitle)", conn);
                cmd.Parameters.AddWithValue("@DayTitle", dayTitleTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Day added successfully!");
                dayTitleTextBox.Clear();
                LoadDays();
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a day to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(dayTitleTextBox.Text))
            {
                MessageBox.Show("Please enter day title!");
                return;
            }

            int dayID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DayID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "UPDATE tbl_Days SET DayTitle = @DayTitle WHERE DayID = @DayID", conn);
                cmd.Parameters.AddWithValue("@DayTitle", dayTitleTextBox.Text);
                cmd.Parameters.AddWithValue("@DayID", dayID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Day updated successfully.");
                dayTitleTextBox.Clear();
                LoadDays();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a day to delete.");
                return;
            }

            int dayID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DayID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM tbl_Days WHERE DayID = @DayID", conn);
                    cmd.Parameters.AddWithValue("@DayID", dayID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Day deleted successfully.");
                    LoadDays();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete! This day is used in schedules.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DaysControl_Load(object sender, EventArgs e)
        {

        }
    }
}