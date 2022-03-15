<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lblYear">
            <asp:Label ID="lblVehicleId" runat="server" Text="Vehicle Identification Number"></asp:Label>
&nbsp;<asp:TextBox ID="txtVehicleId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblModel" runat="server" Text="Model Of Vehicle"></asp:Label>
&nbsp;<asp:TextBox ID="txtModelOfVehicle" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblYearOfVehicle" runat="server" Text="Year Of Vehicle"></asp:Label>
&nbsp;<asp:TextBox ID="txtYearOfVehicle" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDatePostAdded" runat="server" Text="Date Post Was Added"></asp:Label>
            <asp:TextBox ID="txtPostDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
