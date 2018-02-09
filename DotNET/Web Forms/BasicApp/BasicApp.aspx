<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BasicApp.aspx.cs" Inherits="BasicApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <asp:Label runat="server" ID="Name1" Text="Enter your name"></asp:Label>
        <asp:TextBox runat="server" ID="txtName" Text="Brijesh"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="btnHello" Text="HelloButton" OnClick="btnHello_click" />
        <br />
        <asp:Label runat="server" ID="lblDisplay"></asp:Label>
    </form>
</body>
</html>
