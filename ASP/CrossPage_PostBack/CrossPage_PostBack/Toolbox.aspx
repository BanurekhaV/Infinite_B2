<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Toolbox.aspx.cs" Inherits="CrossPage_PostBack.Toolbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" /><br />
            <asp:Button ID="btnUpload" runat="server" Text="Upload Files" OnClick="btnUpload_Click" />
            <asp:Label ID="lbl1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
