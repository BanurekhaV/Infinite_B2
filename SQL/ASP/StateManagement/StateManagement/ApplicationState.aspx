<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationState.aspx.cs" Inherits="StateManagement.ApplicationState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblCount" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            <asp:Button ID="Btncount" runat="server" Text="Get Application Count" OnClick="Btncount_Click" />
        </div>
    </form>
</body>
</html>
