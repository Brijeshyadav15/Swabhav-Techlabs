<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Transaction.aspx.cs" Inherits="Transaction" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Header" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    <br /><br />
    <asp:Label ID="transactionLabel" runat="server" Text="Welcome to Transaction Page"></asp:Label>
    <br /><br />
    <asp:Label ID="lblGreeting" runat="server" Text="Hello,"></asp:Label>
    
</asp:Content>
