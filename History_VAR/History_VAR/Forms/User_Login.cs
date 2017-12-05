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
    public partial class User_Login : Form
    {

        private string SelectedUser;

        public User_Login(string C)
        {
            InitializeComponent();
            this.SelectedUser = C;
        }


        private void Log_In_Teacher()
        {
            //Login Teacher
            this.Hide();
            var Teacher_Screen = new Teacher_Options();
            Teacher_Screen.Closed += (s, args) => this.Close();
            Teacher_Screen.Show();
        }
        private void Log_In_Student()
        {
            //Login Student
            this.Hide();
            var Student_Screen = new Student_Screen();
            Student_Screen.Closed += (s, args) => this.Close();
            Student_Screen.Show();

        }

        private void Login()
        {
            try
            {
                if (SelectedUser == "Teacher")
                {
                    Log_In_Teacher();
                }
                else if (SelectedUser == "Student")
                {
                    Log_In_Student();
                }
                else
                {

                }
            }
            catch (NullReferenceException E)
            {
                MessageBox.Show(E.Message);
            }
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();     
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
