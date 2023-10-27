<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuerySource.aspx.cs" Inherits="StateManagement.QuerySource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text="Uname">  </asp:Label> 
                <asp:TextBox ID="txtname" runat="server" style="margin-left: 53px; margin-top: 6px"></asp:TextBox>
                <br />
                <asp:Label ID="lblemail" runat="server" Text="Email">
                </asp:Label>
          <asp:TextBox ID="txtmail" runat="server" style="margin-left: 61px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Btnredirect" runat="server" Text="Redirect" OnClick="Btnredirect_Click" />
        </div>
    </form>
</body>
</html>
