<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmOrdenServicioForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmOrdenServicioForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrOrdenServicioForm.ascx" TagPrefix="uc1" TagName="ctrOrdenServicioForm" %>

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
            <uc1:ctrOrdenServicioForm runat="server" id="ctrOrdenServicioForm" />
        </div>
    </form>
</body>
</html>
