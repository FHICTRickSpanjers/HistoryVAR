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
    public partial class SystemImages : Form
    {
        //ID from the image
        private int IMG_ID;

        /// <summary>
        /// Constructor for the systemimages form
        /// </summary>
        public SystemImages()
        {
            InitializeComponent();

            //Fill the panel with images in the DB
            Fill_Panel_With_Images();
        }


        /// <summary>
        /// Transform bytes to bitmap (This can be used for pictureboxes)
        /// </summary>
        /// <param name="blob">Byte array</param>
        /// <returns>Bitmap (used for pictureboxes)</returns>
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
        /// Filling the panel with images from the database
        /// </summary>
        private void Fill_Panel_With_Images()
        {
            //Open DB instance
            DBRepository DB = DBRepository.GetInstance();

            //Get images from the database
            var images = DB.ReceiveImagesFromDB();

            //For every image in the received images list
            foreach(var image in images)
            {

                //Make a picturebox for every image
                PictureBox p = new PictureBox();
                p.Image = ByteToImage(image.ReturnImageData());
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.BorderStyle = BorderStyle.FixedSingle;

                p.Click += (s, e) => {

                    //Add a clickfunction that adds the image to the lesson
                    this.Hide();
                    SetImageID(image.ReturnImageID());

                };

                //Add picturebox to layoutpanel
                FlowLayoutPanelIMG.Controls.Add(p);
            }

        }

        /// <summary>
        /// Set image ID
        /// </summary>
        /// <param name="ID">ID of the image</param>
        public void SetImageID(int ID)
        {
            this.IMG_ID = ID;
        }

        /// <summary>
        /// Returning the ID of the image
        /// </summary>
        /// <returns>int ID</returns>
        public int ReturnImageID()
        {
            return this.IMG_ID;
        }
    }
}
