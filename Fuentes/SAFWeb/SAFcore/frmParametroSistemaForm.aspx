<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmParametroSistemaForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmParametroSistemaForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrParametroSistemaForm.ascx" TagPrefix="uc1" TagName="ctrParametroSistemaForm" %>

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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="ParametroSistema"></dx:ASPxLabel>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr class="filaEncabezado">
                    <td>
						
					</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <uc1:ctrParametroSistemaForm runat="server" id="ctrParametroSistemaForm" />        
    </form>
</body>
</html>
