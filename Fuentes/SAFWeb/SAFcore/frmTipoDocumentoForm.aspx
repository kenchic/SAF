<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTipoDocumentoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmTipoDocumentoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrTipoDocumentoForm.ascx" TagPrefix="uc1" TagName="ctrTipoDocumentoForm" %>

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
            <uc1:ctrTipoDocumentoForm runat="server" id="ctrTipoDocumentoForm" />
        </div>
    </form>
</body>
</html>
