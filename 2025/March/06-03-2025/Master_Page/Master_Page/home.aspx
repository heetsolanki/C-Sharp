<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Master_Page.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Label ID="heading" runat="server" Text="Welcome to our website!" CssClass="heading"></asp:Label>
        <br />
        <asp:Label ID="paragraph" runat="server" Text="This website provides information about our courses and registration process." CssClass="paragraph"></asp:Label>
    </div>
</asp:Content>
