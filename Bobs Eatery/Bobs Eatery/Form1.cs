using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobs_Eatery
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //I will create a IF statement which will make sure that the password and the username field are not left blank.

            if (txtUsername.Text == "" || txtPass.Text == "")
                {
                //Create a Error message to alert if the password or username fields are left blank.
                lblError.Text = "Please enter a username and password to continue";
            }

            else if (txtUsername.Text == "GordonRamsay" & txtPass.Text == "Kitchen")
                {
                // make the log in form disappear if the log in details are correct.
                this.Hide();

                //create a new object for this form so that the EPOS form opens.
                EPOS f1 = new EPOS();

                //the form will open up.
                f1.ShowDialog();
            }

            else
            {
                //make a error message if the username or password is incorrect.
                lblError.Text = "Incorrect username / password. Please try again.";
            }
        }
    }
}
