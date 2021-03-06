<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGrupoElementoList.aspx.cs" Inherits="SAFWeb.SAFcore.frmGrupoElementoList" %>

<%@ Register Src="~/SAFcore/Controles/ctrGrupoElementoList.ascx" TagPrefix="uc1" TagName="ctrGrupoElementoList" %>

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
                        <dx:ASPxLabel ID="lbTitulo" CssClass="TituloList" runat="server" Text="GrupoElemento"></dx:ASPxLabel>
                    </td>
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr class="filaEncabezado">
                    <td>
                        <dx:ASPxButton ID="btCrear" runat="server" Text="Nuevo" OnClick="btCrear_Click"></dx:ASPxButton>

                    </td>
                    <td class="CeldaCentralEncabezado">&nbsp;</td>
                    <td>
                        <dx:ASPxTextBox ID="txtBuscar" runat="server" Width="300px"></dx:ASPxTextBox>
                    </td>
                </tr>
            </table>
        </div>
        <uc1:ctrGrupoElementoList runat="server" ID="ctrGrupoElementoList" />
    </form>
</body>
</html>
