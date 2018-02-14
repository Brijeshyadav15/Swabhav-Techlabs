<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Passbook.aspx.cs" Inherits="Passbook" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Header" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    <br /><br />
    <asp:Label ID="passBookLabel" runat="server" Text="Welcome to Passbook Page"></asp:Label>
    <br /><br />
    <asp:Label ID="lblGreeting" runat="server" Text="Hello,"></asp:Label>
</asp:Content>