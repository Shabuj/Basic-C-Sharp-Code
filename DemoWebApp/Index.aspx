<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DemoWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="nameTextBox" runat="server" Height="16px" Width="157px"></asp:TextBox>
        <br />
       
        <br />
        <asp:Button ID="addButton" runat="server" BackColor="Red" OnClick="addButton_Click" Text="Add" />
        <br />
       
        <br />
        <asp:Button ID="showButton" runat="server" Text="Show" BackColor="Blue" OnClick="showButton_Click" />
        <br />
        <br />
        <asp:Label ID="showLabel" runat="server" BackColor="#CCFFFF" ForeColor="#00CC00"></asp:Label>
      
        <br />
        <br />
        <asp:ListBox ID="nameListBox" runat="server" Height="129px"  Width="126px"></asp:ListBox>
      
    </form>
</body>
</html>
