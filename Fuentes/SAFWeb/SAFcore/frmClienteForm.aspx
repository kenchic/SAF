<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmClienteForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmClienteForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrClienteForm.ascx" TagPrefix="uc1" TagName="ctrClienteForm" %>

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
            <uc1:ctrClienteForm runat="server" id="ctrClienteForm" />
        </div>
    </form>
</body>
</html>
