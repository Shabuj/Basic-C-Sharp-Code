<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HelloWebApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Welcome Friends </h1>
        <div>
            
        </div>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="showButton" runat="server" OnClick="Button1_Click" Text="Show" />
        <asp:Label ID="nameLabel" runat="server" ></asp:Label>
    </form>
  
</body>
</html>
