using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeColorUsingRadioButtons
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void red_CheckedChanged(object sender, EventArgs e)
        {
            changeColorLabel.Text = "The color of the text changed to RED";
            changeColorLabel.ForeColor = System.Drawing.Color.Red;
        }

        protected void green_CheckedChanged(object sender, EventArgs e)
        {
            changeColorLabel.Text = "The color of the text changed to GREEN";
            changeColorLabel.ForeColor = System.Drawing.Color.Green;
        }

        protected void blue_CheckedChanged(object sender, EventArgs e)
        {
            changeColorLabel.Text = "The color of the text changed to BLUE";
            changeColorLabel.ForeColor = System.Drawing.Color.Blue;
        }
    }
}