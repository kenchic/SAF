<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBodegaForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmBodegaForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrBodegaForm.ascx" TagPrefix="uc1" TagName="ctrBodegaForm" %>

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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="Bodega"></dx:ASPxLabel>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr class="filaEncabezado">
                    <td>
                        <dx:ASPxButton ID="btGuardar" runat="server" Text="Guardar" Width="100" OnClick="btGuardar_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <uc1:ctrBodegaForm runat="server" ID="ctrBodegaForm" />
    </form>
</body>
</html>
