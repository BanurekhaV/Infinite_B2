<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridwithSource.aspx.cs" Inherits="Caching.GridwithSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="EID" HeaderText="EID" ReadOnly="True" SortExpression="EID" />
                    <asp:BoundField DataField="EName" HeaderText="EName" SortExpression="EName" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                    <asp:BoundField DataField="DeptId" HeaderText="DeptId" SortExpression="DeptId" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InfiniteDBConnectionString %>" SelectCommand="SELECT * FROM [tblEmployee] ORDER BY [EName]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
