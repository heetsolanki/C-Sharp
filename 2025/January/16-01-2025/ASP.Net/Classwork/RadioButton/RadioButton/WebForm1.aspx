<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioButton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="30px" Text="Select Color"></asp:Label>
            <br />
            <asp:RadioButton ID="red" runat="server" BackColor="Red" Font-Bold="True" Font-Names="Calibri" ForeColor="White" GroupName="colors" Text="Red" />
&nbsp;
            <asp:RadioButton ID="green" runat="server" BackColor="Green" Font-Bold="True" Font-Names="Calibri" ForeColor="White" GroupName="colors" Text="Green" />
&nbsp;
            <asp:RadioButton ID="yellow" runat="server" BackColor="Yellow" Font-Bold="True" Font-Names="Calibri" ForeColor="Black" GroupName="colors" Text="Yellow" />
&nbsp;
            <asp:RadioButton ID="blue" runat="server" BackColor="Blue" Font-Bold="True" Font-Names="Calibri" ForeColor="White" GroupName="colors" Text="Blue" />
&nbsp;
            <asp:RadioButton ID="pink" runat="server" BackColor="Pink" Font-Bold="True" Font-Names="Calibri" ForeColor="Black" GroupName="colors" Text="Pink" />
&nbsp;
            <asp:RadioButton ID="violet" runat="server" BackColor="Violet" Font-Bold="True" Font-Names="Calibri" ForeColor="Black" GroupName="colors" Text="Violet" />
&nbsp;
            <asp:RadioButton ID="orange" runat="server" BackColor="Orange" Font-Bold="True" Font-Names="Calibri" ForeColor="Black" GroupName="colors" Text="Orange" />
            <br />
            <br />
            <asp:Button ID="changeColorButton" runat="server" OnClick="changeColorButton_Click" Text="Change Color" />
            <br />
            <br />
            <asp:Label ID="colorMessage" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="35pt" Font-Underline="True" Text="Hello World!"></asp:Label>
        </div>
    </form>
</body>
</html>
