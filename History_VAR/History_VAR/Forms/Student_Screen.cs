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
        private string Logged_In_User;

        public Student_Screen(string user)
        {
            InitializeComponent();
            this.Logged_In_User = user;
            GetAllAvailableLessons();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Back to previous screen
            this.Hide();
            var User_Selection = new User_Login();
            User_Selection.Closed += (s, args) => this.Close();
            User_Selection.Show();
        }


        private void GetAllAvailableLessons()
        {
            DBRepository DB = DBRepository.GetInstance();
            var students = DB.GetStudentDetails();
            int StudentID = 0;

            foreach (var single_student in students)
            {
                if (Logged_In_User == single_student.GetStudentName())
                {
                    StudentID = single_student.GetStudentID();
                }
            }

            var StudentGroup = DB.Get_Group_ID_Based_On_Student(StudentID);
            var GroupLessons = DB.Get_Lessons_Based_On_GroupID(StudentGroup.Get_Group_ID());
            var GroupLessonsForAll = DB.Get_Lessons_Based_On_GroupID(0);

            foreach (var single_lesson in GroupLessons)
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

                B.Click += (s, e) => {

                    this.Hide();
                    var show_lesson = new Student_Show_Lesson(B.Name, Logged_In_User);
                    show_lesson.Closed += (x, args) => this.Close();
                    show_lesson.Show();

                };

                FlowLayoutPanelLessons.Controls.Add(tb);
                FlowLayoutPanelLessons.Controls.Add(B);
            }

            foreach(var single_open_lesson in GroupLessonsForAll)
            {
                TextBox tb = new TextBox();
                tb.Text = single_open_lesson.GetLessonName();
                tb.AutoSize = false;
                tb.ReadOnly = true;
                tb.Size = new System.Drawing.Size(400, 35);
                tb.Font = new Font(tb.Font.FontFamily, 14);

                Button B = new Button();
                B.Text = "Open";
                B.Size = new System.Drawing.Size(75, 35);
                B.Name = single_open_lesson.GetLessonName();

                B.Click += (s, e) => {

                    this.Hide();
                    var show_lesson = new Student_Show_Lesson(B.Name, Logged_In_User);
                    show_lesson.Closed += (x, args) => this.Close();
                    show_lesson.Show();

                };

                FlowLayoutPanelLessons.Controls.Add(tb);
                FlowLayoutPanelLessons.Controls.Add(B);
            }


        }
    }
}
