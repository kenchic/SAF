<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRepDevolucionServicioForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmRepDevolucionServicioForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrRepDevolucionServicioForm.ascx" TagPrefix="uc1" TagName="ctrRepDevolucionServicioForm" %>

<!DOCTYPE html>
<link href="../css/EstilosApp.css" rel="stylesheet" />
<script src="../js/Funciones.js"></script>
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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="RepDevolucionServicio"></dx:ASPxLabel>
                    </td>
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr class="filaEncabezado">
                    <td>
					<dx:ASPxButton ID="btGuardar" runat="server" Text="Guardar" Width="100" OnClick="btGuardar_Click" />

					</td>
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <uc1:ctrRepDevolucionServicioForm runat="server" id="ctrRepDevolucionServicioForm" />        
    </form>
</body>
</html>
