<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDevolucionServicioForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDevolucionServicioForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDevolucionServicioForm.ascx" TagPrefix="uc1" TagName="ctrDevolucionServicioForm" %>

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
            <uc1:ctrDevolucionServicioForm runat="server" id="ctrDevolucionServicioForm" />
        </div>
    </form>
</body>
</html>
