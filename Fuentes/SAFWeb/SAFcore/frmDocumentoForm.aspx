<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDocumentoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDocumentoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDocumentoForm.ascx" TagPrefix="uc1" TagName="ctrDocumentoForm" %>

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
            <uc1:ctrDocumentoForm runat="server" id="ctrDocumentoForm" />
        </div>
    </form>
</body>
</html>
