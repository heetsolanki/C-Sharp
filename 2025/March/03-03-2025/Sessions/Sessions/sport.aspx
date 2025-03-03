<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sport.aspx.cs" Inherits="Sessions.sport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="20px" Text="Select your favorite sport"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="sportDDL" runat="server" Font-Size="20px">
                            <asp:ListItem>Select a sport</asp:ListItem>
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>Hockey</asp:ListItem>
                            <asp:ListItem>Volleyball</asp:ListItem>
                            <asp:ListItem>Javelin Throw</asp:ListItem>
                            <asp:ListItem>Football</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="SubmitButton" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="20px" ForeColor="Green" OnClick="SubmitButton_Click" Text="Submit" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
