<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblVehicleId" runat="server" Text="Vehicle Number" width="138px"></asp:Label>
            <asp:TextBox ID="txtVehicleNo" runat="server"></asp:TextBox>

        </div>
        <asp:Label ID="lblModel" runat="server" Text="Model No" width="138px"></asp:Label>
        <asp:TextBox ID="txtModelNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblYear" runat="server" Text="Year Of Vehicle" width="138px"></asp:Label>
        <asp:TextBox ID="txtYearOfVehicle" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDatepostWasAdded" runat="server" Text="Date Post Was Added"></asp:Label>
        <asp:TextBox ID="txtPostAddDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="138px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkIsPosted" runat="server" Text="IsPosted" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
