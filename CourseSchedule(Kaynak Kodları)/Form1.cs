using Microsoft.Data.SqlClient;
using MetroFramework.Forms;
using System.Linq;

namespace CourseSchedule
{
    public partial class Form1 : MetroForm
    {
        public static string UserRole = "Admin";

        public Form1(string role) // <-- İşte hatayı çözen o 1 parametre burası!
        {
            InitializeComponent();
            UserRole = role;

            if (UserRole == "Student")
            {
                Faculties_Button.Visible = false;
                Departments_Button.Visible = false;
                Teachers_Button.Visible = false;
                Lessons_Button.Visible = false;
                Groups_Button.Visible = false;
                Classrooms_Button.Visible = false;
                Hours_Button.Visible = false;
                Days_Button.Visible = false;

                LoadControl(new CourseScheduleControl());
            }
            else
            {

            }
        }

        private void LoadControl(UserControl uc)
        {
            mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }

        private void CloseOtherForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == "FacultyForm" ||
                    form.GetType().Name == "DepartmentsForm" ||
                    form.GetType().Name == "TeacherForm" ||
                    form.GetType().Name == "LessonForm" ||
                    form.GetType().Name == "StudentGroupForm" ||
                    form.GetType().Name == "ClassroomForm")
                {
                    form.Close();
                    break;
                }
            }
        }
        private void Faculties_Button_Click(object sender, EventArgs e)
        {
            LoadControl(new FacultiesControl());
        }

        private void Departments_Button_Click(object sender, EventArgs e)
        {
            LoadControl(new DepartmentsControl());
        }
        private void Teachers_Button_Click(object sender, EventArgs e)
        {
            LoadControl(new TeachresControl());
        }
        private void Lessons_Button_Click(object sender, EventArgs e)
        {
            LoadControl(new LessonsControl());
        }

        private void Groups_Button_Click(object sender, EventArgs e)
        {
            LoadControl(new GroupsControl());
        }

        private void Classrooms_Button_Click(object sender, EventArgs e)
        {
            LoadControl(new ClassroomsControl());
        }

        private void CourseSchedule_Button_Click(object sender, EventArgs e)
        {
            LoadControl(new CourseScheduleControl());
        }
        private void Hours_Button_Click(object sender, EventArgs e)
        {
            LoadControl(new HourIntervalControl());
        }
        private void Days_Button_Click(object sender, EventArgs e)
        {
            LoadControl(new DaysControl());
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

