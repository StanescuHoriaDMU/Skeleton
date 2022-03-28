<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <label for="txtPurchaseId" style="width:198px" id="lblPurchaseId">Purchase ID:</label>
            <input type="text" id="txtPurchaseId" name="purchaseId" /><br />
            <label for="txtUserId" id="lblUserId" style="width:198px">User Id:</label>
            <input type="text" id="txtUserId" name="userId" style="width:198px"/><br/>
            <label for="txtVehicleId" id="lblVehicleId" style="width:198px">Vehicle ID:</label>
            <input type="text" id="txtVehicleId" name="vehicleId" /><br />
            <label for="txtUserAddress" id="lblUserAddress" style="width:198px">User Address:</label>
            <input type="text" id="txtUserAddress" name="userAddress" /><br/>
            <label for="txtSoldDate" style="width:198px" id="lblSoldDate">Sold Date:</label>
            <input type="date" id="txtSoldDate" name="SoldDate" /><br/>
            <input type="checkbox" id="chkDispatched" text="Dispatched" name="dispatched" value="true" title="Dispatched"/>
            <label for="chkDispatched" style="text-align: center; font-weight: 700">Dispatched</label><br />
            <label for="txtError" id="lblError">[lblError]</label>
            <span id="spnError"></span><br />
            <button id="btnOk" type="button">OK</button><button id="btnCancel" type="button">Cancel

                                             </button>
        </div>
    </form>
</body>
</html>
