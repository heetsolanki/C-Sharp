<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FileUpload.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="40px" Text="Upload File"></asp:Label>
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" Font-Bold="True" Font-Names="Calibri" />
            <br />
            <br />
            <asp:Button ID="uploadButton" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="20px" OnClick="uploadButton_Click" Text="Upload" />
            <br />
            <br />
            <asp:Label ID="displayLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="35px" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
