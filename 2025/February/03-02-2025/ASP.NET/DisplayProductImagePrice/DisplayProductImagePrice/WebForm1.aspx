<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DisplayProductImagePrice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="25px" Text="Displaying Product Image and Total Price"></asp:Label>
            <br />
            <br />
            <asp:Label ID="productLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Select product"></asp:Label>
&nbsp;<asp:DropDownList ID="productDDL" runat="server" AutoPostBack="True" Font-Names="Calibri" ForeColor="Blue" OnSelectedIndexChanged="productDDL_SelectedIndexChanged">
                <asp:ListItem Selected="True">--Select Item--</asp:ListItem>
                <asp:ListItem>Pen</asp:ListItem>
                <asp:ListItem>Pencil</asp:ListItem>
                <asp:ListItem>Eraser</asp:ListItem>
                <asp:ListItem>Scale</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="imageLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Product Image"></asp:Label>
&nbsp;<asp:Image ID="productImage" runat="server" AlternateText="product image" BorderStyle="Solid" BorderWidth="2px" Visible="False" />
            <br />
            <br />
            <asp:Label ID="quantityLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Enter Quantity"></asp:Label>
&nbsp;<asp:TextBox ID="quantityTextBox" runat="server" Font-Names="Calibri" TextMode="Number" Width="100px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="totalButton" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="20px" ForeColor="Green" OnClick="totalButton_Click" Text="Calculate Total" />
            <br />
            <br />
            <asp:Label ID="totalLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Total Price"></asp:Label>
&nbsp;<asp:TextBox ID="totalTextBox" runat="server" Font-Names="Calibri" ReadOnly="True" TextMode="Number" Width="100px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
