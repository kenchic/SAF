<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleDevolucionForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleDevolucionForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleDevolucionForm.ascx" TagPrefix="uc1" TagName="ctrDetalleDevolucionForm" %>

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
            <uc1:ctrDetalleDevolucionForm runat="server" id="ctrDetalleDevolucionForm" />
        </div>
    </form>
</body>
</html>
