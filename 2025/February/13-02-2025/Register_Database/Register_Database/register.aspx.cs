using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Register_Database
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            message.Text = "";
            message.Visible = false;
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String mobile = mobileTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            String password = passwordTextBox.Text;
            SqlConnection con = new SqlConnection(@"Data Source=MONAJEWELS\BARTENDER;Initial Catalog=UserData;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            String compare = "select count(*) from user_data where mobile_no = '" + mobile + "'";
            SqlCommand checkCmd = new SqlCommand(compare, con);
            int i = Convert.ToInt32(checkCmd.ExecuteScalar());
            if (i > 0)
            {
                message.Visible = true;
                message.Text = "Mobile number already exists";
                return;
            }
            else
            {
                i = 0;
                String query = "insert into user_data values('" + name + "', '" + mobile + "', '" + age + "', '" + password + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    message.Visible = true;
                    message.Text = "Registration Successful";
                }
                else
                {
                    message.Visible = true;
                    message.Text = "Registration Failed";
                }
            }
            con.Close();
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}