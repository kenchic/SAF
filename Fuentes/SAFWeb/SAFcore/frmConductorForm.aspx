<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConductorForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmConductorForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrConductorForm.ascx" TagPrefix="uc1" TagName="ctrConductorForm" %>

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
            <uc1:ctrConductorForm runat="server" id="ctrConductorForm" />
        </div>
    </form>
</body>
</html>
