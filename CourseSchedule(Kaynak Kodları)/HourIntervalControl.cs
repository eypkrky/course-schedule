using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class HourIntervalControl : UserControl
    {
        public HourIntervalControl()
        {
            InitializeComponent();
            LoadHours();
        }

        private void LoadHours()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM tbl_Hours ORDER BY OrderNo", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hourIntervalTextBox.Text))
            {
                MessageBox.Show("Please enter hour interval!");
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO tbl_Hours (HourInterval, OrderNo) VALUES (@HourInterval, @OrderNo)", conn);
                cmd.Parameters.AddWithValue("@HourInterval", hourIntervalTextBox.Text);
                cmd.Parameters.AddWithValue("@OrderNo", (int)orderNoNumeric.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hour added successfully!");
                hourIntervalTextBox.Clear();
                orderNoNumeric.Value = 0;
                LoadHours();
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an hour to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(hourIntervalTextBox.Text))
            {
                MessageBox.Show("Please enter hour interval!");
                return;
            }

            int hourID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["HourID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "UPDATE tbl_Hours SET HourInterval = @HourInterval, OrderNo = @OrderNo WHERE HourID = @HourID", conn);
                cmd.Parameters.AddWithValue("@HourInterval", hourIntervalTextBox.Text);
                cmd.Parameters.AddWithValue("@OrderNo", (int)orderNoNumeric.Value);
                cmd.Parameters.AddWithValue("@HourID", hourID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hour updated successfully.");
                hourIntervalTextBox.Clear();
                orderNoNumeric.Value = 0;
                LoadHours();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an hour to delete.");
                return;
            }

            int hourID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["HourID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM tbl_Hours WHERE HourID = @HourID", conn);
                    cmd.Parameters.AddWithValue("@HourID", hourID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hour deleted successfully.");
                    LoadHours();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete! This hour is used in schedules.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}