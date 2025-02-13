<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Register_Database.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 152px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="40px" ForeColor="Red" Text="Login"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Mobile Number"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="mobileTextBox" runat="server" Font-Names="Calibri"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="passwordTextBox" runat="server" Font-Names="Calibri" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="message" runat="server" Font-Bold="False" Font-Names="Calibri" ForeColor="Green" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="RegisterButton" runat="server" Font-Bold="True" Font-Names="Calibri" ForeColor="Blue" Text="Login" OnClick="RegisterButton_Click" />
                    </td>
                    <td>
                        <asp:Button ID="RegisterButton0" runat="server" Font-Bold="True" Font-Names="Calibri" ForeColor="Blue" OnClick="RegisterButton_Click" Text="Register" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
