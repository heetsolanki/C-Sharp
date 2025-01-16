<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LoginPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="User Login" Font-Size="25px"></asp:Label>
            <br />
            <asp:Label ID="usernameLabel" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="passwordLabel" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />
            <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" />
            <br /><br />
            <asp:Label ID="messageLabel" runat="server" Text="Login Result"></asp:Label>
        </div>
    </form>
</body>
</html>
