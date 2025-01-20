<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DisplayTheatre.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="selectCityLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Select City"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:RadioButton ID="mumbai" runat="server" AutoPostBack="True" Checked="True" Font-Bold="False" Font-Names="Calibri" GroupName="city" OnCheckedChanged="mumbai_CheckedChanged" Text="Mumbai" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:RadioButton ID="pune" runat="server" AutoPostBack="True" Font-Names="Calibri" GroupName="city" OnCheckedChanged="pune_CheckedChanged" Text="Pune" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:DropDownList ID="mallDDL" runat="server" Font-Names="Calibri" ForeColor="Purple" Visible="False">
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="timingButton" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Show Timings" ForeColor="Blue" OnClick="timingButton_Click" Width="111px" />
                    <br />
                    <br />
                    <asp:Label ID="movie1" runat="server" Font-Names="Calibri" Text="Movie 1"></asp:Label>
                    <br />
                    <asp:Label ID="movie2" runat="server" Font-Names="Calibri" Text="Movie 2"></asp:Label>
                    <br />
                    <asp:Label ID="movie3" runat="server" Font-Names="Calibri" Text="Movie 3"></asp:Label>
                </td>
            </tr>
            </table>

    </form>
</body>
</html>
