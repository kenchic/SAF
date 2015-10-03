<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMantenimientoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmMantenimientoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrMantenimientoForm.ascx" TagPrefix="uc1" TagName="ctrMantenimientoForm" %>

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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="Mantenimiento"></dx:ASPxLabel>
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
        <uc1:ctrMantenimientoForm runat="server" id="ctrMantenimientoForm" />        
    </form>
</body>
</html>
