
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="LoginForm.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="30px" Text="LOGIN FORM"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="usernameLabel" runat="server" Font-Bold="True" Font-Names="Candara" Text="Enter Username"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="usernameTextBox" runat="server" Font-Bold="False" Font-Names="Candara"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="passwordLabel" runat="server" Font-Bold="True" Font-Names="Candara" Text="Enter Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="passwordTextBox" runat="server" Font-Names="Candara" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="loginButton" runat="server" BackColor="#009933" Font-Bold="True" Font-Names="Candara" Font-Size="20px" OnClick="loginButton_Click" Text="LOGIN" />
                    </td>
                </tr>
            </table>
        </div>

    </form>
</body>
</html>
