<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddStudent.aspx.cs" Inherits="AddStudent" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Header" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="LoginContent" ContentPlaceHolderID="ContentPage" runat="Server">
    <div>
        <center>
            <h1> Hi, Username</h1>
            <h2> Add a Student</h2>
        </center>
    </div>

    <div>
        <center>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="IdLbl" runat="server" Text="Id :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="IdTxt" runat="server" placeholder="Enter Your Id"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="NameLbl" runat="server" Text="Name  :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="NameTxt"  placeholder="Enter Your Name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:Label ID="AgeLbl" runat="server" Text="Age :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="AgeTxt" runat="server" placeholder="Enter Student Age"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:Label ID="Location" runat="server" Text="Location  :"></asp:Label>
                    </td>
                    <td>
                          <asp:TextBox ID="LocationTxt"  placeholder="Enter Student Location " runat="server"></asp:TextBox>            
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                         <asp:Button ID="AddStudentBtn" runat="server" Text="Add Student" OnClick="AddStudentBtn_Click"></asp:Button>
                    </td>
                </tr>
            </table>
            
        </center>
    </div>

</asp:Content>
