<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDevolucionList.aspx.cs" Inherits="SAFWeb.SAFcore.frmDevolucionList" %>

<%@ Register Src="~/SAFcore/Controles/ctrDevolucionList.ascx" TagPrefix="uc1" TagName="ctrDevolucionList" %>

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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="Devolucion"></dx:ASPxLabel>
                    </td>
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr class="filaEncabezado">
                    <td>
					<dx:ASPxButton ID="btCrear" runat="server" Text= "Nuevo" OnClick="btCrear_Click"></dx:ASPxButton>

					</td>
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td><dx:ASPxTextBox ID="txtBuscar" runat="server" Width="300px"></dx:ASPxTextBox>
</td>
                </tr>
            </table>
        </div>
        <uc1:ctrDevolucionList runat="server" id="ctrDevolucionList" />        
    </form>
</body>
</html>
