<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleCorteForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleCorteForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleCorteForm.ascx" TagPrefix="uc1" TagName="ctrDetalleCorteForm" %>

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
            <uc1:ctrDetalleCorteForm runat="server" id="ctrDetalleCorteForm" />
        </div>
    </form>
</body>
</html>
