<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChangeColorFontStyle.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="nameLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Enter name"></asp:Label>
&nbsp;<asp:TextBox ID="nameTextBox" runat="server" Font-Names="Calibri"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="colorLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Select Color"></asp:Label>
&nbsp;<asp:RadioButton ID="red" runat="server" Font-Bold="True" ForeColor="Red" GroupName="color" Text="Red" AutoPostBack="True" OnCheckedChanged="red_CheckedChanged" />
&nbsp;<asp:RadioButton ID="green" runat="server" Font-Bold="True" ForeColor="Green" GroupName="color" Text="Green" AutoPostBack="True" OnCheckedChanged="green_CheckedChanged" />
&nbsp;<asp:RadioButton ID="blue" runat="server" Font-Bold="True" ForeColor="Blue" GroupName="color" Text="Blue" AutoPostBack="True" OnCheckedChanged="blue_CheckedChanged" />
            <br />
            <br />
            <asp:Label ID="fontStyleLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Select Font Style"></asp:Label>
&nbsp;<asp:CheckBox ID="bold" runat="server" Font-Bold="True" Text="Bold" AutoPostBack="True" OnCheckedChanged="bold_CheckedChanged" />
&nbsp;<asp:CheckBox ID="italic" runat="server" Font-Italic="True" Text="Italic" AutoPostBack="True" OnCheckedChanged="italic_CheckedChanged" />
&nbsp;<asp:CheckBox ID="underline" runat="server" Font-Underline="True" Text="Underline" AutoPostBack="True" OnCheckedChanged="underline_CheckedChanged" />
            <br />
            <br />
            <asp:Label ID="displayLabel" runat="server" Text="Display Text" Font-Bold="False" Font-Names="Calibri" Font-Size="30px"></asp:Label>
        </div>
    </form>
</body>
</html>
