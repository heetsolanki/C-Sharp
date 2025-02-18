using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrossPagePosting
{
    public partial class pyament_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page previouspage = Page.PreviousPage;
            if(previouspage != null && previouspage.IsCrossPagePostBack)
            {
                productLabel.Text = ((TextBox)previouspage.FindControl("productNameTB")).Text;
                quantityLabel.Text = ((TextBox)previouspage.FindControl("quantityTB")).Text;
                priceLabel.Text = ((TextBox)previouspage.FindControl("priceTB")).Text;
                totalLabel.Text = ((Label)previouspage.FindControl("totalPriceLabel")).Text;
            }
            else
            {
                productLabel.Text = "No previous page";
            }
        }
    }
}