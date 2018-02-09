<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 106px;
        }

        .auto-style2 {
            width: 259px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%; height: 118px;">
            <tr>
                <td class="auto-style1">

                    <asp:Label ID="LblUsername" runat="server" Text="UserName"></asp:Label>

                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="UserNameTxt" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
                    <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="LoginClick" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
