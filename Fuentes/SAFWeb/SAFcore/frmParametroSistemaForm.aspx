<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmParametroSistemaForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmParametroSistemaForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrParametroSistemaForm.ascx" TagPrefix="uc1" TagName="ctrParametroSistemaForm" %>

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
            <uc1:ctrParametroSistemaForm runat="server" id="ctrParametroSistemaForm" />
        </div>
    </form>
</body>
</html>
