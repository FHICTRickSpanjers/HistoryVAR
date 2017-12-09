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
    public partial class Student_Screen : Form
    {

        private string Logged_In_User;

        public Student_Screen(string username)
        {
            InitializeComponent();
            this.Logged_In_User = username;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Back to previous screen
            this.Hide();
            var User_Selection = new User_Selection();
            User_Selection.Closed += (s, args) => this.Close();
            User_Selection.Show();
        }
    }
}
