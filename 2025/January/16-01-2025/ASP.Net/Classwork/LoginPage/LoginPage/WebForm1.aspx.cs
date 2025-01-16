using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            //user entered details
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            //saved details
            String originalUsername = "heetsolanki";
            String originalPassword = "heet@2006";

            if(originalUsername == username && originalPassword == password)
            {
                messageLabel.Text = "You are a verified user!";
                messageLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                messageLabel.Text = "Unauthorised user";
                messageLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}