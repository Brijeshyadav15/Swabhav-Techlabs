<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestValidation.aspx.cs" Inherits="TestValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 127px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="NameTxt" ForeColor="Red" runat="server" ErrorMessage="Name is Required"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="AgeTxt" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="AgeTxt" Type="Integer" MinimumValue="18" MaximumValue="35" ErrorMessage="Age should be in the range of 18 - 35" ForeColor="Red"></asp:RangeValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Salary"></asp:Label>
                </td>
                <td style="margin-left: 160px">
                    <asp:TextBox ID="SalaryTxt" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" Operator="GreaterThanEqual" ControlToValidate="SalaryTxt" ValueToCompare="5000" ErrorMessage="Salary should be greater than 5000" ForeColor="Red"></asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="EmailTxt" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*"
                        runat="server" ControlToValidate="EmailTxt" ErrorMessage="Incorrect Email Address" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            <asp:Label ID="ResponseLbl" runat="server" Text=""></asp:Label>
        </p>
    </form>

</body>
</html>
