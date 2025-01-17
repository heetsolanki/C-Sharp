<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TotalPrice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="headingLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="40px" Text="Calculate Total Price"></asp:Label>
            <br />
            <br />
            <asp:Label ID="productLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Select Product"></asp:Label>
&nbsp;<asp:DropDownList ID="productDDL" runat="server" Font-Bold="True" Font-Names="Calibri">
                <asp:ListItem Selected="True">--Select--</asp:ListItem>
                <asp:ListItem>Pen</asp:ListItem>
                <asp:ListItem>Pencil</asp:ListItem>
                <asp:ListItem>Eraser</asp:ListItem>
                <asp:ListItem>Sharpner</asp:ListItem>
                <asp:ListItem>Cutter</asp:ListItem>
                <asp:ListItem>Scale</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="quantityLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Enter Quantity"></asp:Label>
&nbsp;<asp:TextBox ID="quantityTextBox" runat="server" Font-Names="Calibri" TextMode="Number" Width="50px">0</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="calculateButton" runat="server" BackColor="#33CC33" Font-Bold="True" Font-Names="Calibri" Font-Size="20px" OnClick="calculateButton_Click" Text="Calculate" />
            <br />
            <br />
            <asp:Label ID="totalPriceLabel" runat="server" Font-Names="Calibri" Font-Size="20px" Text="Total Price"></asp:Label>
        </div>
    </form>
</body>
</html>
