<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProyectoPrincipal.aspx.cs" Inherits="SAFWeb.SAFcore.frmProyectoPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <dx:ASPxHyperLink ID="hlInfoProyecto" runat="server" Text="Información Proyecto" NavigateUrl="frmProyectoForm.aspx">
                        </dx:ASPxHyperLink>
                    </td>
                    <td>Información Contrato</td>
                    <td>Movimientos Plantilla</td>
                    <td>Facturas</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
