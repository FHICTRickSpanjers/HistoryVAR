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
        private int IMG_ID;

        public SystemImages()
        {
            InitializeComponent();
            Fill_Panel_With_Images();
        }

        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void Fill_Panel_With_Images()
        {
            DBRepository DB = DBRepository.GetInstance();
            var images = DB.Receive_Images_From_DB();
            foreach(var image in images)
            {
                PictureBox p = new PictureBox();
                p.Image = ByteToImage(image.ReturnImageData());
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.BorderStyle = BorderStyle.FixedSingle;

                p.Click += (s, e) => {

                    this.Hide();
                    //var Make_New_Set = new Teacher_Make_New_Sets(image.ReturnImageID());
                    //Make_New_Set.Closed += (x, args) => this.Close();
                    //Make_New_Set.Show();
                    SetImageID(image.ReturnImageID());

                };

                FlowLayoutPanelIMG.Controls.Add(p);
            }

        }

        public void SetImageID(int ID)
        {
            this.IMG_ID = ID;
        }

        public int ReturnImageID()
        {
            return this.IMG_ID;
        }

        private void FlowLayoutPanelIMG_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
