<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="courses.aspx.cs" Inherits="Master_Page.courses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Label ID="heading" runat="server" Text="Courses" CssClass="heading"></asp:Label>
        <br />
        <ul style="list-style-type: none">
            <li CssClass="paragraph">Web Development</li>
            <li CssClass="paragraph">Cyber Security</li>
            <li CssClass="paragraph">Data Science</li>
            <li CssClass="paragraph">Cloud Computing</li>
            <li CssClass="paragraph">AI/ML</li>
        </ul>
    </div>
</asp:Content>
