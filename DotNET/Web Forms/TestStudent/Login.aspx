<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" MasterPageFile="~/MasterPage.master" %>


<asp:Content ID="Header" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="LoginContent" ContentPlaceHolderID="ContentPage" runat="Server">
    <div>
        <center>
            <h1> Welcome to Student App</h1>
            <h2> Please Login to continue to use the services</h2>
        </center>
    </div>

    <div>
        <center>
            <asp:Label ID="UserLbl" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="UsernameTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Password  :"></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"></asp:Button>
        </center>
    </div>

</asp:Content>
