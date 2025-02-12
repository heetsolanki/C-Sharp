<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="UserAge.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Records</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>User Data Entry</h2>
            
            <asp:Label ID="lblName" runat="server" Text="Enter Name: "></asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblAge" runat="server" Text="Enter Age: "></asp:Label>
            <asp:TextBox ID="ageTextBox" runat="server" TextMode="Number"></asp:TextBox>
            <br /><br />

            <asp:Button ID="addRecordButton" runat="server" Text="Add Record" OnClick="addRecordButton_Click" style="height: 29px"/>
            &nbsp;<asp:Button ID="updateRecordButton" runat="server" Text="Update Record" style="height: 29px" OnClick="updateRecordButton_Click"/>
            &nbsp;<asp:Button ID="deleteRecordButton" runat="server" Text="Delete Record" style="height: 29px" OnClick="deleteRecordButton_Click"/>
            &nbsp;<asp:Button ID="clearRecordButton" runat="server" Text="Clear Record" style="height: 29px" OnClick="clearRecordButton_Click"/>
            <br /><br />

            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" Visible="False"></asp:Label>
            <br /><br />

            <h3>Records in Database</h3>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderWidth="1px">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
