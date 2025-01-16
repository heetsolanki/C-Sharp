using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryCricketCaptain
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void displayButton_Click(object sender, EventArgs e)
        {
            String country = (countryList.SelectedItem.Text);

            if (country == "India")
            {
                displayCaptain.Text = "Rohit Sharma";
            }
            else if (country == "England")
            {   
                displayCaptain.Text = "Jos Buttler";
            }
            else if (country == "Australia")
            {   
                displayCaptain.Text = "Pat Cummins";
            }
            else if (country == "Netherlands")
            {
                displayCaptain.Text = "Scott Edwards";
            }
        }
    }
}