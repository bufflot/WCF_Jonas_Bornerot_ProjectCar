<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerService.aspx.cs" Inherits="HelloWebClient.CustomerService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 211px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="lblFname" runat="server" Text="First Name"></asp:Label>
            <br />
            <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSaveEdit" runat="server" OnClick="btnSaveEdit_Click" Text="Save Edit" Visible="False" />
            <br />
            <asp:Label ID="lblLname" runat="server" Text="Last Name"></asp:Label>
            <br />
            <asp:TextBox ID="tbLastName" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="E-mail"></asp:Label>
            <br />
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblTel" runat="server" Text="Mobile"></asp:Label>
            <br />
            <asp:TextBox ID="tbTel" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAddCustomer" runat="server" OnClick="btnAddCustomer_Click" Text="Add Customer" Width="100px" />
            <asp:Button ID="btnSearchCustomer" runat="server" OnClick="btnSearchCustomer_Click" Text="Search" />
            <br />
            <br />
            <br />
        </div>
        <asp:ListBox ID="lbCustomer" runat="server" Height="213px" Width="327px" AutoPostBack="True"></asp:ListBox>
        <br />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="55px" />
        <asp:Button ID="btnDeleteCustomer" runat="server" OnClick="btnDeleteCustomer_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
