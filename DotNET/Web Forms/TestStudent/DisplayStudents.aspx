<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisplayStudents.aspx.cs" Inherits="Display" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Header" ContentPlaceHolderID="head" runat="Server">
</asp:Content>


<asp:Content ID="HomeContent" ContentPlaceHolderID="ContentPage" runat="Server">
    <center>
    <h1>Student Details</h1>
        <asp:GridView ID="StudentsGrid" runat="server">
        </asp:GridView>
    </center>
</asp:Content>

