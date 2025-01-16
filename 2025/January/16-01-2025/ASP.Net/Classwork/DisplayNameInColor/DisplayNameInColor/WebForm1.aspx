<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DisplayNameInColor.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="textLabel" runat="server" Text="Enter text:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="RedButton" runat="server" BackColor="#FF3300" Font-Bold="True" OnClick="RedButton_Click" Text="Red" />
            <asp:Button ID="GreenButton" runat="server" BackColor="Lime" Font-Bold="True" OnClick="GreenButton_Click" Text="Green" />
            <br />
            <asp:Label ID="displayLabel" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
