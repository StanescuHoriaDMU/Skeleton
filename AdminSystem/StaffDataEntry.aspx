<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" width="88px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffNo" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnOK_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="88px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth" width="88px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblUserName" runat="server" Text="UserName" width="88px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="lblEmployed" runat="server" Text="Is Employed?" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
