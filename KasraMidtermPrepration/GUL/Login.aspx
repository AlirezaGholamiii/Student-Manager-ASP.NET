<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KasraMidtermPrepration.GUL.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style5 {
            width: 381px;
        }
        .auto-style6 {
            width: 176px;
        }
        .auto-style8 {
            width: 448px;
            height: 26px;
        }
        .auto-style11 {
            height: 26px;
        }
        .auto-style12 {
            width: 674px;
        }
        .auto-style13 {
            height: 26px;
            text-align: center;
        }
        .auto-style14 {
            width: 448px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="4">
                    <asp:Label ID="Label1" runat="server" Text="Login Form"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Text="User ID :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtID" runat="server" Width="312px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="312px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style13" colspan="2">
                    <asp:RadioButtonList ID="radioList" runat="server" Width="436px">
                        <asp:ListItem Selected="True" Value="radioStudent">Student</asp:ListItem>
                        <asp:ListItem Value="radioTeacher">Teacher</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style11"></td>
            </tr>
        </table>
        <div>
        </div>
        <div class="auto-style2">
            <asp:Button ID="btnLogin" runat="server" Height="42px" OnClick="btnLogin_Click" Text="Login" Width="128px" />
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style13" colspan="2">
                    <asp:Label ID="lblFamily" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
