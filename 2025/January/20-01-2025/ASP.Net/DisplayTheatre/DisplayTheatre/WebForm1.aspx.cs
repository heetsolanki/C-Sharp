using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisplayTheatre
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mumbai_CheckedChanged(object sender, EventArgs e)
        {
            mallDDL.Visible = true;
            mallDDL.Items.Clear();
            mallDDL.Items.Insert(0, "Phoenix Marketcity");
            mallDDL.Items.Insert(1, "R City Mall");
            mallDDL.Items.Insert(2, "Jio Drive");
        }

        protected void pune_CheckedChanged(object sender, EventArgs e)
        {
            mallDDL.Visible = true;
            mallDDL.Items.Clear();
            mallDDL.Items.Insert(0, "Phoenix Marketcity");
            mallDDL.Items.Insert(1, "Seasons Mall");
            mallDDL.Items.Insert(2, "Amanora Mall");
        }

        protected void timingButton_Click(object sender, EventArgs e)
        {
            if (mumbai.Checked)
            {
                String mallName = mallDDL.Text;
                switch (mallName)
                {
                    case "Phoenix Marketcity":
                        movie1.Text = "DESHDROHI - 6.00 AM";
                        movie2.Text = "LAGAAN - 1.00 AM";
                        movie3.Text = "KARAN ARJUN - 5.00 PM";
                        break;
                    case "R City Mall":
                        movie1.Text = "ADIPURUSH - 4.00 AM";
                        movie2.Text = "BADE MIYAN CHOTE MIYAH - 12.00 AM";
                        movie3.Text = "INTERSTELLAR - 5.00 PM";
                        break;
                    case "Jio Drive":
                        movie1.Text = "BHAGAM BHAG - 4.00 PM";
                        movie2.Text = "PHIR HERA PHERI - 12.00 PM";
                        movie3.Text = "DHAMAAL - 7.00 PM";
                        break;
                }
            }
            else
            {
                String mallName = mallDDL.Text;
                switch (mallName)
                {
                    case "Phoenix Marketcity":
                        movie1.Text = "DESHDROHI - 6.00 AM";
                        movie2.Text = "LAGAAN - 1.00 AM";
                        movie3.Text = "KARAN ARJUN - 5.00 PM";
                        break;
                    case "Seasons Mall":
                        movie1.Text = "ADIPURUSH - 4.00 AM";
                        movie2.Text = "BADE MIYAN CHOTE MIYAH - 12.00 AM";
                        movie3.Text = "INTERSTELLAR - 5.00 PM";
                        break;
                    case "Amanora Mall":
                        movie1.Text = "BHAGAM BHAG - 4.00 PM";
                        movie2.Text = "PHIR HERA PHERI - 12.00 PM";
                        movie3.Text = "DHAMAAL - 7.00 PM";
                        break;
                }
            }
        }
    }
}