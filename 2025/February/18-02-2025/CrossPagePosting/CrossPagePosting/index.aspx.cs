using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrossPagePosting
{
    public partial class index : System.Web.UI.Page
    {
        String product;
        int quantity;
        int price;
        protected void Page_Load(object sender, EventArgs e)
        {
            product = "";
            quantity = 0;
            price = 0;
        }

        protected void totalButton_Click(object sender, EventArgs e)
        {
            product = productNameTB.Text;
            quantity = Convert.ToInt32(quantityTB.Text);
            price = Convert.ToInt32(priceTB.Text);
            totalPriceLabel.Text = (quantity * price).ToString();
        }
    }
}