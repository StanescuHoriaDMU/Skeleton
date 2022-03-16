<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblVehicleId" runat="server" Text="Vehicle Identificaton Number"></asp:Label>
            <asp:TextBox ID="txtVehicleId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblModel" runat="server" height="19px" Text="Model" width="177px"></asp:Label>
&nbsp;<asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblYear" runat="server" height="19px" Text="Year Of Vehicle" width="177px"></asp:Label>
&nbsp;<asp:TextBox ID="txtYearOfVehicle" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateOfPost" runat="server" height="19px" Text="Date Post Was Added" width="177px"></asp:Label>
            <asp:TextBox ID="txtDatePostWasAdded" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" height="19px" Text="Price" width="177px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkIsSold" runat="server" height="19px" Text="Sold" width="177px" />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
