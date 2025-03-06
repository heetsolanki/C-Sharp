using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AccountCreation
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayData();
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\ASP.Net\AccountCreation\AccountCreation\App_Data\account.mdf;Integrated Security=True"))
            {
                string query = "INSERT INTO account (name, age, accountType, address, email, contact) VALUES (@name, @age, @accountType, @address, @email, @contact)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@age", ageTextBox.Text);
                    cmd.Parameters.AddWithValue("@accountType", accountTypeDDL.SelectedValue);
                    cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                    cmd.Parameters.AddWithValue("@contact", contactTextBox.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            DisplayData();
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\ASP.Net\AccountCreation\AccountCreation\App_Data\account.mdf;Integrated Security=True"))
            {
                string query = "UPDATE account SET age=@age, accountType=@accountType, address=@address, email=@email, contact=@contact WHERE TRIM(name)=@name";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());  // Trim spaces
                    cmd.Parameters.AddWithValue("@age", ageTextBox.Text);
                    cmd.Parameters.AddWithValue("@accountType", accountTypeDDL.SelectedValue);
                    cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                    cmd.Parameters.AddWithValue("@contact", contactTextBox.Text);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        // No row updated, show message (optional)
                        Response.Write("<script>alert('No matching record found to update!');</script>");
                    }
                }
            }
            DisplayData();
        }


        protected void deleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\ASP.Net\AccountCreation\AccountCreation\App_Data\account.mdf;Integrated Security=True"))
            {
                string query = "DELETE FROM account WHERE name=@name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", nameTextBox.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            DisplayData();
        }

        protected void displayButton_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\ASP.Net\AccountCreation\AccountCreation\App_Data\account.mdf;Integrated Security=True"))
            {
                string query = "SELECT * FROM account";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    GridView1.Visible = dt.Rows.Count > 0;
                }
            }
        }
    }
}