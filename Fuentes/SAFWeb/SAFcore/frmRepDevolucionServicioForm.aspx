<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRepDevolucionServicioForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmRepDevolucionServicioForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrRepDevolucionServicioForm.ascx" TagPrefix="uc1" TagName="ctrRepDevolucionServicioForm" %>

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
            <uc1:ctrRepDevolucionServicioForm runat="server" id="ctrRepDevolucionServicioForm" />
        </div>
    </form>
</body>
</html>
