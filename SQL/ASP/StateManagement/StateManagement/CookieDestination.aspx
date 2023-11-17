<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieDestination.aspx.cs" Inherits="StateManagement.CookieDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text=" "></asp:Label><br />
            <asp:Label ID="lblmail" runat="server" Text=" "></asp:Label><br />
            <asp:Button ID="btnload" runat="server" Text="Load data" OnClick="btnload_Click" />

        </div>
    </form>
</body>
</html>
