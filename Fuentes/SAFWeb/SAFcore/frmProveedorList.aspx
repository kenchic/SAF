<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProveedorList.aspx.cs" Inherits="SAFWeb.SAFcore.frmProveedorList" %>

<%@ Register Src="~/SAFcore/Controles/ctrProveedorList.ascx" TagPrefix="uc1" TagName="ctrProveedorList" %>

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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="Proveedor"></dx:ASPxLabel>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr class="filaEncabezado">
                    <td>
						<dx:ASPxButton ID="btCrear" runat="server" Text= "Nuevo" OnClick="btCrear_Click"></dx:ASPxButton>

					</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <uc1:ctrProveedorList runat="server" id="ctrProveedorList" />        
    </form>
</body>
</html>
