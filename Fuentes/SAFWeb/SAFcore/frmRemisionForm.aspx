<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRemisionForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmRemisionForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrRemisionForm.ascx" TagPrefix="uc1" TagName="ctrRemisionForm" %>

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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="Remision"></dx:ASPxLabel>
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
        <uc1:ctrRemisionForm runat="server" id="ctrRemisionForm" />        
    </form>
</body>
</html>
