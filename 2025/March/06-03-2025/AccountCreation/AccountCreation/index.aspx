<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AccountCreation.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 220px;
        }
        .auto-style3 {
            width: 220px;
            height: 31px;
        }
        .auto-style4 {
            height: 31px;
        }
        .auto-style8 {
            width: 100px;
        }
        .auto-style9 {
            width: 99px;
        }
        table td {
            padding: 5px
        }
        .btn {
            padding: 10px;
            cursor: pointer;
            border-radius: 5px;
            transition: 0.2s ease-in-out all;
        }
        #registerButton:hover {
            background-color: forestgreen;
            color: white;
        }
        #updateButton:hover {
            background-color: yellow;
            color: black;
        }
        #deleteButton:hover {
            background-color: red;
            color: white;
        }
        #displayButton:hover {
            background-color: blue;
            color: white;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="35px" ForeColor="#000066" Text="Register for New Account"></asp:Label>

            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="22px" Text="Enter name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server" Font-Size="22px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="22px" Text="Enter age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="ageTextBox" runat="server" Font-Size="22px" TextMode="Number" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="22px" Text="Select account type"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="accountTypeDDL" runat="server" Font-Size="20px">
                            <asp:ListItem>Select account type</asp:ListItem>
                            <asp:ListItem>Current</asp:ListItem>
                            <asp:ListItem>Savings</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="22px" Text="Enter address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="addressTextBox" runat="server" Font-Size="22px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="22px" Text="Enter email id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="emailTextBox" runat="server" Font-Size="22px" TextMode="Email" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="22px" Text="Enter contact"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="contactTextBox" runat="server" Font-Size="22px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style9">
                        <asp:Button ID="registerButton" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="20px" Text="Register" CssClass="btn" OnClick="registerButton_Click" />
                                </td>
                                <td class="auto-style8">
                        <asp:Button ID="updateButton" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="20px" Text="Update" CssClass="btn" OnClick="updateButton_Click" />
                                </td>
                                <td class="auto-style8">
                        <asp:Button ID="deleteButton" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="20px" Text="Delete" CssClass="btn" OnClick="deleteButton_Click"/>
                                </td>
                                <td>
                        <asp:Button ID="displayButton" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="20px" Text="Display" CssClass="btn" OnClick="displayButton_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Visible="False">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [account]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
