<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleRemisionForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleRemisionForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleRemisionForm.ascx" TagPrefix="uc1" TagName="ctrDetalleRemisionForm" %>

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
            <uc1:ctrDetalleRemisionForm runat="server" id="ctrDetalleRemisionForm" />
        </div>
    </form>
</body>
</html>
