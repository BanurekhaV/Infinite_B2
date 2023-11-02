<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientForm.aspx.cs" Inherits="WebServices_Client.ClientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Number 1: <asp:TextBox ID="txtnum1" runat="server">

                            </asp:TextBox><br />
            Enter Number 2: <asp:TextBox ID="txtnum2" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter a String : <asp:TextBox ID="txtstr" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblmessage" runat ="server">

            </asp:Label> 
            <br />
            <br />
            <asp:Button ID="btnmessage" runat="server" Text="GetMessage" OnClick="btnmessage_Click" />
            <asp:Button ID="btnaddnos" runat="server" Text="Add Nos" OnClick="btnaddnos_Click" />
            <asp:Button ID="btndisplay" runat="server" Text="Display" OnClick="btndisplay_Click" />

        </div>
    </form>
</body>
</html>
