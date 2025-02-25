<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CrossPagePosting.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        table {
            padding: 0px 15px 15px 0px;
        }
        .auto-style2 {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Candara" Text="Enter username"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="usernameTB" runat="server" Font-Names="Candara"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Candara" Text="Choose Color"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="colorDDL" runat="server">
                            <asp:ListItem Value="Choose Color"></asp:ListItem>
                            <asp:ListItem Value="Orange"></asp:ListItem>
                            <asp:ListItem Value="Cyan"></asp:ListItem>
                            <asp:ListItem Value="Green"></asp:ListItem>
                            <asp:ListItem Value="Violet"></asp:ListItem>
                            <asp:ListItem Value="Red"></asp:ListItem>
                            <asp:ListItem Value="Yellow"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" BackColor="Cyan" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Names="Candara" PostBackUrl="~/result.aspx" Text="Submit" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
