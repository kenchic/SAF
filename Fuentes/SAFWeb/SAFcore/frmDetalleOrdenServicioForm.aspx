<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleOrdenServicioForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleOrdenServicioForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleOrdenServicioForm.ascx" TagPrefix="uc1" TagName="ctrDetalleOrdenServicioForm" %>

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
            <uc1:ctrDetalleOrdenServicioForm runat="server" id="ctrDetalleOrdenServicioForm" />
        </div>
    </form>
</body>
</html>
