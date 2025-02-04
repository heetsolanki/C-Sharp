using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisplayProductImagePrice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void productDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            String item = productDDL.SelectedValue;
            switch(item)
            {
                case "--Select Item--":
                    Response.Write("Select an item first.");
                    break;
                case "Pen":
                    // displaying image
                    productImage.Visible = true;
                    productImage.ImageUrl = "images/pen.png";
                    productImage.Width = 50;
                    break;
                case "Pencil":
                    // displaying image
                    productImage.Visible = true;
                    productImage.ImageUrl = "images/pencil.png";
                    productImage.Width = 50;
                    break;
                case "Eraser":
                    // displaying image
                    productImage.Visible = true;
                    productImage.ImageUrl = "images/eraser.png";
                    productImage.Width = 50;
                    break;
                case "Scale":
                    // displaying image
                    productImage.Visible = true;
                    productImage.ImageUrl = "images/ruler.png";
                    productImage.Width = 50;
                    break;
                default:
                    break;
            }
        }

        protected void totalButton_Click(object sender, EventArgs e)
        {
            String item = productDDL.SelectedValue;
            int quantity = int.Parse(quantityTextBox.Text);
            int total;
            switch (item)
            {
                case "--Select Item--":
                    Response.Write("Select an item first.");
                    break;
                case "Pen":
                    total = quantity * 10;
                    totalTextBox.Text = total.ToString();
                    break;
                case "Pencil":
                    total = quantity * 5;
                    totalTextBox.Text = total.ToString();
                    break;
                case "Eraser":
                    total = quantity * 15;
                    totalTextBox.Text = total.ToString();
                    break;
                case "Scale":
                    total = quantity * 20;
                    totalTextBox.Text = total.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}