using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserInformation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            double phone = double.Parse(phoneBox.Text);
            String gender;
            String langauge = "I know";
            if(maleButton.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if(english.Checked)
            {
                langauge += "\nEnglish";
            }
            if(hindi.Checked)
            {
                langauge += "\nHindi";
            }
            if(marathi.Checked)
            {
                langauge += "\nMarathi";
            }
            displayName.Text = $"Name: {name}";
            displayPhone.Text = $"Phone Number: {phone}";
            displayGender.Text = $"Gender: {gender}";
            displayLanguage.Text = langauge;


        }
    }
}