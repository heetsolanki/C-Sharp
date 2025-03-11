<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="UpdatePanel.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="dateTimeLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="25px" Text="Label"></asp:Label>
                    <br /><br />
                    <asp:Button ID="dateTimeBtn" runat="server" Text="Fetch Date & Time" Font-Names="Calibri" Font-Size="20px" OnClick="dateTimeBtn_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
