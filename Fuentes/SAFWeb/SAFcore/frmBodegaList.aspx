<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBodegaList.aspx.cs" Inherits="SAFWeb.SAFcore.frmBodegaList" %>

<%@ Register Src="~/SAFcore/Controles/ctrBodegaList.ascx" TagPrefix="uc1" TagName="ctrBodegaList" %>

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
                <tr>
                    <td class="filaEncabezado">
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="Bodega"></dx:ASPxLabel>
                    </td>
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="filaEncabezado">
                        <dx:ASPxButton ID="btCrear" runat="server" Text="Nuevo" OnClick="btCrear_Click"></dx:ASPxButton>
                    </td>
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td>
                        <dx:ASPxTextBox ID="txtBuscar" runat="server" Width="300px"></dx:ASPxTextBox>
                    </td>
                </tr>
            </table>
        </div>
        <uc1:ctrBodegaList runat="server" ID="ctrBodegaList" />
    </form>
</body>
</html>
