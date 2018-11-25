<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="ListImplementationApp.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Input"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="inputTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Output"></asp:Label>
&nbsp;<asp:TextBox ID="outputTextBox" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
