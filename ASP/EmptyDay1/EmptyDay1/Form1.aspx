﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="EmptyDay1.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function wishes() {
            alert("hello, I am a JS");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Lblname" runat="server" Text="Enter UserName"></asp:Label>
            <asp:TextBox ID="txtname" runat="server" Width="258px" style="margin-left: 39px" ></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Btnwish" runat="server" Text="Click" OnClick="Btnwish_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <input id="Button1" type="button" onclick="wishes()" value="Html button" /></p>
    </form>
</body>
</html>
