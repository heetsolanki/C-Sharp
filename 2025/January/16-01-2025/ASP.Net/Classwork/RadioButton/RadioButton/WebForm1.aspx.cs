using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButton
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void changeColorButton_Click(object sender, EventArgs e)
        {
            if(red.Checked)
            {
                colorMessage.ForeColor = System.Drawing.Color.Red;
            }
            else if(green.Checked)
            {
                colorMessage.ForeColor = System.Drawing.Color.Green;
            }
            else if (blue.Checked)
            {
                colorMessage.ForeColor = System.Drawing.Color.Blue;
            }
            else if (violet.Checked)
            {
                colorMessage.ForeColor = System.Drawing.Color.Violet;
            }
            else if (pink.Checked)
            {
                colorMessage.ForeColor = System.Drawing.Color.Pink;
            }
            else if (orange.Checked)
            {
                colorMessage.ForeColor = System.Drawing.Color.Orange;
            }
            else if (yellow.Checked)
            {
                colorMessage.ForeColor = System.Drawing.Color.Yellow;
            }
        }
    }
}