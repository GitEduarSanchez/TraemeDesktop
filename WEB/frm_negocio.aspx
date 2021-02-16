<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_negocio.aspx.vb" Inherits="WEB.frm_negocio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1267px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 633px;
        }
        .auto-style4 {
            width: 107px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2">REGISTRO DE NEGOCIO</td>
            </tr>
            <tr>
                <td class="auto-style4">RAZON SOCIAL</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_razon" runat="server" Width="241px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">NIT</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_nit" runat="server" Width="242px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">CIUDAD</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_ciudad" runat="server" Width="241px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Guardar" style="width: 68px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:DropDownList ID="DropDownList1" runat="server">

                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
