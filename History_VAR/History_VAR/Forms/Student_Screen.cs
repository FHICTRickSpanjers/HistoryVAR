using History_VAR.Classes;
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
    public partial class Student_Screen : Form
    {
        //The name of the user that is currently logged in
        private string Logged_In_User;

        /// <summary>
        /// Constructor for the student screen
        /// </summary>
        /// <param name="user">Receives the name of the logged in user</param>
        public Student_Screen(string user)
        {
            InitializeComponent();

            //Set the username
            this.Logged_In_User = user;

            //Get all the lessons that are available for the user
            GetAllAvailableLessons();
        }


        /// <summary>
        /// When clicking the back button you return to the previous screen and close this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            //Back to previous screen
            this.Hide();
            var User_Selection = new User_Login();
            User_Selection.Closed += (s, args) => this.Close();
            User_Selection.Show();
        }


        /// <summary>
        /// Get all the available lessons
        /// </summary>
        private void GetAllAvailableLessons()
        {
            //Get DB instance
            DBRepository DB = DBRepository.GetInstance();
            //Get list of students
            var students = DB.FindStudentDetails();
            int StudentID = 0;

            //Foreach student in the list of students
            foreach (var single_student in students)
            {
                //If the user equals the logged in user
                if (Logged_In_User == single_student.GetStudentName())
                {
                    //Get student ID
                    StudentID = single_student.GetStudentID();
                }
            }

            //Get Studentgroup, Lessons for the group, lessons for all groups
            var StudentGroup = DB.FindGroupIDBasedOnStudent(StudentID);
            var GroupLessons = DB.GetLessonsBasedOnGroupID(StudentGroup.Get_Group_ID());
            var GroupLessonsForAll = DB.GetLessonsBasedOnGroupID(0);

            //Make a Textbox and button for every lesson that is available
            foreach (var single_lesson in GroupLessons)
            {
                if(single_lesson.LessonStatus == "Published")
                {
                    TextBox tb = new TextBox();
                    tb.Text = single_lesson.GetLessonName();
                    tb.AutoSize = false;
                    tb.ReadOnly = true;
                    tb.Size = new System.Drawing.Size(400, 35);
                    tb.Font = new Font(tb.Font.FontFamily, 14);

                    Button B = new Button();
                    B.Text = "Open";
                    B.Size = new System.Drawing.Size(75, 35);
                    B.Name = single_lesson.GetLessonName();
                    
                    //Click function on the added button that closes the screen and opens a new one
                    B.Click += (s, e) => {

                        this.Hide();
                        var show_lesson = new Student_Show_Lesson(B.Name, Logged_In_User);
                        show_lesson.Closed += (x, args) => this.Close();
                        show_lesson.Show();

                    };

                    //Add to the panel
                    FlowLayoutPanelLessons.Controls.Add(tb);
                    FlowLayoutPanelLessons.Controls.Add(B);
                }             
            }

            //Do the same as before just for lessons available for all groups
            foreach(var single_open_lesson in GroupLessonsForAll)
            {
                if(single_open_lesson.LessonStatus == "Published")
                {
                    //Make new textbox
                    TextBox tb = new TextBox();
                    tb.Text = single_open_lesson.GetLessonName();
                    tb.AutoSize = false;
                    tb.ReadOnly = true;
                    tb.Size = new System.Drawing.Size(400, 35);
                    tb.Font = new Font(tb.Font.FontFamily, 14);


                    //Make new button
                    Button B = new Button();
                    B.Text = "Open";
                    B.Size = new System.Drawing.Size(75, 35);
                    B.Name = single_open_lesson.GetLessonName();

                    //Click function on the added button that closes the screen and opens a new one
                    B.Click += (s, e) => {

                        this.Hide();
                        var show_lesson = new Student_Show_Lesson(B.Name, Logged_In_User);
                        show_lesson.Closed += (x, args) => this.Close();
                        show_lesson.Show();

                    };

                    //Add to the panel
                    FlowLayoutPanelLessons.Controls.Add(tb);
                    FlowLayoutPanelLessons.Controls.Add(B);
                }
            }
        }
    }
}
