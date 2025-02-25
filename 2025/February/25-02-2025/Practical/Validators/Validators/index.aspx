<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Validators.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        table {
            padding: 20px;
        }
        .auto-style3 {
            height: 23px;
            width: 217px;
        }
        .auto-style4 {
            width: 217px;
        }
        .auto-style5 {
            height: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="18px" Text="Username"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="usernameTB" runat="server" Font-Names="Calibri"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="usernameTB" Display="Dynamic" ErrorMessage="Enter username" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="18px" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="passwordTB" runat="server" Font-Names="Calibri"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwordTB" Display="Dynamic" ErrorMessage="Enter password" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="18px" Text="Confirm Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="confirmPasswordTB" runat="server" Font-Names="Calibri"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="confirmPasswordTB" ControlToValidate="passwordTB" Display="Dynamic" ErrorMessage="Passwords don't match" ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="confirmPasswordTB" Display="Dynamic" ErrorMessage="Enter confirm password" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="18px" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="ageTB" runat="server" Font-Names="Calibri"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="ageTB" Display="Dynamic" ErrorMessage="Age must be between 18 - 40" ForeColor="Red" MaximumValue="40" MinimumValue="18" SetFocusOnError="True">*</asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ageTB" Display="Dynamic" ErrorMessage="Enter age" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="18px" Text="State"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="stateDDL" runat="server" Font-Names="Calibri">
                            <asp:ListItem Value="Select State"></asp:ListItem>
                            <asp:ListItem Value="Maharashtra"></asp:ListItem>
                            <asp:ListItem Value="Gujarat"></asp:ListItem>
                            <asp:ListItem Value="Rajasthan"></asp:ListItem>
                            <asp:ListItem Value="Karnataka"></asp:ListItem>
                            <asp:ListItem Value="Kerala"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="usernameTB" Display="Dynamic" ErrorMessage="Select a state" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="18px" Text="Email Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="emailTB" runat="server" Font-Names="Calibri"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTB" Display="Dynamic" ErrorMessage="Invalid email" ForeColor="Red" SetFocusOnError="True" ValidationExpression="email" ValidationGroup="^\S+@\S+$">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="emailTB" Display="Dynamic" ErrorMessage="Enter email id" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="18px" Text="Mobile Number"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="mobileNumberTB" runat="server" Font-Names="Calibri"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="mobileNumberTB" Display="Dynamic" ErrorMessage="Mobile number must be 10 digits long." ForeColor="Red" SetFocusOnError="True" ValidationExpression="phone" ValidationGroup="[0-9]{10}">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="mobileNumberTB" Display="Dynamic" ErrorMessage="Enter mobile numbers" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="15px" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style5">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

