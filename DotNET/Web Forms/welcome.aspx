<%@ Page Language="C#" CodeFile="welcome.aspx.cs" Inherits="welcome" %>

<html>
<body>
    <h1>Welcome to Aspx Page</h1>

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
