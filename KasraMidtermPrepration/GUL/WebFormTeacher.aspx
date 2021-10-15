<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTeacher.aspx.cs" Inherits="KasraMidtermPrepration.GUL.WebFormTeacher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 322px;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;
            <asp:Label ID="lblSelectStudent" runat="server" Font-Bold="True" Text="Select Teacher"></asp:Label>
            <asp:Label ID="lblSelectProject" runat="server" Font-Bold="True" Text="Select  Course"></asp:Label>
            &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:DropDownList ID="dpdSelectStudent" runat="server" Height="26px" Width="256px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="dpdSelectProject" runat="server" CssClass="auto-style2" Height="26px" Width="256px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnAssignProject" runat="server" OnClick="btnAssignProject_Click" Text="Assign Course" />
                    </td>
                    <td>
                        <asp:Button ID="btnAllCourses" runat="server" OnClick="btnAllCourses_Click" Text="All Courses" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;Select the Assigned Date </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Calendar ID="CalendarAssignedDate" runat="server" Width="664px"></asp:Calendar>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:GridView ID="GridViewListInfo" runat="server" Width="669px">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
