<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProyectoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmProyectoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrProyectoForm.ascx" TagPrefix="uc1" TagName="ctrProyectoForm" %>

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
            <uc1:ctrProyectoForm runat="server" id="ctrProyectoForm" />
        </div>
    </form>
</body>
</html>
