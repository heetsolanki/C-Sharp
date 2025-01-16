using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisplayNameInColor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RedButton_Click(object sender, EventArgs e)
        {
            String text = TextBox1.Text;
            displayLabel.Text = text;
            displayLabel.ForeColor = System.Drawing.Color.Red;
        }

        protected void GreenButton_Click(object sender, EventArgs e)
        {
            String text = TextBox1.Text;
            displayLabel.Text = text;
            displayLabel.ForeColor = System.Drawing.Color.Green;

        }
    }
}