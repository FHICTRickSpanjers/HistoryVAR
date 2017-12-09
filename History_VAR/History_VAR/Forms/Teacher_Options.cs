using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History_VAR.Forms
{
    public partial class Teacher_Options : Form
    {
        private string Logged_In_User;

        public Teacher_Options(string username)
        {
            InitializeComponent();
            this.Logged_In_User = username;
        }
        public Teacher_Options()
        {
            InitializeComponent();
        }

        private void btn_create_lesson_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Create_Lesson = new Teacher_Make_New_Sets(Logged_In_User);
            Create_Lesson.Closed += (s, args) => this.Close();
            Create_Lesson.Show();
        }

        private void btn_show_all_lessons_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Current_Lessons = new Teacher_Current_Sets();
            Current_Lessons.Closed += (s, args) => this.Close();
            Current_Lessons.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userselect = new User_Selection();
            userselect.Closed += (s, args) => this.Close();
            userselect.Show();
        }
    }
}
