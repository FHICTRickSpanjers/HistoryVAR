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
        //Username of the logged in user
        private string SelectedUser;

        public User_Login()
        {
            InitializeComponent();
        }


        //Login Teacher
        private bool Log_In_Teacher()
        {
            //Check is Textboxes are empty
            if (string.IsNullOrEmpty(TB_Username.Text) || string.IsNullOrEmpty(TB_Password.Text))
            {
                MessageBox.Show("The username or password was not filled");
            }

            //If textboxes arent empty
            else
            {
                DBRepository DB = DBRepository.GetInstance();
                var LoggedIn = DB.FindLoginData(TB_Username.Text, TB_Password.Text, "Teacher");

                if (LoggedIn == true)
                {

                    //Hide the current form
                    this.Hide();

                    //Make instance of new form
                    var Teacher_Screen = new Teacher_Options(TB_Username.Text);
                    Teacher_Screen.Closed += (s, args) => this.Close();

                    //Open new form
                    Teacher_Screen.Show();

                    //Return true
                    return true;
                }
                
            }

            return false;

        }

        //Login Student
        private bool Log_In_Student()
        {
            //Check if textboxes are empty
            if (string.IsNullOrEmpty(TB_Username.Text) || string.IsNullOrEmpty(TB_Password.Text))
            {
                MessageBox.Show("The username or password was not filled");
            }

            //If textboxes arent empty
            else
            {

                //New instance of DB Class
                DBRepository DB = DBRepository.GetInstance();
                var LoggedIn = DB.FindLoginData(TB_Username.Text, TB_Password.Text, "Student");

                //If logged in = true
                if (LoggedIn == true)
                {

                    //Close current form
                    this.Hide();

                    //Make instance of new form
                    var Student_Screen = new Student_Screen(TB_Username.Text);
                    Student_Screen.Closed += (s, args) => this.Close();

                    //Open new form
                    Student_Screen.Show();

                    //Return true (that means log in was succesful)
                    return true;
                }
            }

            //If log-in was unsuccessful return false
            return false;
        }

        /// <summary>
        /// Login function
        /// </summary>
        private void Login()
        {
            try
            {
                //Check for a teacher login
                if (Log_In_Teacher() == false)
                {
                    //Check for student login
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

        /// <summary>
        /// Use the login function on eventhandler click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();     
        }

        /// <summary>
        /// Go back to the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            //Back to previous screen
            this.Hide();

            //Make isntance of new form
            var Opening_Screen = new Opening_Screen();
            Opening_Screen.Closed += (s, args) => this.Close();

            //Open new form
            Opening_Screen.Show();
        }
    }
}
