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
    public partial class Teacher_Current_Sets : Form
    {
        private string Logged_In_User;

        public Teacher_Current_Sets(string username)
        {
            InitializeComponent();
            GetAllLessons();
            this.Logged_In_User = username;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Teacher_Screen = new Teacher_Options();
            Teacher_Screen.Closed += (s, args) => this.Close();
            Teacher_Screen.Show();
        }

        private void GetAllLessons()
        {
            CB_Lessons.Items.Clear();

            DBRepository DB = DBRepository.GetInstance();
            var lessons = DB.FindLessonsData();
            foreach(var single_lesson in lessons)
            {
                CB_Lessons.Items.Add(single_lesson.GetLessonName());
            }
        }

        private void DeleteLesson()
        {
            if(CB_Lessons.SelectedIndex > -1)
            {
                DBRepository DB = DBRepository.GetInstance();
                int Lesson_ID = DB.FindLessonIDByName(CB_Lessons.SelectedItem.ToString());
                DB.DeleteLessonByID(Lesson_ID);
                DB.DeleteLessonAtGroupsByID(Lesson_ID);
                GetAllLessons();
            }
            else
            {
                MessageBox.Show("Select item to delete");
            }
 
        }

        private void EditLesson()
        {
            if (CB_Lessons.SelectedIndex > -1)
            {
                DBRepository DB = DBRepository.GetInstance();
                int lesson_id = DB.FindLessonIDByName(CB_Lessons.SelectedItem.ToString());
                bool editchar = true;

                this.Hide();
                var make_new_lesson = new Teacher_Make_New_Sets(lesson_id, editchar, Logged_In_User);
                make_new_lesson.Closed += (s, args) => this.Close();
                make_new_lesson.Show();

            }
            else
            {

            }
        }


        private void ChangeStatusLesson()
        {
            if (CB_Lessons.SelectedIndex > -1)
            {
                DBRepository DB = DBRepository.GetInstance();
                var Status = DB.FindLessonByID(DB.FindLessonIDByName(CB_Lessons.SelectedItem.ToString()));
                if (Status.LessonStatus == "Published")
                {
                    DB.UpdateLessonStatusByID(CB_Lessons.SelectedIndex + 1, "Draft");
                }
                else if (Status.LessonStatus == "Draft")
                {
                    DB.UpdateLessonStatusByID(CB_Lessons.SelectedIndex + 1, "Published");
                }
            }
            else
            {

            }
        }


        private void btn_publish_Click(object sender, EventArgs e)
        {
            ChangeStatusLesson();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteLesson();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditLesson();
        }
    }
}
