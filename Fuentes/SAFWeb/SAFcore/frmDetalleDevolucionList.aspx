<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleDevolucionList.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleDevolucionList" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleDevolucionList.ascx" TagPrefix="uc1" TagName="ctrDetalleDevolucionList" %>

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
            <uc1:ctrDetalleDevolucionList runat="server" id="ctrDetalleDevolucionList" />
        </div>
    </form>
</body>
</html>
