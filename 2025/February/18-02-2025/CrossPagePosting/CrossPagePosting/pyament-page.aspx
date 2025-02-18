<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pyament-page.aspx.cs" Inherits="CrossPagePosting.pyament_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 160px;
        }
        .auto-style3 {
            width: 160px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="25px" Text="Product"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="25px" Text="Quantity"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="25px" Text="Price"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="25px" Text="Total Price"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="productLabel" runat="server" Font-Names="Candara" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="quantityLabel" runat="server" Font-Names="Candara" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="priceLabel" runat="server" Font-Names="Candara" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="totalLabel" runat="server" Font-Names="Candara" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
