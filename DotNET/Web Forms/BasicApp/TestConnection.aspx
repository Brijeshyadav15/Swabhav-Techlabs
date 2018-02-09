<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestConnection.aspx.cs" Inherits="TestConnection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 167px">

            <asp:Button ID="ConnectBtn" OnClick="ConnectToDB" runat="server" Text="Connect" />
            <br />
            <br />
            <br />
            <asp:Label ID="InfoLabel" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
