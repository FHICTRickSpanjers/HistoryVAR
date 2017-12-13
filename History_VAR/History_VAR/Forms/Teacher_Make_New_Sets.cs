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

        public Teacher_Make_New_Sets(int lesson_id, bool edit)
        {
            InitializeComponent();
            Activate_Update(edit);
            GetClasses();
            Fill_Saved_Lesson_Data(lesson_id);
        }

        public Teacher_Make_New_Sets(int I)
        {
            InitializeComponent();
            Add_Images_To_Lesson(I);
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
                //Get Teacher ID
                int Teacher_ID = DB.Get_Teacher_ID(TB_Made_By.Text).TeacherIdentification;

                //Insert new Lesson
                DB.CreateNewLesson(TB_Subject.Text, Teacher_ID, TB_Title.Text, CB_Lesson_Status.SelectedItem.ToString(), TB_Desc.Text);

                int Group_ID;

                //Get Group and Lesson ID
                if(CB_Classes.SelectedIndex == 0)
                {
                    int Lesson_ID = DB.GetLessonID(TB_Title.Text);
                    //Insert Lesson into all groups (Using 0)
                    DB.Insert_Lesson_For_Groups(Lesson_ID, 0);
                }
                else
                {
                   Group_ID = DB.Get_Group_ID(CB_Classes.SelectedItem.ToString()).Get_Group_ID();
                   int Lesson_ID = DB.GetLessonID(TB_Title.Text);
                   //Insert Lesson into chosen group
                   DB.Insert_Lesson_For_Groups(Lesson_ID, Group_ID);
                }
             
                MessageBox.Show("Saved lesson!");
            }  
        }


        private void Fill_Saved_Lesson_Data(int Lesson_ID)
        {
            //Open instance
            DBRepository DB = DBRepository.GetInstance();

            try
            {
                //Get data
                string subject = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_subject");
                string title = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_Name");
                int Teacher_ID = Convert.ToInt32(DB.Get_Lesson_Data_By_ID(Lesson_ID, "Teacher_ID"));
                string desc = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_description");
                string status = DB.Get_Lesson_Data_By_ID(Lesson_ID, "Lesson_status");

                //Fill the boxes with received DB data
                TB_Title.Text = title;
                TB_Subject.Text = subject;
                TB_Desc.Text = desc;
                TB_Made_By.Text = DB.Get_Teacher_Name(Teacher_ID).GetTeacherName();
                CB_Lesson_Status.SelectedItem = status;

                //Get Group ID
                if (DB.Get_Group_ID_Based_On_Lesson_ID(Lesson_ID).Get_Group_ID() != 0)
                {
                    int groupid = DB.Get_Group_ID_Based_On_Lesson_ID(Lesson_ID).Get_Group_ID();
                    string groupname = DB.Get_Group_Data_Based_On_GroupID(groupid).GetGroupName();
                    CB_Classes.SelectedItem = groupname;
                }
                else
                {
                    CB_Classes.SelectedItem = "All";
                }
            }
            catch (NullReferenceException)
            {
                //Do nothing
            }    
        }


        private void Add_Images_To_Lesson(int ImageID)
        {
            //Open instance
            DBRepository DB = DBRepository.GetInstance();
            var images = DB.Receive_Images_From_DB();
            foreach(var image in images)
            {
                if(ImageID == image.ReturnImageID())
                {
                    MessageBox.Show(image.ReturnFileName());
                    LB_Images.Items.Add(image.ReturnFileName());
                    Console.WriteLine(image.ReturnFileName());
                }  
            }
        }


        private void Update_Lesson()
        {
            DBRepository DB = DBRepository.GetInstance();
            int Lesson_ID = DB.GetLessonID(TB_Title.Text);
            DB.UpdateLesson(Lesson_ID, TB_Subject.Text, TB_Title.Text, CB_Lesson_Status.SelectedItem.ToString(), TB_Desc.Text);

            //Get Group Information
            var Groups = DB.Get_Group_Data();
            int Group_ID = 0;

            foreach(var SGroup in Groups)
            {
                if(SGroup.GetGroupName() == CB_Classes.SelectedItem.ToString())
                {
                    Group_ID = SGroup.Get_Group_ID();
                }
            }

            //Delete previous groups that had this lesson
            DB.Delete_Lesson_At_Groups_By_ID(Lesson_ID);

            //Add this lesson to the groups that currently have this lesson
            if(CB_Classes.SelectedItem.ToString() == "All")
            {
                DB.Insert_Lesson_For_Groups(Lesson_ID, 0);
            }
            else
            {
                DB.Insert_Lesson_For_Groups(Lesson_ID, Group_ID);
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
            Update_Lesson();
        }


        private void Add_Images_To_System()
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg";
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

                    DB.Insert_Image_In_DB(open.FileName, arr);

                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }

        }

        private void Add_Images_To_Current_Lesson()
        {
            var SystemImages = new SystemImages();
            SystemImages.Show();
        }

        private void btn_add_images_Click(object sender, EventArgs e)
        {
            Add_Images_To_Current_Lesson();

        }

        private void LB_Images_DoubleClick(object sender, EventArgs e)
        {
            LB_Images.Items.Remove(LB_Images.SelectedItem);
        }

        private void btn_Add_Image_to_system_Click(object sender, EventArgs e)
        {
            Add_Images_To_System();
        }
    }
}
