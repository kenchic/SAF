<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleDevolucionServicioList.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleDevolucionServicioList" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleDevolucionServicioList.ascx" TagPrefix="uc1" TagName="ctrDetalleDevolucionServicioList" %>

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
            <uc1:ctrDetalleDevolucionServicioList runat="server" id="ctrDetalleDevolucionServicioList" />
        </div>
    </form>
</body>
</html>
