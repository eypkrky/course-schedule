using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1("Admin");
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1("Student");
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }
    }
}