using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginForm
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            if (username == "heetsolanki" && password == "heet@2006")
            {
                Response.Redirect("LoginSuccessful.aspx");
            }
            else
            {
                Response.Redirect("LoginUnsuccessful.aspx");
            }
        }
    }
}