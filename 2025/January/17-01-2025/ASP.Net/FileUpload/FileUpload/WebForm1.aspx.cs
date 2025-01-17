using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUpload
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/CollegeCodes/" + FileUpload1.FileName));
                displayLabel.Text = "File Saved!";
            }
            else
            {
                displayLabel.Text = "Please select a file!";
            }
        }
    }
}