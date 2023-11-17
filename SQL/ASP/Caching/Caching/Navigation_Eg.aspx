<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigation_Eg.aspx.cs" Inherits="Caching.Navigation_Eg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblsameapp" runat="server" Text="Redirect Within Same Application"></asp:Label>
            &nbsp;&nbsp; &nbsp; &nbsp;
            <asp:Button ID="btnRedirect" runat="server" Text="Response Redirect" OnClick="btnRedirect_Click" />
             &nbsp;&nbsp; &nbsp; &nbsp;
            <asp:Button ID="btnTransfer" runat="server" Text="Server Transfer" OnClick="btnTransfer_Click" />
            <br />
            <br />
            <asp:Label ID="lbldifferentapp" runat="server" Text="Redirect to Outside Application"></asp:Label>
            &nbsp;&nbsp; &nbsp; &nbsp;
            <asp:Button ID="btnRedirect1" runat="server" Text="Response Redirect" OnClick="btnRedirect1_Click" />
             &nbsp;&nbsp; &nbsp; &nbsp;
            <asp:Button ID="btnTransfer2" runat="server" Text="Server Transfer" OnClick="btnTransfer2_Click" />
        </div>
    </form>
</body>
</html>
