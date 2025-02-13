using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Register_Database
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            String mobile = mobileTextBox.Text;
            String password = passwordTextBox.Text;
            SqlConnection con = new SqlConnection(@"Data Source=MONAJEWELS\BARTENDER;Initial Catalog=UserData;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            String compare = "select count(*) from user_data where mobile_no = '" + mobile + "'";
            SqlCommand checkCmd = new SqlCommand(compare, con);
            int i = Convert.ToInt32(checkCmd.ExecuteScalar());
            if (i > 0) 
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                message.Text = "Mobile number does not exist";
            }

        }
    }
}