<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleDevolucionServicioForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleDevolucionServicioForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleDevolucionServicioForm.ascx" TagPrefix="uc1" TagName="ctrDetalleDevolucionServicioForm" %>

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
                    
                </div>
                <div class="tablaFilaPie">
                </div>
            </div>
            <uc1:ctrDetalleDevolucionServicioForm runat="server" id="ctrDetalleDevolucionServicioForm" />
        </div>
    </form>
</body>
</html>
