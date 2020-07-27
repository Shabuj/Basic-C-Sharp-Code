<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="StudentInformationUi.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 272px;
        }
        .auto-style2 {
            width: 334px;
        }
        .auto-style3 {
            width: 334px;
            font-size: large;
            color: #0000FF;
            text-align: center;
        }
        .auto-style4 {
            width: 272px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <table style="width: 100%; height: 95px;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3"><strong>Student Information Management</strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">First Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="firstName" runat="server" Height="16px" Width="324px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Last Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="lastName" runat="server" Height="16px" Width="324px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">User Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="userName" runat="server" Height="16px" Width="324px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Reg. No.</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="regNo" runat="server" Height="16px" Width="324px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Email</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="email" runat="server" Height="16px" Width="324px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Age</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="age" runat="server" Height="16px" Width="324px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="saveButton" runat="server" Text="Save" Width="57px" OnClick="saveButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="message" runat="server" ></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">First Name</td>
                    <td class="auto-style2">
                        <asp:Label ID="firstNameLavel" runat="server" ></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Last Name</td>
                    <td class="auto-style2">
                        <asp:Label ID="lastNameLavel" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">User Name</td>
                    <td class="auto-style2">
                        <asp:Label ID="userNameLavel" runat="server" ></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Reg. No.</td>
                    <td class="auto-style2">
                        <asp:Label ID="regNoLavel" runat="server" ></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Email</td>
                    <td class="auto-style2">
                        <asp:Label ID="emailLavel" runat="server" ></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Age</td>
                    <td class="auto-style2">
                        <asp:Label ID="ageLavel" runat="server" ></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="nextButton" runat="server" Text="Go to Student List Page" Width="197px" OnClick="nextButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

            </table>
           
        </div>
    </form>
</body>
</html>
