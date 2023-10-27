<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdForm.aspx.cs" Inherits="CrossPage_PostBack.AdForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server"  Target="_blank" AdvertisementFile="~/Photos.xml"/>
        </div>
    </form>
</body>
</html>
