<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="Validations.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center;color:blue;font-size:24px;">Registration Form</h2>
            <br />
            User Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server">             
            </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                 ControlToValidate="txtname" ErrorMessage="Name Cannot be Blank" 
                 Font-Bold="True" ForeColor="Red" ValidationGroup="G1">*</asp:RequiredFieldValidator>
             <br />
            Password :  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtpwd" ErrorMessage="Please Enter Password"
                Font-Bold="True" ForeColor="Red" ValidationGroup="G1">*</asp:RequiredFieldValidator>
            <br />
            Confirm Password : &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtcpwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcpwd" ErrorMessage="Confirm Password is must" Font-Bold="True" ForeColor="Red" Display="Dynamic" ValidationGroup="G1">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtcpwd" ErrorMessage="Mismatch in Passwords" Font-Bold="True" ForeColor="Red" Display="Dynamic" ValidationGroup="G1">*</asp:CompareValidator>
            <br />
            Age : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtage" ErrorMessage="Age value is must" Font-Bold="True" ForeColor="Red" Display="Dynamic" ValidationGroup="G1">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" ErrorMessage="Age must be between 21 and 60" Font-Bold="True" ForeColor="Red" MaximumValue="60" MinimumValue="21" Type="Integer" Display="Dynamic" ValidationGroup="G1">*</asp:RangeValidator>
            <br />
            Email  : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtmail" ErrorMessage="Email is required" Font-Bold="True" ForeColor="Red" Display="Dynamic" ValidationGroup="G1">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtmail" ErrorMessage="Invalid Email Format" Font-Bold="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" ValidationGroup="G1">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="btnsubmit" runat="server" Text="Register" OnClick="btnsubmit_Click" ValidationGroup="G1" />
            <br />
            <br />
           </div>
        
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="G1" />
        <hr />
          <div>
            <h1 style="text-align:center;color:blue;font-size:24px">Login Form</h1>
             Login Name :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtlogin" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtlogin" ErrorMessage="Enter Login name" ForeColor="Red" ValidationGroup="G2">*</asp:RequiredFieldValidator>
            <br />
            Password : &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtpass" ErrorMessage="Password cannot be Blank" ForeColor="Red" ValidationGroup="G2">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Btnlogin" runat="server" Text="Login" OnClick="Btnlogin_Click" ValidationGroup="G2" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="G2" />
       </div>
    </form>
</body>
</html>
