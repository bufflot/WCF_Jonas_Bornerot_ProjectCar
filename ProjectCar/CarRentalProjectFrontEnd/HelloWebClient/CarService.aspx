<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarService.aspx.cs" Inherits="HelloWebClient.CarService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 581px;
        }
    </style>
    </head>
<body style="height: 550px">
    <form id="form1" runat="server" class="auto-style1">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            <asp:Label ID="AddCarLabel" runat="server" Text="Car"></asp:Label>
        </p>
        <asp:TextBox ID="TbBrand" runat="server"></asp:TextBox>
        <asp:Label ID="AddCarBrandLabel" runat="server" Text="Brand"></asp:Label>
        <br />
        <p>
            <asp:TextBox ID="TbModel" runat="server"></asp:TextBox>
            <asp:Label ID="AddCarModelLabel" runat="server" Text="Model"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TbReg" runat="server"></asp:TextBox>
            <asp:Label ID="AddCarRegNrLabel" runat="server" Text="Registration number"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TbYear" runat="server"></asp:TextBox>
            <asp:Label ID="AddCarYearLabel" runat="server" Text="Year"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnAddCar" runat="server" OnClick="btnAddCar_Click" Text="Add" Width="55px" />
            <asp:Button ID="btnFindCar" runat="server" Text="Search" OnClick="btnFindCar_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" Text="List of Cars"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Width="261px" Height="120px">
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:CheckBox ID="chkShowAll" runat="server" Text="Show all cars" OnCheckedChanged="chkShowAll_CheckedChanged" AutoPostBack="True" />
        </p>
        <p>
            <asp:Button ID="btnDeleteCar" runat="server" OnClick="btnDeleteCar_Click" Text="Delete Car" />
            <asp:Button ID="btnReturnCar" runat="server" OnClick="btnReturnCar_Click" Text="Return Car" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
    </body>
</html>
