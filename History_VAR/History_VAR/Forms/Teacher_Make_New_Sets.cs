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
        //Set the name of the currently logged in teacher
        private string Logged_In_User;
        private int LessonToEditID;

        /// <summary>
        /// Constructor make new lesson
        /// </summary>
        /// <param name="username">username of the currently logged in teacher</param>
        public Teacher_Make_New_Sets(string username)
        {
            InitializeComponent();

            //Set the currently logged in user
            this.Logged_In_User = username;

            //Fill the preset data
            FillPresetData();

            //Get classes from the database
            GetClasses();
            GetArt();
        }


        /// <summary>
        /// Constructor make a new lesson (needs an ID, Boolean Edit and username)
        /// </summary>
        /// <param name="lesson_id">Lesson ID</param>
        /// <param name="edit">Boolean (is this an update or new)</param>
        /// <param name="username">Username string</param>
        public Teacher_Make_New_Sets(int lesson_id, bool edit, string username)
        {
            InitializeComponent();

            //Set the currently logged in teacher
            this.Logged_In_User = username;

            //Activate the update functionalities (using the boolean edit)
            Activate_Update(edit);

            //Get all the classes (from the database)
            GetClasses();
            GetArt();

            //Fill saved lesson data
            Fill_Saved_Lesson_Data(lesson_id);
        }


        /// <summary>
        /// Fill the preset data
        /// </summary>
        private void FillPresetData()
        {
            //Adds loggedin user
            TB_Made_By.Text = Logged_In_User;

            //Set status for the lesson
            CB_Lesson_Status.SelectedIndex = 1;

            //
        }


        /// <summary>
        /// Return to the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Hide();

            //Make new instance of other form
            var Teacher_Options = new Teacher_Options();
            Teacher_Options.Closed += (s, args) => this.Close();

            //Open new form
            Teacher_Options.Show();
        }

        /// <summary>
        /// Get classes from DB
        /// </summary>
        private void GetClasses()
        {
            //New instance of DB
            DBRepository DB = DBRepository.GetInstance();

            //Get all the classes from the DB
            var Classes = DB.FindGroupData();

            //Foreach class in classes
            foreach(var Single_Class in Classes)
            {
                //Add items to class list
                CB_Classes.Items.Add(Single_Class.GetGroupName());
            }
        }

        private void GetArt()
        {
            //New instance of DB
            DBRepository DB = DBRepository.GetInstance();

            //Get all the classes from the DB
            var Art = DB.FindArtData();

            //Foreach class in classes
            foreach (var Single_Art in Art)
            {
                //Add items to class list
                CB_Art.Items.Add(Single_Art.ReturnArtTitle());
            }
        }



        /// <summary>
        /// Saving a new lesson
        /// </summary>
        private void SaveLesson()
        {
            //Make new instance of DB class
            DBRepository DB = DBRepository.GetInstance();


            //Check if the Textboxes are empty
            if (string.IsNullOrEmpty(TB_Title.Text) || string.IsNullOrEmpty(TB_Subject.Text) || string.IsNullOrEmpty(TB_Made_By.Text) || string.IsNullOrEmpty(TB_Desc.Text))
            {
                MessageBox.Show("Not everything has been filled!");
            }
            //If not empty
            else
            {
                //Get Teacher ID
                int Teacher_ID = DB.FindTeacherID(TB_Made_By.Text).TeacherIdentification;

                //Insert new Lesson
                Lesson L = new Lesson(TB_Title.Text, 0, CB_Lesson_Status.SelectedItem.ToString(), TB_Desc.Text, TB_Subject.Text, Teacher_ID);
                DB.CreateNewLesson(L);

                //Necessary for which group to save to
                int Group_ID;

                //Get Group and Lesson ID
                if(CB_Classes.SelectedIndex == 0)
                {
                    int Lesson_ID = DB.FindLessonIDByName(TB_Title.Text);
                    //Insert Lesson into all groups (Using 0)
                    DB.InsertLessonForGroups(Lesson_ID, 0);

                    //Inserting Images into Lesson
                    Saving_Images_To_Lesson(Lesson_ID);

                    //Inserting Art objects into Lesson
                    Saving_Artobjects_To_Lesson(Lesson_ID);


                }
                else
                {
                   Group_ID = DB.FindGroupID(CB_Classes.SelectedItem.ToString()).Get_Group_ID();
                   int Lesson_ID = DB.FindLessonIDByName(TB_Title.Text);
                   //Insert Lesson into chosen group
                   DB.InsertLessonForGroups(Lesson_ID, Group_ID);

                    //Inserting Images into Lesson
                    Saving_Images_To_Lesson(Lesson_ID);

                    //Inserting Art objects into Lesson
                    Saving_Artobjects_To_Lesson(Lesson_ID);
                }
             
                MessageBox.Show("Saved lesson!");
            }  
        }


        /// <summary>
        /// Fill the saved lesson data (If editing a lesson)
        /// </summary>
        /// <param name="Lesson_ID">ID of the lesson to edit</param>
        private void Fill_Saved_Lesson_Data(int Lesson_ID)
        {
            //Open instance
            DBRepository DB = DBRepository.GetInstance();
            //Get lesson object by the ID
            var Lesson = DB.GetLessonDataByID(Lesson_ID);
            LessonToEditID = Lesson_ID;

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


                //Get Art objects in lesson

                var Art = DB.ReceiveArtObjInLesson(Lesson);

                foreach(var Single_Art in Art)
                {
                    LB_Art_Items.Items.Add(Single_Art.ReturnArtTitle());
                }

            }
            catch (NullReferenceException)
            {
                //Do nothing
            }    
        }



        /// <summary>
        /// Update the lesson 
        /// </summary>
        private void UpdateLesson()
        {
            //Make new instance of DB Class
            DBRepository DB = DBRepository.GetInstance();


            //Make a new lesson object
            Lesson L = new Lesson(TB_Title.Text, LessonToEditID, CB_Lesson_Status.SelectedItem.ToString(), TB_Desc.Text, TB_Subject.Text, 0);

            //Update the lesson using the object
            DB.UpdateLesson(L);

            //Get Group Information
            var Groups = DB.FindGroupData();
            int Group_ID = 0;

            //For every group in the list of groups
            foreach(var SGroup in Groups)
            {
                if(SGroup.GetGroupName() == CB_Classes.SelectedItem.ToString())
                {
                    //If groupname equals the selected group (add id)
                    Group_ID = SGroup.Get_Group_ID();
                }
            }

            //Delete previous groups that had this lesson
            DB.DeleteLessonAtGroupsByID(LessonToEditID);
            DB.DeleteImageFromLessonByID(LessonToEditID);
            DB.DeleteArtObjFromLessonByID(LessonToEditID);

            //Add this lesson to the groups that currently have this lesson
            if(CB_Classes.SelectedItem.ToString() == "All")
            { 
                DB.InsertLessonForGroups(LessonToEditID, 0);

                //Inserting Images into Lesson
                Saving_Images_To_Lesson(LessonToEditID);

                //Inserting Art into Lesson
                Saving_Artobjects_To_Lesson(LessonToEditID);
            }
            else
            {
                DB.InsertLessonForGroups(LessonToEditID, Group_ID);

                //Inserting Images into Lesson
                Saving_Images_To_Lesson(LessonToEditID);

                //Inserting Art into Lesson
                Saving_Artobjects_To_Lesson(LessonToEditID);
            }

            MessageBox.Show("Lesson Updated");
        }


        /// <summary>
        /// Activate the update (depending on true or false)
        /// </summary>
        /// <param name="editlesson"></param>
        private void Activate_Update(bool editlesson)
        {
            //If this is an lesson that is being edited
            if (editlesson == true)
            {
				LBL_Title_New_Set.Text = "Les Wijzigen";
                btn_update.Enabled = true;
                btn_save_lesson.Enabled = false;
            }
        }

        /// <summary>
        /// Save the lesson on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_lesson_Click(object sender, EventArgs e)
        {
            SaveLesson();
        }

        
        /// <summary>
        /// Add objects to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_objects_Click(object sender, EventArgs e)
        {
            Add_Art_To_Lesson();
        }

        /// <summary>
        /// Update the lesson on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateLesson();
        }

        /// <summary>
        /// Add image to list on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_images_Click(object sender, EventArgs e)
        {
            Add_Images_To_Lesson();
        }


        /// <summary>
        /// Remove images from list on doubleclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LB_Images_DoubleClick(object sender, EventArgs e)
        {
            LB_Images.Items.Remove(LB_Images.SelectedItem);
        }


        /// <summary>
        /// Remove art objects from list on doubleclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LB_Art_Items_DoubleClick(object sender, EventArgs e)
        {
            LB_Art_Items.Items.Remove(LB_Art_Items.SelectedItem);
        }

        /// <summary>
        /// Add image to system (DB)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Image_to_system_Click(object sender, EventArgs e)
        {
            Add_Images_To_System();
        }


        /// <summary>
        /// Add images to system function
        /// </summary>
        private void Add_Images_To_System()
        {
            try
            {
                //Open new file dialog
                OpenFileDialog open = new OpenFileDialog();

                //Only allow these file types
                open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    //Create new bitmap
                    Bitmap bit = new Bitmap(open.FileName);

                    //Make new instance of DB Class
                    DBRepository DB = DBRepository.GetInstance();

                    //Create byte array
                    byte[] arr;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bit.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        arr = ms.ToArray();
                    }

                    //Insert image into DB
                    DB.InsertImageInDB(open.FileName, arr);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        /// <summary>
        /// Add images to lesson
        /// </summary>
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

            //Get all the images from database
            var images = DB.ReceiveImagesFromDB();


            //for every image in the images list
            foreach (var image in images)
            {
                if (ToAddImageID == image.ReturnImageID())
                {
                    LB_Images.Items.Add(image.ReturnFileName());
                }
            }
        }

        /// <summary>
        /// Add art to lesson listbox
        /// </summary>
        public void Add_Art_To_Lesson()
        {
           if(CB_Art.SelectedIndex > -1)
            {
                LB_Art_Items.Items.Add(CB_Art.SelectedItem.ToString());
            }
            else{
                //Do nothing
            }
        }


        /// <summary>
        /// Save image to lesson where lesson ID
        /// </summary>
        /// <param name="LessonID">Lesson ID</param>
        public void Saving_Images_To_Lesson(int LessonID)
        {
            //Make a new instance of DB class
            DBRepository DB = DBRepository.GetInstance();

            //Get images from DB
            var images = DB.ReceiveImagesFromDB();

            //For every image in images do the following
            foreach(var image in images)
            {
                //For every item in listbox images
                foreach(string item in LB_Images.Items)
                {
                    //If image name is the same as item name
                    if(image.ReturnFileName() == item)
                    {
                        //ADD IMAGE TO LESSON IN DATABASE
                        DB.InsertImageInLesson(LessonID, image.ReturnImageID());
                    }
                }
            }
        }


        /// <summary>
        /// Save artobjects to a lesson
        /// </summary>
        /// <param name="LessonID">ID of the lesson</param>
        public void Saving_Artobjects_To_Lesson(int LessonID)
        {
            //Make a new instance of DB class
            DBRepository DB = DBRepository.GetInstance();

            //Get art from DB
            var Art = DB.FindArtData();

            //For every art in list of art do the following
            foreach (var single_art in Art)
            {
                //For every item in listbox art
                foreach (string item in LB_Art_Items.Items)
                {
                    //If art name is the same as art name in the listbox
                    if (single_art.ReturnArtTitle() == item)
                    {
                        //ADD ART TO LESSON IN DATABASE
                        DB.InsertArtObjInLesson(LessonID, single_art.ReturnArtID());
                    }
                }
            }
        }

 
    }
}
