<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMantenimientoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmMantenimientoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrMantenimientoForm.ascx" TagPrefix="uc1" TagName="ctrMantenimientoForm" %>

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
            <uc1:ctrMantenimientoForm runat="server" id="ctrMantenimientoForm" />
        </div>
    </form>
</body>
</html>
