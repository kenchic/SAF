<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleDocumentoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleDocumentoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleDocumentoForm.ascx" TagPrefix="uc1" TagName="ctrDetalleDocumentoForm" %>

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
            <uc1:ctrDetalleDocumentoForm runat="server" id="ctrDetalleDocumentoForm" />
        </div>
    </form>
</body>
</html>
