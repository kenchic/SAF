<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCiudadForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmCiudadForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrCiudadForm.ascx" TagPrefix="uc1" TagName="ctrCiudadForm" %>

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
            <uc1:ctrCiudadForm runat="server" id="ctrCiudadForm" />
        </div>
    </form>
</body>
</html>
