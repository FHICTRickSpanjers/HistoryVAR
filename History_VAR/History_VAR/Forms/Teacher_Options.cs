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
        //Name of the currently logged in teacher
        private string Logged_In_User;

        /// <summary>
        /// Constructor teacher options (username needed)
        /// </summary>
        /// <param name="username"></param>
        public Teacher_Options(string username)
        {
            InitializeComponent();

            //Set logged in username
            this.Logged_In_User = username;
        }

        /// <summary>
        /// Empty constructor for Teacher Options
        /// </summary>
        public Teacher_Options()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create lesson button (eventhandler click)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_create_lesson_Click(object sender, EventArgs e)
        {
            //Hide this form
            this.Hide();

            //Create new instance of form
            var Create_Lesson = new Teacher_Make_New_Sets(Logged_In_User);
            Create_Lesson.Closed += (s, args) => this.Close();

            //Open new form
            Create_Lesson.Show();
        }


        /// <summary>
        /// Show all the lessons (eventhandler click)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_show_all_lessons_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();

            //Make instance of new form
            var Current_Lessons = new Teacher_Current_Sets(Logged_In_User);
            Current_Lessons.Closed += (s, args) => this.Close();

            //Open new form
            Current_Lessons.Show();
        }

        /// <summary>
        /// Logout user (eventhandler click)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();

            //Make instance of new form
            var userlogin= new User_Login();
            userlogin.Closed += (s, args) => this.Close();

            //Open new form
            userlogin.Show();
        }
    }
}
