<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" aria-autocomplete="list">
        <div>
        </div>
        <asp:Label ID="lblUserId" runat="server" height="19px" Text="User Id" width="82px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblFullName" runat="server" height="19px" Text="Full Name" width="82px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEmailAdress" runat="server" height="19px" Text="Email Adress" width="82px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtEmailAdress" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblUsername" runat="server" height="19px" Text="Username" width="82px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="checkboxVerifiedCustomer" runat="server" Text="Is Verified Customer" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
