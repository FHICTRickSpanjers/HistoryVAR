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
        public Opening_Screen()
        {
            InitializeComponent();
        }

        private void btn_enter_application_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Option_Screen = new User_Login();
            Option_Screen.Closed += (s, args) => this.Close();
            Option_Screen.Show();
        }
    }
}
