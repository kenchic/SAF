<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDocumentoList.aspx.cs" Inherits="SAFWeb.SAFcore.frmDocumentoList" %>

<%@ Register Src="~/SAFcore/Controles/ctrDocumentoList.ascx" TagPrefix="uc1" TagName="ctrDocumentoList" %>

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
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr class="filaEncabezado">
                    <td>
						<dx:ASPxButton ID="btCrear" runat="server" Text= "Nuevo" OnClick="btCrear_Click"></dx:ASPxButton>
					</td>
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td>
                        <dx:ASPxTextBox ID="txtBuscar" runat="server" Width="300px"></dx:ASPxTextBox>
                    </td>
                </tr>
            </table>
        </div>
        <uc1:ctrDocumentoList runat="server" id="ctrDocumentoList" />        
    </form>
</body>
</html>
