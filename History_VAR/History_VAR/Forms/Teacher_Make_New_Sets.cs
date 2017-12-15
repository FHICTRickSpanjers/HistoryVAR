using History_VAR.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public Teacher_Make_New_Sets(int lesson_id, bool edit, string username)
        {
            InitializeComponent();
            this.Logged_In_User = username;
            Activate_Update(edit);
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
            var Classes = DB.FindGroupData();
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
                //Get Teacher ID
                int Teacher_ID = DB.FindTeacherID(TB_Made_By.Text).TeacherIdentification;

                //Insert new Lesson
                Lesson L = new Lesson(TB_Title.Text, 0, CB_Lesson_Status.SelectedItem.ToString(), TB_Desc.Text, TB_Subject.Text, Teacher_ID);
                DB.CreateNewLesson(L);

                int Group_ID;

                //Get Group and Lesson ID
                if(CB_Classes.SelectedIndex == 0)
                {
                    int Lesson_ID = DB.FindLessonIDByName(TB_Title.Text);
                    //Insert Lesson into all groups (Using 0)
                    DB.InsertLessonForGroups(Lesson_ID, 0);

                    //Inserting Images into Lesson
                    Saving_Images_To_Lesson(Lesson_ID);

                }
                else
                {
                   Group_ID = DB.FindGroupID(CB_Classes.SelectedItem.ToString()).Get_Group_ID();
                   int Lesson_ID = DB.FindLessonIDByName(TB_Title.Text);
                   //Insert Lesson into chosen group
                   DB.InsertLessonForGroups(Lesson_ID, Group_ID);

                    //Inserting Images into Lesson
                    Saving_Images_To_Lesson(Lesson_ID);
                }
             
                MessageBox.Show("Saved lesson!");
            }  
        }



        private void Fill_Saved_Lesson_Data(int Lesson_ID)
        {
            //Open instance
            DBRepository DB = DBRepository.GetInstance();
            var Lesson = DB.GetLessonDataByID(Lesson_ID);

            try
            {
                //Get data
                string subject = Lesson.GetLessonSubject();
                string title = Lesson.GetLessonName();
                int Teacher_ID = Lesson.GetTeacherID();
                string desc = Lesson.GetLessonDesc();
                string status = Lesson.LessonStatus;

                //Fill the boxes with received DB data
                TB_Title.Text = title;
                TB_Subject.Text = subject;
                TB_Desc.Text = desc;
                TB_Made_By.Text = DB.FindTeacherName(Teacher_ID).GetTeacherName();
                CB_Lesson_Status.SelectedItem = status;

                //Get Group ID
                if (DB.FindGroupIDBasedOnLessonID(Lesson_ID).Get_Group_ID() != 0)
                {
                    int groupid = DB.FindGroupIDBasedOnLessonID(Lesson_ID).Get_Group_ID();
                    string groupname = DB.FindGroupDataBasedOnGroupID(groupid).GetGroupName();
                    CB_Classes.SelectedItem = groupname;
                }
                else
                {
                    CB_Classes.SelectedItem = "All";
                }

                //Get Images in Lesson
                var images = DB.ReceiveImagesInLesson(Lesson);

                foreach(var image in images)
                {
                    LB_Images.Items.Add(image.ReturnFileName());
                }

            }
            catch (NullReferenceException)
            {
                //Do nothing
            }    
        }




        private void UpdateLesson()
        {
            DBRepository DB = DBRepository.GetInstance();
            int Lesson_ID = DB.FindLessonIDByName(TB_Title.Text);
            Lesson L = new Lesson(TB_Title.Text, Lesson_ID, CB_Lesson_Status.SelectedItem.ToString(), TB_Desc.Text, TB_Subject.Text, 0);
            DB.UpdateLesson(L);

            //Get Group Information
            var Groups = DB.FindGroupData();
            int Group_ID = 0;

            foreach(var SGroup in Groups)
            {
                if(SGroup.GetGroupName() == CB_Classes.SelectedItem.ToString())
                {
                    Group_ID = SGroup.Get_Group_ID();
                }
            }

            //Delete previous groups that had this lesson
            DB.DeleteLessonAtGroupsByID(Lesson_ID);
            DB.DeleteImageFromLessonByID(Lesson_ID);

            //Add this lesson to the groups that currently have this lesson
            if(CB_Classes.SelectedItem.ToString() == "All")
            {
                DB.InsertLessonForGroups(Lesson_ID, 0);

                //Inserting Images into Lesson
                Saving_Images_To_Lesson(Lesson_ID);
            }
            else
            {
                DB.InsertLessonForGroups(Lesson_ID, Group_ID);

                //Inserting Images into Lesson
                Saving_Images_To_Lesson(Lesson_ID);
            }

            MessageBox.Show("Lesson Updated");
        }

        private void Activate_Update(bool editchar)
        {
            if (editchar == true)
            {
                btn_update.Enabled = true;
                btn_save_lesson.Enabled = false;
            }
        }

        private void btn_save_lesson_Click(object sender, EventArgs e)
        {
            SaveLesson();
        }

        private void btn_add_objects_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateLesson();
        }

        private void btn_add_images_Click(object sender, EventArgs e)
        {
            Add_Images_To_Lesson();
        }

        private void LB_Images_DoubleClick(object sender, EventArgs e)
        {
            LB_Images.Items.Remove(LB_Images.SelectedItem);
        }

        private void btn_Add_Image_to_system_Click(object sender, EventArgs e)
        {
            Add_Images_To_System();
        }



        private void Add_Images_To_System()
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bit = new Bitmap(open.FileName);
                    DBRepository DB = DBRepository.GetInstance();

                    byte[] arr;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bit.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        arr = ms.ToArray();
                    }

                    DB.InsertImageInDB(open.FileName, arr);

                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }

        }

        private void Add_Images_To_Lesson()
        {
            //Open instance
            DBRepository DB = DBRepository.GetInstance();
            
            //New instance of system images
            var SystemImages = new SystemImages();
            //Open Dialog for System images
            SystemImages.ShowDialog();
            //Get ID from Image to Add
            int ToAddImageID = SystemImages.ReturnImageID();


            var images = DB.ReceiveImagesFromDB();

            foreach (var image in images)
            {
                if (ToAddImageID == image.ReturnImageID())
                {
                    LB_Images.Items.Add(image.ReturnFileName());
                }
            }
        }


        public void Saving_Images_To_Lesson(int LessonID)
        {
            DBRepository DB = DBRepository.GetInstance();
            var images = DB.ReceiveImagesFromDB();
            foreach(var image in images)
            {
                foreach(string item in LB_Images.Items)
                {
                    if(image.ReturnFileName() == item)
                    {
                        DB.InsertImageInLesson(LessonID, image.ReturnImageID());
                    }
                }
            }
        }

    }
}
