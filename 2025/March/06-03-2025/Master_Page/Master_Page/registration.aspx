<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="Master_Page.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <asp:Label ID="Label1" runat="server" CssClass="heading" Text="Registration"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" CssClass="input-label" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="input-field"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" CssClass="input-label" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="input-field"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="submit-btn" Text="Submit" />

    </div>
</asp:Content>
