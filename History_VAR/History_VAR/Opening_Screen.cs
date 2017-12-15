using History_VAR.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History_VAR
{
    public partial class Opening_Screen : Form
    {
        /// <summary>
        /// Empty constructor for the opening screen
        /// </summary>
        public Opening_Screen()
        {
            InitializeComponent();
        }

        //Enter the application on click eventhandler
        private void btn_enter_application_Click(object sender, EventArgs e)
        {
            //Close the current form
            this.Hide();

            //Make an instance of the new form
            var Option_Screen = new User_Login();
            Option_Screen.Closed += (s, args) => this.Close();

            //Open the new form
            Option_Screen.Show();
        }
    }
}
