<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchStudent.aspx.cs" Inherits="SearchStudent" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Header" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="LoginContent" ContentPlaceHolderID="ContentPage" runat="Server">
    <div>
        <center>
            <h1> Hi, Username</h1>
            <h2> Search Student</h2>
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
                         <asp:Button ID="SearchStudentBtn" runat="server" Text="Search Student" OnClick="SearchStudentBtn_Click"></asp:Button>
                    </td>
                </tr>
            </table>

            <br />
            <br />
            <br />
            <asp:GridView ID="ResultsGrid" runat="server">
        </asp:GridView>
        </center>
    </div>

</asp:Content>
