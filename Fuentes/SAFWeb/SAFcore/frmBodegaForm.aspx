<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBodegaForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmBodegaForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrBodegaForm.ascx" TagPrefix="uc1" TagName="ctrBodegaForm" %>

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
            <uc1:ctrBodegaForm runat="server" id="ctrBodegaForm" />
        </div>
    </form>
</body>
</html>
