<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestTimeStamp.aspx.cs" Inherits="TestTimeStamp" %>

<%@ Register TagPrefix="timestamp" TagName="Timestamp" Src="~/Timestamp.ascx" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <timestamp:Timestamp ID="Timestamp1" runat="server" />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button runat="server" ID="updateTime" Text="Postback"/>
                    <timestamp:Timestamp ID="Timestamp2" runat="server" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    Getting Time
                </ProgressTemplate>
            </asp:UpdateProgress>

            <timestamp:Timestamp runat="server" />
        </div>
    </form>
</body>
</html>
