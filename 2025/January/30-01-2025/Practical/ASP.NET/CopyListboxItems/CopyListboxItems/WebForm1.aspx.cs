using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CopyListboxItems
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void copyButton_Click(object sender, EventArgs e)
        {
            ListBox2.Items.Clear();

            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                {
                    ListBox2.Items.Add(new ListItem(item.Text, item.Value));
                }
            }
        }

    }
}