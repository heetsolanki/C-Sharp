<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book.aspx.cs" Inherits="Sessions.book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 281px;
            height: 34px;
        }
        .auto-style3 {
            width: 281px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
            width: 912px;
        }
        .auto-style5 {
            height: 34px;
            width: 912px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="20px" Text="Enter your name"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="nameTB" runat="server" Font-Names="Candara" Font-Size="20px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="20px" Text="Select your favorite book"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="bookDDL" runat="server" Font-Size="20px">
                            <asp:ListItem>Select a book</asp:ListItem>
                            <asp:ListItem>The God of Small Things</asp:ListItem>
                            <asp:ListItem>Train to Pakistan</asp:ListItem>
                            <asp:ListItem>A Suitable Boy</asp:ListItem>
                            <asp:ListItem>The Palace of Illusions</asp:ListItem>
                            <asp:ListItem>The White Tiger</asp:ListItem>
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
