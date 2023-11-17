<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Authentication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table>
            <tr>
                <td>
                    <asp:Label id="lblname" runat="server" Text="UserName">
                        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                    </asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                <asp:Label id="Lblpassword" runat="server" Text="Password">
                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    </asp:Label>
                    </td>
            </tr>
            <tr>
                <td>
 <asp:CheckBox ID="chkrememberme" Font-Size="Small" Text="Remember me" runat="server" />
                </td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblmessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        <a href="Register.aspx">Click here to Register</a> If you do not have username and password
       </div>
    </form>
</body>
</html>
