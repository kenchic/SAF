<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVentaForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmVentaForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrVentaForm.ascx" TagPrefix="uc1" TagName="ctrVentaForm" %>

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
            <uc1:ctrVentaForm runat="server" id="ctrVentaForm" />
        </div>
    </form>
</body>
</html>
