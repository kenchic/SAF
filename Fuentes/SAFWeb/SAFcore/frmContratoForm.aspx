<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmContratoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmContratoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrContratoForm.ascx" TagPrefix="uc1" TagName="ctrContratoForm" %>

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
            <uc1:ctrContratoForm runat="server" id="ctrContratoForm" />
        </div>
    </form>
</body>
</html>
