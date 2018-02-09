<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestGrid.aspx.cs" Inherits="TestGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 288px">

            <asp:Button ID="PopulateBtn" runat="server" Text="Populate"  OnClick="PopulateGrid"/>

            <br />
            <br />
            <asp:Button ID="PostbackBtn" runat="server" Text="Postback" />
            <br />
            <br />
            <asp:GridView ID="EmpGrid" runat="server" Width="274px">
            </asp:GridView>


        </div>
    </form>
</body>
</html>
