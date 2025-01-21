<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChangeColorUsingRadioButtons.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 174px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="colorLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="25px" Text="Select Color"></asp:Label>
                </td>
                <td>
                    <asp:RadioButton ID="red" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri" ForeColor="Red" GroupName="color" OnCheckedChanged="red_CheckedChanged" Text="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:RadioButton ID="green" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri" ForeColor="Green" GroupName="color" OnCheckedChanged="green_CheckedChanged" Text="Green" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:RadioButton ID="blue" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri" ForeColor="Blue" GroupName="color" OnCheckedChanged="blue_CheckedChanged" Text="Blue" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <br />
                    <asp:Label ID="changeColorLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="25px" Text="The color of the text will change"></asp:Label>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
