<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm.aspx.cs" Inherits="Validations.CustomForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function IsEven(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
            }
            else {
                if ((args.Value > 0) && (args.Value % 2 == 0)) {
                    args.IsValid = true;
                }else {
                    args.IsValid = false;
                }
            }
        }
    </script>
</head>
<body>
    <h1>Using Client Side and Server Side Validation</h1>
    <form id="form1" runat="server">
        <div>
            Please Enter a Positive Even Number : &nbsp;&nbsp;
            <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Not a Positive or an Even Number"
                ForeColor="Red" ClientValidationFunction="IsEven" ControlToValidate="txtnum"
                OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            
        </div>
    </form>
</body>
</html>
