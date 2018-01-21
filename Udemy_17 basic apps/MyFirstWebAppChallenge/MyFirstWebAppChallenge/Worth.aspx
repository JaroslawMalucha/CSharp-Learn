<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Worth.aspx.cs" Inherits="MyFirstWebAppChallenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How old are you?
            <asp:TextBox ID="AgeBox" runat="server"></asp:TextBox>
            <br />
            How much are your worth?
            <asp:TextBox ID="WorthBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="JudgeButton" runat="server" OnClick="JudgeButton_Click" Text="Judge" />
            <br />
            <br />
            <asp:Label ID="VerdictLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
