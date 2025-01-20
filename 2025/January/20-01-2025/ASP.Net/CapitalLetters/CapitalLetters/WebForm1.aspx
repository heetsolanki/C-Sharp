<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CapitalLetters.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="username" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Enter Username"></asp:Label>
&nbsp;<asp:TextBox ID="usernameTextBox" runat="server" Font-Names="Calibri"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="convertButton" runat="server" OnClick="convertButton_Click" style="margin-bottom: 0px" Text="Convert to Capital" />
            <br />
            <br />
            <asp:Label ID="capitalLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Capital Letters"></asp:Label>
        </div>
    </form>
</body>
</html>
