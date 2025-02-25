using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrossPagePosting
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page previouspage = Page.PreviousPage;

            if(previouspage != null && previouspage.IsCrossPagePostBack)
            {
                usernameLabel.Text = ((TextBox)previouspage.FindControl("usernameTB")).Text;
                colorLabel.Text = ((DropDownList)previouspage.FindControl("colorDDL")).SelectedItem.Text;
                String color = ((DropDownList)previouspage.FindControl("colorDDL")).SelectedItem.Text;
                colorLabel.ForeColor = System.Drawing.Color.FromName(color);
            }
        }
    }
}