<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDocumentoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDocumentoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDocumentoForm.ascx" TagPrefix="uc1" TagName="ctrDocumentoForm" %>
<%@ Register Src="~/SAFcore/Controles/ctrDetalleDocumentoList.ascx" TagPrefix="uc1" TagName="ctrDetalleDocumentoList" %>


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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="Documento"></dx:ASPxLabel>
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
        <uc1:ctrDocumentoForm runat="server" ID="ctrDocumentoForm" />
        <uc1:ctrDetalleDocumentoList runat="server" ID="ctrDetalleDocumentoList" />
    </form>
</body>
</html>
