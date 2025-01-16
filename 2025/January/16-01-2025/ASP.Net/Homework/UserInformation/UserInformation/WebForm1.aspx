<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UserInformation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="nameLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Enter Name"></asp:Label>
&nbsp;<asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="phoneLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Enter Phone Number"></asp:Label>
&nbsp;<asp:TextBox ID="phoneBox" runat="server" TextMode="Phone"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="genderLabel" runat="server" Font-Bold="True" Font-Names="Calibri" Text="Select Gender"></asp:Label>
&nbsp;<asp:RadioButton ID="maleButton" runat="server" Font-Names="Calibri" GroupName="gender" Text="Male" />
&nbsp;
            <asp:RadioButton ID="femaleButton" runat="server" Font-Names="Calibri" GroupName="gender" Text="Female" />
            <br />
            <br />
            <asp:Label ID="languageLabel" runat="server" Font-Bold="True" Font-Names="Calibri" style="font-weight: 700" Text="Select Language"></asp:Label>
            <br />
            <asp:CheckBox ID="english" runat="server" Font-Names="Calibri" Text="English" />
            <br />
            <asp:CheckBox ID="hindi" runat="server" Font-Names="Calibri" Text="Hindi" />
            <br />
            <asp:CheckBox ID="marathi" runat="server" Font-Names="Calibri" Text="Marathi" />
            <br />
            <br />
            <asp:Button ID="submitButton" runat="server" Font-Bold="True" Font-Names="Calibri" OnClick="submitButton_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="30px" Text="Displaying User Information"></asp:Label>
            <br />
            <br />
            <asp:Label ID="displayName" runat="server" Font-Names="Calibri" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="displayPhone" runat="server" Font-Names="Calibri" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="displayGender" runat="server" Font-Names="Calibri" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="displayLanguage" runat="server" Font-Names="Calibri" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
