<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="EmptyDay1.HiddenField" %>

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
                <asp:HiddenField ID="HiddenField1" runat="server" />
                <br />
                <asp:Label ID="lblemail" runat="server" Text="Email">
                </asp:Label>
          <asp:TextBox ID="txtmail" runat="server" style="margin-left: 61px"></asp:TextBox>
             <asp:HiddenField ID="HiddenField2" runat="server" />
            <br />
            <br />
            <asp:Button ID="Btnstore" runat="server" Text="Store" OnClick="Btnstore_Click" />
            &nbsp;     &nbsp;     &nbsp;     &nbsp;     &nbsp;
            <asp:Button ID="Btnload" runat="server" Text="Load" OnClick="Btnload_Click" />
            <br />
            <br />
            <asp:Label ID="Lbldata" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
