<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUnidadMedidaList.aspx.cs" Inherits="SAFWeb.SAFcore.frmUnidadMedidaList" %>

<%@ Register Src="~/SAFcore/Controles/ctrUnidadMedidaList.ascx" TagPrefix="uc1" TagName="ctrUnidadMedidaList" %>

<!DOCTYPE html>
<link href="../css/EstilosApp.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
		<div>
            <div class="botonesList">
                <div class="tablaFilaEnc">
                </div>
                <div>
                    <dx:ASPxButton ID="btCrear" runat="server" Text= "Nuevo" OnClick="btCrear_Click"></dx:ASPxButton>

                </div>
                <div class="tablaFilaPie">
                </div>
            </div>
            <uc1:ctrUnidadMedidaList runat="server" id="ctrUnidadMedidaList" />
        </div>
    </form>
</body>
</html>
