<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Header" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    <asp:Label ID="aboutLabel" runat="server" Text="Welcome to About Page"></asp:Label>
</asp:Content>
