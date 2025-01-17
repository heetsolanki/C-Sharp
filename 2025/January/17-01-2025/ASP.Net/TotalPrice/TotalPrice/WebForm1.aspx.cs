using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TotalPrice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calculateButton_Click(object sender, EventArgs e)
        {
            int pen = 10;
            int pencil = 5;
            int eraser = 15;
            int sharpner = 10;
            int cutter = 30;
            int scale = 20;
            int sum = 0;
            int quantity = int.Parse(quantityTextBox.Text);
            String product = (productDDL.SelectedValue);
            if(quantity == 0)
            {
                totalPriceLabel.Text = "Enter quantity!";
            }
            else
            {
                switch (productDDL.SelectedValue)
                {
                    case "Pen":
                        sum = pen * quantity;
                        break;
                    case "Pencil":
                        sum = pencil * quantity;
                        break;
                    case "Eraser":
                        sum = eraser * quantity;
                        break;
                    case "Sharpner":
                        sum = sharpner * quantity;
                        break;
                    case "Cutter":
                        sum = cutter * quantity;
                        break;
                    case "Scale":
                        sum = scale * quantity;
                        break;
                    default:
                        totalPriceLabel.Text = "Please select a product";
                        break;
                }
                totalPriceLabel.Text = $"Total Price: {sum}";
            }
        }
    }
}