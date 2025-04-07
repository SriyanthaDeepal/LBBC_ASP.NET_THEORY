<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html>
<html>
<head>
    <title>User Account Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Label to display account status -->
        <asp:Label ID="lblMessage" runat="server" Text="Account Status: Inactive" ForeColor="Red"></asp:Label>
        <br /><br />

        <!-- Button to activate account -->
        <asp:Button ID="btnActivate" runat="server" Text="Activate Account" OnClick="btnActivate_Click" />
    </form>
</body>
</html>
