<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleVentaForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleVentaForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleVentaForm.ascx" TagPrefix="uc1" TagName="ctrDetalleVentaForm" %>

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
            <uc1:ctrDetalleVentaForm runat="server" id="ctrDetalleVentaForm" />
        </div>
    </form>
</body>
</html>
