<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmListaPrecioForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmListaPrecioForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrListaPrecioForm.ascx" TagPrefix="uc1" TagName="ctrListaPrecioForm" %>

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
            <uc1:ctrListaPrecioForm runat="server" id="ctrListaPrecioForm" />
        </div>
    </form>
</body>
</html>
