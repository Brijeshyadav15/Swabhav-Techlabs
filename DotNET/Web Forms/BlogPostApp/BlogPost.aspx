<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BlogPost.aspx.cs" Inherits="BlogPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Blog Post</title>
    <style type="text/css">
        .auto-style1 {
            width: 148px;
        }

        .auto-style3 {
            width: 128px;
        }

        .auto-style4 {
            width: 148px;
            height: 99px;
        }

        .auto-style5 {
            width: 128px;
            height: 99px;
        }

        .auto-style6 {
            height: 99px;
        }

        .auto-style7 {
            width: 148px;
            height: 21px;
        }

        .auto-style8 {
            width: 128px;
            height: 21px;
        }

        .auto-style9 {
            height: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%; height: 71px;">
            <tr>
                <td class="auto-style1">
                    <asp:Label runat="server" ID="Message"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox runat="server" ID="MessageBox"></asp:TextBox>
                </td>
                <td>
                    <asp:Button runat="server" ID="SubmitButton" OnClick="AddToList" Text="Add to List" />

                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style4">

                    <asp:ListBox runat="server" ID="MessageList"></asp:ListBox>


                </td>
                <td class="auto-style5">
                    <asp:Button runat="server" ID="Delete_Button" OnClick="Delete" Text="Delete" />

                </td>
                <td class="auto-style6">
                    <asp:Button runat="server" ID="Clear_Button" OnClick="Clear" Text="Clear ALL" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
