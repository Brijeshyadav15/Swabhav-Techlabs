<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestAutoPostBack.aspx.cs" Inherits="TestAutoPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Auto Post Back</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="DeptLbl" runat="server" Text="Select Department :"></asp:Label>

            <asp:DropDownList ID="DeptList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="PopulateGrid">
            </asp:DropDownList>

        </div>

        <br />
        <br />
        <br />
        <asp:GridView ID="EmpGrid" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
