<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmElementoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmElementoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrElementoForm.ascx" TagPrefix="uc1" TagName="ctrElementoForm" %>

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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="Elemento"></dx:ASPxLabel>
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
        <uc1:ctrElementoForm runat="server" ID="ctrElementoForm" />
    </form>
</body>
</html>
