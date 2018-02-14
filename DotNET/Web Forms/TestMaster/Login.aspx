<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" MasterPageFile="~/MasterPage.master"%>

<asp:Content ID="Header" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    <asp:Label ID="loginLabel" runat="server" Text="Welcome to Login Page"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblUsername" runat="server" Text="Username :"></asp:Label>
    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

    <br />
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="BtnLoginClicked" />
</asp:Content>