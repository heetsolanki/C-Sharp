<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AddingTwoNumbers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="numberLabel" runat="server" Text="Enter two numbers:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Number" Width="55px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="+"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" Width="55px"></asp:TextBox>
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add" />
            <br />
            <asp:Label ID="resultLabel" runat="server" Text="Result will be displayed here"></asp:Label>
        </div>
    </form>
</body>
</html>
