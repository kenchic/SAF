<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleListaPrecioForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleListaPrecioForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleListaPrecioForm.ascx" TagPrefix="uc1" TagName="ctrDetalleListaPrecioForm" %>

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
            <uc1:ctrDetalleListaPrecioForm runat="server" id="ctrDetalleListaPrecioForm" />
        </div>
    </form>
</body>
</html>
