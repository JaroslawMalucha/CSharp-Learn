<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Identity.aspx.cs" Inherits="MyFirstWebApp.Identity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 216px">
            What is your first name?
            <asp:TextBox ID="txtbFirstName" runat="server"></asp:TextBox>
            <br />
            What is your last name?
            <asp:TextBox ID="txtbLastName" runat="server" OnTextChanged="lastName_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" style="height: 26px" Text="Click Me Please" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
