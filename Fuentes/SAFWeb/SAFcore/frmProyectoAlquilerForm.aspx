<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProyectoAlquilerForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmProyectoAlquilerForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrProyectoAlquilerForm.ascx" TagPrefix="uc1" TagName="ctrProyectoAlquilerForm" %>

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
            <uc1:ctrProyectoAlquilerForm runat="server" id="ctrProyectoAlquilerForm" />
        </div>
    </form>
</body>
</html>
