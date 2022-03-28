<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrdersDataEntry.aspx.cs" Inherits="AdminSystemTemp2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPurchaseId" runat="server" Text="Purchase ID: "></asp:Label>
            <asp:TextBox ID="txtPurchaseId" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="lblUserId" runat="server" Text="User ID: " width="82px"></asp:Label>
            <asp:TextBox ID="txtUserId" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="lblVehicleId" runat="server" Text="Vehicle ID: " width="82px"></asp:Label>
            <asp:TextBox ID="txtVehicle" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="lblUserAddress" runat="server" Text="User Address: " width="82px"></asp:Label>
            <asp:TextBox ID="txtUserAddress" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="lblSoldDate"  runat="server" Text="Sold Date: " width="82px"></asp:Label>
            <asp:TextBox ID="txtSoldDate" textmode="Date" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkDispatched" runat="server" Text="Dispatched" />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="Button1_Click1" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            <br />

        </div>
    </form>
</body>
</html>
