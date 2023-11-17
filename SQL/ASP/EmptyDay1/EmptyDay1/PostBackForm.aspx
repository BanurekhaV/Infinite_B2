<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBackForm.aspx.cs" Inherits="EmptyDay1.PostBackForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtdata" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnstate" runat="server" Text="GetCount" OnClick="btnstate_Click" />
        </div>
    </form>
</body>
</html>
