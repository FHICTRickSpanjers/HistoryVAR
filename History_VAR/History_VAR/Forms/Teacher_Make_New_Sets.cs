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
    public partial class Teacher_Make_New_Sets : Form
    {
        public Teacher_Make_New_Sets()
        {
            InitializeComponent();
            CB_Lesson_Status.SelectedIndex = 1;
        }

        public Teacher_Make_New_Sets(int lesson_id, bool editchar)
        {
            InitializeComponent();
            Activate_Update(editchar);
            Fill_Saved_Lesson_Data(lesson_id);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Teacher_Options = new Teacher_Options();
            Teacher_Options.Closed += (s, args) => this.Close();
            Teacher_Options.Show();
        }


        private void SaveLesson()
        {
            DBRepository DB = DBRepository.GetInstance();

            if (string.IsNullOrEmpty(TB_Title.Text) || string.IsNullOrEmpty(TB_Subject.Text) || string.IsNullOrEmpty(TB_Made_By.Text) || string.IsNullOrEmpty(TB_Desc.Text))
            {
                MessageBox.Show("Not everything has been filled!");
            }
            else
            {
                DB.CreateNewLesson(TB_Subject.Text, 1, TB_Title.Text, CB_Lesson_Status.SelectedItem.ToString(), TB_Desc.Text);
            }  
        }


        private void Fill_Saved_Lesson_Data(int Lesson_ID)
        {
            DBRepository DB = DBRepository.GetInstance();
            string subject = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_subject");
            string title = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_Name");
            string desc = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_description");
            string status = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_status");

            TB_Title.Text = title;
            TB_Subject.Text = subject;
            TB_Desc.Text = desc;
            CB_Lesson_Status.SelectedItem = status;
        }


        private void Update_Lesson()
        {
            DBRepository DB = DBRepository.GetInstance();
            int Lesson_ID = DB.GetLessonID(TB_Title.Text);
            DB.UpdateLesson(Lesson_ID, TB_Subject.Text, TB_Title.Text, CB_Lesson_Status.SelectedItem.ToString(), TB_Desc.Text);
            MessageBox.Show("Lesson Updated");
        }

        private void btn_save_lesson_Click(object sender, EventArgs e)
        {
            SaveLesson();
        }

        private void btn_add_objects_Click(object sender, EventArgs e)
        {

        }

        private void Activate_Update(bool editchar)
        {
            if (editchar == true)
            {
               btn_update.Enabled = true;
               btn_save_lesson.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update_Lesson();
        }
    }
}
