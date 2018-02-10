<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Header" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    <asp:Label ID="aboutLabel" runat="server" Text="Welcome to Home Page"></asp:Label>
</asp:Content>