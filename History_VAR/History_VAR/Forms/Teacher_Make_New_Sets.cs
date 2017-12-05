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
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Teacher_Options = new Teacher_Options();
            Teacher_Options.Closed += (s, args) => this.Close();
            Teacher_Options.Show();
        }

        private void btn_save_lesson_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_objects_Click(object sender, EventArgs e)
        {

        }
    }
}
