<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmElementoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmElementoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrElementoForm.ascx" TagPrefix="uc1" TagName="ctrElementoForm" %>

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
            <uc1:ctrElementoForm runat="server" id="ctrElementoForm" />
        </div>
    </form>
</body>
</html>
