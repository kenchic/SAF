<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleMantenimientoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleMantenimientoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleMantenimientoForm.ascx" TagPrefix="uc1" TagName="ctrDetalleMantenimientoForm" %>

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
            <uc1:ctrDetalleMantenimientoForm runat="server" id="ctrDetalleMantenimientoForm" />
        </div>
    </form>
</body>
</html>
