<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Tree_View_Control.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server">
                <Nodes>
                    <asp:TreeNode Text="BCA" Value="BCA">
                        <asp:TreeNode Text="FYBCA" Value="FYBCA">
                            <asp:TreeNode NavigateUrl="~/c.aspx" Text="C" Value="C"></asp:TreeNode>
                            <asp:TreeNode Text="DCF" Value="DCF" NavigateUrl="~/dcf.aspx"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="SYBCA" Value="SYBCA">
                            <asp:TreeNode NavigateUrl="~/python.aspx" Text="Python" Value="Python"></asp:TreeNode>
                            <asp:TreeNode Text="AWP" Value="AWP" NavigateUrl="~/awp.aspx"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="TYBCA" Value="TYBCA">
                            <asp:TreeNode NavigateUrl="~/mern.aspx" Text="MERN" Value="MERN"></asp:TreeNode>
                            <asp:TreeNode Text="Data Science" Value="Data Science" NavigateUrl="~/data_science.aspx"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
            </asp:TreeView>
        </div>
    </form>
</body>

</html>
