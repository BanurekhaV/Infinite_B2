<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionSecond.aspx.cs" Inherits="StateManagement.SessionSecond" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lblname" runat="server" Text=" "></asp:Label>
        </div>
        <p>
            <asp:Label ID="Lblmail" runat="server" Text=" "></asp:Label>
        </p>
        <asp:Button ID="Btnretrieve" runat="server" Text="Retrieve Session" OnClick="Btnretrieve_Click" />
    </form>
</body>
</html>
