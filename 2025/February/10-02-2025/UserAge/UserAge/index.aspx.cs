using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace UserAge
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addRecordButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text);

            SqlConnection con = new SqlConnection(@"Data Source=MONAJEWELS\BARTENDER;Initial Catalog=UserAge;Integrated Security=True;TrustServerCertificate=True");
            String query = "insert into user_age values('"+name+"', '"+age+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if(i > 0)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "New Records Added";
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "No Records Added";
            }
            con.Close();
        }

        protected void updateRecordButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MONAJEWELS\BARTENDER;Initial Catalog=UserAge;Integrated Security=True;TrustServerCertificate=True");
            String query = "select * from user_age";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();

        }

        protected void deleteRecordButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            SqlConnection con = new SqlConnection(@"Data Source=MONAJEWELS\BARTENDER;Initial Catalog=UserAge;Integrated Security=True;TrustServerCertificate=True");
            String query = "delete from user_age where name='"+name+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        protected void clearRecordButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            SqlConnection con = new SqlConnection(@"Data Source=MONAJEWELS\BARTENDER;Initial Catalog=UserAge;Integrated Security=True;TrustServerCertificate=True");
            String query = "delete from user_age";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }
    }
}