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
    public partial class User_Selection : Form
    {
        public User_Selection()
        {
            InitializeComponent();
        }

        private void btn_teacher_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            var User_Login = new User_Login();
            User_Login.Closed += (s, args) => this.Close();
            User_Login.Show();
        }
        private void btn_student_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            var User_Login = new User_Login();
            User_Login.Closed += (s, args) => this.Close();
            User_Login.Show();
        }
    }
}
