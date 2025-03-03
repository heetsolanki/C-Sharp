using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String name = Session["name"].ToString();
            String book = Session["book"].ToString();
            String sport = Session["sport"].ToString();
            bookLabel.Text = name + " likes to read " + book;
            sportLabel.Text = name + " likes to play " + sport;
        }
    }
}