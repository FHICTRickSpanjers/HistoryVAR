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
        /// <summary>
        /// Name of the currently logged in Teacher
        /// </summary>
        private string Logged_In_User;


        /// <summary>
        /// Constructor that needs a username
        /// </summary>
        /// <param name="username"></param>
        public Teacher_Current_Sets(string username)
        {
            InitializeComponent();

            //Get all the lessons the teacher has made
            GetAllLessons();

            //Set the logged in character name;
            this.Logged_In_User = username;
        }


        /// <summary>
        /// Btn that returns to the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            //Close the current form
            this.Hide();

            //Open instance of another form
            var Teacher_Screen = new Teacher_Options();

            //Open the new form
            Teacher_Screen.Closed += (s, args) => this.Close();
            Teacher_Screen.Show();
        }

        /// <summary>
        /// Get all the lessons the teacher has made
        /// </summary>
        private void GetAllLessons()
        {
            //Clear the List of lessons
            CB_Lessons.Items.Clear();

            //Open instance for the DB class
            DBRepository DB = DBRepository.GetInstance();

            //Get all the lessons
            var lessons = DB.FindLessonsData();

            //For every found lesson do the following
            foreach(var single_lesson in lessons)
            {
                //Add leson to the list of lessons
                CB_Lessons.Items.Add(single_lesson.GetLessonName());
            }
        }

        /// <summary>
        /// Delete a lesson made by the teacher
        /// </summary>
        private void DeleteLesson()
        {
            //If a lesson has been selected
            if(CB_Lessons.SelectedIndex > -1)
            {
                //Open new instance of db class
                DBRepository DB = DBRepository.GetInstance();

                //Find the lesson by ID
                int Lesson_ID = DB.FindLessonIDByName(CB_Lessons.SelectedItem.ToString());

                //Delete this lesson from the lessons and from the Groups
                DB.DeleteLessonByID(Lesson_ID);
                DB.DeleteLessonAtGroupsByID(Lesson_ID);

                //Get new list of lessons
                GetAllLessons();
            }
            else
            {
                MessageBox.Show("Select item to delete");
            }
 
        }

        /// <summary>
        /// Edit a lesson
        /// </summary>
        private void EditLesson()
        {
            //If a lesson has been selected
            if (CB_Lessons.SelectedIndex > -1)
            {
                //Open new instance of DB class
                DBRepository DB = DBRepository.GetInstance();

                //Get Lesson ID by Lesson Name
                int lesson_id = DB.FindLessonIDByName(CB_Lessons.SelectedItem.ToString());
                bool editchar = true;

                //Hide this form and open the "Make a new lesson" Form
                this.Hide();
                var make_new_lesson = new Teacher_Make_New_Sets(lesson_id, editchar, Logged_In_User);
                make_new_lesson.Closed += (s, args) => this.Close();
                make_new_lesson.Show();

            }
            else
            {

            }
        }


        /// <summary>
        /// Change the status of the lesson (Published / draft)
        /// </summary>
        private void ChangeStatusLesson()
        {
            //If a lesson has been selected
            if (CB_Lessons.SelectedIndex > -1)
            {
                //Make a new instance of the DB class
                DBRepository DB = DBRepository.GetInstance();

                //Get the current status by the ID of the lesson
                var Status = DB.FindLessonByID(DB.FindLessonIDByName(CB_Lessons.SelectedItem.ToString()));

                //If status is published
                if (Status.LessonStatus == "Published")
                {
                    //Update the status to Draft
                    DB.UpdateLessonStatusByID(CB_Lessons.SelectedIndex + 1, "Draft");
                }

                //If status is draft
                else if (Status.LessonStatus == "Draft")
                {
                    //Update the status to published
                    DB.UpdateLessonStatusByID(CB_Lessons.SelectedIndex + 1, "Published");
                }
            }
            else
            {

            }
        }

        /// <summary>
        /// Publish button eventhandler on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_publish_Click(object sender, EventArgs e)
        {
            //Change status of the lesson
            ChangeStatusLesson();
        }

        /// <summary>
        /// Delete button eventhandler on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //Delete a lesson
            DeleteLesson();
        }

        /// <summary>
        /// Editing a lesson (btn eventhandler on click)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            //Editing a lesson
            EditLesson();
        }
    }
}
