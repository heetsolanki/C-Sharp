<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CrossPagePosting.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 28px;
        }
        .auto-style5 {
            width: 202px;
        }
        .auto-style6 {
            width: 202px;
            height: 31px;
        }
        .auto-style7 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="50px" Text="Calculating Total Bill"></asp:Label>

        </div>

            <table class="auto-style1" style="padding: 0px 25px 25px 0px">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Candara" Text="Product"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="productNameTB" runat="server" Font-Names="Candara"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Candara" Text="Price"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="priceTB" runat="server" Font-Names="Candara"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Candara" Text="Quantity"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="quantityTB" runat="server" Font-Names="Candara"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="totalButton" runat="server" Text="Calculate Total" Font-Bold="True" Font-Names="Candara" OnClick="totalButton_Click" />
                    &nbsp;
                        <asp:Button ID="paymentButton" runat="server" Text="Payment" Font-Bold="True" Font-Names="Candara" PostBackUrl="~/pyament-page.aspx" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Candara" Text="Total Price"></asp:Label>
                    &nbsp;<asp:Label ID="totalPriceLabel" runat="server" Font-Bold="False" Font-Names="Candara" ForeColor="Green" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
