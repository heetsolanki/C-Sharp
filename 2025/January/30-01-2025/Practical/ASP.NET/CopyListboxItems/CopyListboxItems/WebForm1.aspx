<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CopyListboxItems.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="30px" Text="Copy Listbox 1 to Listbox 2"></asp:Label>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Font-Names="Calibri" Font-Size="15px" Height="158px" SelectionMode="Multiple" Width="141px">
                <asp:ListItem>Pen</asp:ListItem>
                <asp:ListItem>Pencil</asp:ListItem>
                <asp:ListItem>Eraser</asp:ListItem>
                <asp:ListItem>Scale</asp:ListItem>
                <asp:ListItem>Notebook</asp:ListItem>
                <asp:ListItem>Notepad</asp:ListItem>
                <asp:ListItem>Bag</asp:ListItem>
                <asp:ListItem>Water Bottle</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="copyButton" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="20px" OnClick="copyButton_Click" style="height: 36px" Text="Copy" />
            <br />
            <br />
            <asp:ListBox ID="ListBox2" runat="server" Font-Bold="False" Font-Names="Calibri" Font-Size="15px" Height="140px" Width="140px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
