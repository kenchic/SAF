<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleRepDevolucionServicioForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleRepDevolucionServicioForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleRepDevolucionServicioForm.ascx" TagPrefix="uc1" TagName="ctrDetalleRepDevolucionServicioForm" %>

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
            <uc1:ctrDetalleRepDevolucionServicioForm runat="server" id="ctrDetalleRepDevolucionServicioForm" />
        </div>
    </form>
</body>
</html>
