<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CountryCricketCaptain.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="30px" Text="Select a country"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="countryList" runat="server">
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>England</asp:ListItem>
                <asp:ListItem>Australia</asp:ListItem>
                <asp:ListItem>Netherlands</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="displayButton" runat="server" Font-Bold="True" Font-Names="Calibri" OnClick="displayButton_Click" Text="Display" />
            <br />
            <br />
            <asp:Label ID="captainName" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Captain Name:"></asp:Label>
&nbsp;<asp:TextBox ID="displayCaptain" runat="server" ReadOnly="True"></asp:TextBox>
        </div>
    </form>
</body>
</html>
