<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleFacturaForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleFacturaForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleFacturaForm.ascx" TagPrefix="uc1" TagName="ctrDetalleFacturaForm" %>

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
            <uc1:ctrDetalleFacturaForm runat="server" id="ctrDetalleFacturaForm" />
        </div>
    </form>
</body>
</html>
