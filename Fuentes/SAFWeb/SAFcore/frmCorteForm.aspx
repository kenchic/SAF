<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCorteForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmCorteForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrCorteForm.ascx" TagPrefix="uc1" TagName="ctrCorteForm" %>

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
            <uc1:ctrCorteForm runat="server" id="ctrCorteForm" />
        </div>
    </form>
</body>
</html>
