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
            var students = DB.FindStudentDetails();
            int StudentID = 0;

            foreach (var single_student in students)
            {
                if (Logged_In_User == single_student.GetStudentName())
                {
                    StudentID = single_student.GetStudentID();
                }
            }

            var StudentGroup = DB.FindGroup0IDBasedOnStudent(StudentID);
            var GroupLessons = DB.GetLessonsBasedOnGroupID(StudentGroup.Get_Group_ID());
            var GroupLessonsForAll = DB.GetLessonsBasedOnGroupID(0);

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

            foreach(var single_open_lesson in GroupLessonsForAll)
            {
                if(single_open_lesson.LessonStatus == "Published")
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
}
