<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDetalleReposicionForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDetalleReposicionForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDetalleReposicionForm.ascx" TagPrefix="uc1" TagName="ctrDetalleReposicionForm" %>

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
            <uc1:ctrDetalleReposicionForm runat="server" id="ctrDetalleReposicionForm" />
        </div>
    </form>
</body>
</html>
