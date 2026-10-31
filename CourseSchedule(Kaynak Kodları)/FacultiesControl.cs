using MetroFramework.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class FacultiesControl : UserControl
    {
        public FacultiesControl()
        {
            InitializeComponent();
            LoadFaculties();
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            LoadFaculties();
        }

        private void LoadFaculties()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new Microsoft.Data.SqlClient.SqlCommand("select * from Faculties", conn);
                var adapter = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a faculty name.");
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(
                    "insert into Faculties (FacultyName) values (@FacultyName)", conn);
                cmd.Parameters.AddWithValue("@FacultyName", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Faculty added successfully.");
                textBox1.Text = "";
                LoadFaculties();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a faculty to delete.");
                return;
            }

            int facultyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FacultyID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new Microsoft.Data.SqlClient.SqlCommand(
                        "delete from Faculties where FacultyID = @FacultyID", conn);
                    cmd.Parameters.AddWithValue("@FacultyID", facultyID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Faculty deleted successfully.");
                    LoadFaculties();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete this faculty because it has related departments. Delete the departments first.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a faculty to update.");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a new faculty name.");
                return;
            }

            int FacultyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FacultyID"].Value);
            string newFacultyName = textBox1.Text;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(
                    "update Faculties set FacultyName = @newFacultyName where FacultyID = @FacultyID", conn);
                cmd.Parameters.AddWithValue("@newFacultyName", newFacultyName);
                cmd.Parameters.AddWithValue("@FacultyID", FacultyID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Faculty update successfully.");
                textBox1.Text = "";
                LoadFaculties();

            }
        }

        private void FacultiesControl_Load(object sender, EventArgs e)
        {

        }

        private void FacultiesControl_Load_1(object sender, EventArgs e)
        {

        }
    }
}

