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
        private string Logged_In_User;

        public Teacher_Make_New_Sets(string username)
        {
            InitializeComponent();
            this.Logged_In_User = username;
            FillPresetData();
            GetClasses();
        }

        public Teacher_Make_New_Sets(int lesson_id, bool editchar)
        {
            InitializeComponent();
            Activate_Update(editchar);
            GetClasses();
            Fill_Saved_Lesson_Data(lesson_id);
        }

        private void FillPresetData()
        {
            TB_Made_By.Text = Logged_In_User;
            CB_Lesson_Status.SelectedIndex = 1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Teacher_Options = new Teacher_Options();
            Teacher_Options.Closed += (s, args) => this.Close();
            Teacher_Options.Show();
        }

        private void GetClasses()
        {
            DBRepository DB = DBRepository.GetInstance();
            var Classes = DB.Get_Group_Data();
            foreach(var Single_Class in Classes)
            {
                CB_Classes.Items.Add(Single_Class.GetGroupName());
            }
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
                int Teacher_ID = DB.Get_Teacher_ID(TB_Made_By.Text).TeacherIdentification;
                MessageBox.Show(Teacher_ID.ToString());
                DB.CreateNewLesson(TB_Subject.Text, Teacher_ID, TB_Title.Text, CB_Lesson_Status.SelectedItem.ToString(), TB_Desc.Text);
            }  
        }


        private void Fill_Saved_Lesson_Data(int Lesson_ID)
        {
            DBRepository DB = DBRepository.GetInstance();
            string subject = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_subject");
            string title = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_Name");
            int Teacher_ID = Convert.ToInt32(DB.Get_Lesson_Data_By_ID(Lesson_ID, "Teacher_ID"));
            string desc = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_description");
            string status = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_status");

            TB_Title.Text = title;
            TB_Subject.Text = subject;
            TB_Desc.Text = desc;
            TB_Made_By.Text = DB.Get_Teacher_Name(Teacher_ID).GetTeacherName();
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
