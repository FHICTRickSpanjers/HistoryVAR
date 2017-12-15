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
    public partial class Student_Show_Lesson : Form
    {
        //Name of the lesson and current logged in user
        private string Lesson_name;
        private string current_user;


        /// <summary>
        /// Constructor that needs a lesson name and username
        /// </summary>
        /// <param name="lesson_name"></param>
        /// <param name="username"></param>
        public Student_Show_Lesson(string lesson_name, string username)
        {
            InitializeComponent();

            //Set the lesson name and username
            this.Lesson_name = lesson_name;
            this.current_user = username;

            //Set the data from the lesson
            SetLessonData();
        }


        /// <summary>
        /// Setting the data for the lessons
        /// </summary>
        public void SetLessonData()
        {
            //Set lesson title
            LBL_Lesson_Title.Text = Lesson_name;

            //Make a new instance
            DBRepository DB = DBRepository.GetInstance();

            //Get lesson objects
            var Lessons = DB.FindLessonsData();

            //For every lesson in the lessons do the following
            foreach(var single_lesson in Lessons)
            {
                if (single_lesson.GetLessonName() == Lesson_name)
                {
                    //Set the lesson description and subject
                    TB_Lesson_Desc.Text = single_lesson.GetLessonDesc();
                    LBL_Lesson_Subject.Text = single_lesson.GetLessonSubject();

                    
                    //Get all the images that are in the lesson
                    var Images = DB.ReceiveImagesInLesson(single_lesson);

                    //Add images to panel
                    foreach(var image in Images)
                    {
                        //Create new picturebox
                        PictureBox p = new PictureBox();
                        p.Image = ByteToImage(image.ReturnImageData());
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        p.BorderStyle = BorderStyle.FixedSingle;
                        p.Dock = DockStyle.Top;

                        //Add it to the panel
                        FlowPanelLayoutIMG.Controls.Add(p);
                    }
                    
                }
            }
        }

        /// <summary>
        /// Transform Bytes into image
        /// </summary>
        /// <param name="blob">The byte array for the image</param>
        /// <returns>Returns a bitmap (which can be used for the picturebox)</returns>
        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }


        /// <summary>
        /// Download art objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Download_OBJ_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Return back to the previous form and close current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Sscreen = new Student_Screen(current_user);
            Sscreen.Closed += (s, args) => this.Close();
            Sscreen.Show();
        }
    }
}
