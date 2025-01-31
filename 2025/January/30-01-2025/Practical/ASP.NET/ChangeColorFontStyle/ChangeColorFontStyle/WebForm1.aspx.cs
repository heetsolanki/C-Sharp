using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeColorFontStyle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void red_CheckedChanged(object sender, EventArgs e)
        {
            String text = nameTextBox.Text;
            displayLabel.Text = text;
            displayLabel.ForeColor = System.Drawing.Color.Red;
        }

        protected void green_CheckedChanged(object sender, EventArgs e)
        {
            String text = nameTextBox.Text;
            displayLabel.Text = text;
            displayLabel.ForeColor = System.Drawing.Color.Green;
        }

        protected void blue_CheckedChanged(object sender, EventArgs e)
        {
            String text = nameTextBox.Text;
            displayLabel.Text = text;
            displayLabel.ForeColor = System.Drawing.Color.Blue;

        }

        protected void bold_CheckedChanged(object sender, EventArgs e)
        {
            if (bold.Checked)
            {
                displayLabel.Font.Bold = true;
            }
            else
            {
                displayLabel.Font.Bold = false;
            }
        }

        protected void italic_CheckedChanged(object sender, EventArgs e)
        {
            if (italic.Checked)
            {
                displayLabel.Font.Italic = true;
            }
            else
            {
                displayLabel.Font.Italic = false;
            }
        }

        protected void underline_CheckedChanged(object sender, EventArgs e)
        {
            if (underline.Checked)
            {
                displayLabel.Font.Underline = true;
            }
            else
            {
                displayLabel.Font.Underline = false;
            }
        }
    }
}