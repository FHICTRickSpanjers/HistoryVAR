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
    public partial class SystemImages : Form
    {
        public SystemImages()
        {
            InitializeComponent();
        }

        private void Fill_Panel_With_Images()
        {
            DBRepository DB = DBRepository.GetInstance();
            var images = DB.Reveive_Images_From_DB();
           // foreach(var image in images)
            //{
                
            //}

        }

        private void FlowLayoutPanelIMG_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
