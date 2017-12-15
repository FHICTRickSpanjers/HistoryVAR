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
    public partial class User_Login : Form
    {

        private string SelectedUser;

        public User_Login()
        {
            InitializeComponent();
        }


        //Login Teacher
        private bool Log_In_Teacher()
        {
            if (string.IsNullOrEmpty(TB_Username.Text) || string.IsNullOrEmpty(TB_Password.Text))
            {
                MessageBox.Show("The username or password was not filled");
            }
            else
            {
                DBRepository DB = DBRepository.GetInstance();
                var LoggedIn = DB.FindLoginData(TB_Username.Text, TB_Password.Text, "Teacher");

                if (LoggedIn == true)
                {
                    this.Hide();
                    var Teacher_Screen = new Teacher_Options(TB_Username.Text);
                    Teacher_Screen.Closed += (s, args) => this.Close();
                    Teacher_Screen.Show();
                    return true;
                }
                
            }

            return false;

        }

        //Login Student
        private bool Log_In_Student()
        {
            if (string.IsNullOrEmpty(TB_Username.Text) || string.IsNullOrEmpty(TB_Password.Text))
            {
                MessageBox.Show("The username or password was not filled");
            }
            else
            {
                DBRepository DB = DBRepository.GetInstance();
                var LoggedIn = DB.FindLoginData(TB_Username.Text, TB_Password.Text, "Student");

                if (LoggedIn == true)
                {
                    this.Hide();
                    var Student_Screen = new Student_Screen(TB_Username.Text);
                    Student_Screen.Closed += (s, args) => this.Close();
                    Student_Screen.Show();
                    return true;
                }
            }

            return false;
        }

        private void Login()
        {
            try
            {

                if (Log_In_Teacher() == false)
                {
                    if(Log_In_Student() == false)
                    {
                        MessageBox.Show("The username or password was wrong!");
                    }
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
            var Opening_Screen = new Opening_Screen();
            Opening_Screen.Closed += (s, args) => this.Close();
            Opening_Screen.Show();
        }
    }
}
