<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUnidadMedidaForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmUnidadMedidaForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrUnidadMedidaForm.ascx" TagPrefix="uc1" TagName="ctrUnidadMedidaForm" %>

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
            <uc1:ctrUnidadMedidaForm runat="server" id="ctrUnidadMedidaForm" />
        </div>
    </form>
</body>
</html>
