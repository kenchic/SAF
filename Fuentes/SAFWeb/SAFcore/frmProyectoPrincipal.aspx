<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProyectoPrincipal.aspx.cs" Inherits="SAFWeb.SAFcore.frmProyectoPrincipal" %>

<!DOCTYPE html>
<link href="../css/EstilosApp.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="botonesList">
            <table style="width: 100%">
                <tr class="filaEncabezado">
                    <td>
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="Proyecto"></dx:ASPxLabel>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr class="filaEncabezado">
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>


        <div class="layoutForm">
            <table style="width: 100%">
                <tr class="filaEncabezado">
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <img src="../img/iconos/Datos.png" style="height: 100px; width: 120px" /></td>
                    <td>
                        <img src="../img/iconos/Contrato.png" style="height: 100px; width: 120px" /></td>
                    <td>
                        <img src="../img/iconos/Movimientos.png" style="height: 100px; width: 120px" /></td>
                    <td>
                        <img src="../img/iconos/Facturar.png" style="height: 100px; width: 120px" /></td>
                </tr>
                <tr>
                    <td>
                        <dx:ASPxHyperLink ID="hlInfoProyecto" runat="server" Text="Información Proyecto" NavigateUrl="frmProyectoForm.aspx">
                        </dx:ASPxHyperLink>
                    </td>
                    <td>
                        <dx:ASPxHyperLink ID="hlInfoContrato" runat="server" Text="Información Contrato">
                        </dx:ASPxHyperLink>
                    </td>
                    <td>
                        <dx:ASPxHyperLink ID="hlInfoMovimientos" runat="server" Text="Movimientos Plantilla">
                        </dx:ASPxHyperLink>
                    </td>
                    <td>
                        <dx:ASPxHyperLink ID="hlInfoFacturas" runat="server" Text="Facturas">
                        </dx:ASPxHyperLink>
                    </td>
                </tr>
            </table>
        </div>

    </form>
</body>
</html>
