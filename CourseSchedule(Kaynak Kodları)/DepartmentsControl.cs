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
    public partial class DepartmentsControl : UserControl
    {
        public DepartmentsControl()
        {
            InitializeComponent();
            LoadFaculties();
            LoadDepartments();
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            LoadFaculties();
            LoadDepartments();
        }

        private void LoadFaculties()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new Microsoft.Data.SqlClient.SqlCommand("select FacultyID, FacultyName from Faculties", conn);
                var reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(new { ID = reader["FacultyID"], Name = reader["FacultyName"].ToString() });
                }
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
            }
        }

        private void LoadDepartments()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(
                    "select d.DepartmentID, d.DepartmentName, f.FacultyName from Departments d join Faculties f on d.FacultyID = f.FacultyID", conn);
                var adapter = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please enter department name and select a faculty.");
                return;
            }

            dynamic selectedFaculty = comboBox1.SelectedItem;
            int FacultyID = selectedFaculty.ID;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(
                    "insert into Departments (DepartmentName, FacultyID) values (@DepartmentName, @FacultyId)", conn);
                cmd.Parameters.AddWithValue("@DepartmentName", textBox1.Text);
                cmd.Parameters.AddWithValue("@FacultyId", FacultyID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Department added successfully.");
                textBox1.Text = "";
                comboBox1.SelectedIndex = -1;
                LoadDepartments();
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a faculty to update.");
                return;
            }

            if (textBox1.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please enter a new faculty name.");
                return;
            }

            int DepartmentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DepartmentID"].Value);
            string newDepartmentName = textBox1.Text;
            dynamic selectedFaculty = comboBox1.SelectedItem;
            int FacultyID = selectedFaculty.ID;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(
                    "update Departments set DepartmentName = @newDepartmentName where DepartmentID = @DepartmentID", conn);
                cmd.Parameters.AddWithValue("@newDepartmentName", newDepartmentName);
                cmd.Parameters.AddWithValue("@FacultyID", FacultyID);
                cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Department update successfully.");
                textBox1.Text = "";
                comboBox1.SelectedIndex = -1;
                LoadDepartments();

            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a department to delete.");
                return;
            }

            int departmentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DepartmentID"].Value);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new Microsoft.Data.SqlClient.SqlCommand(
                    "delete from Departments where DepartmentID = @DepartmentID", conn);
                    cmd.Parameters.AddWithValue("@DepartmentID", departmentID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department deleted successfully.");
                    LoadDepartments();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign Key hatası
                {
                    MessageBox.Show("Cannot delete! This record has related data in other tables.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DepartmentsControl_Load(object sender, EventArgs e)
        {

        }
    }
}

