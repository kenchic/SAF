<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGrupoElementoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmGrupoElementoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrGrupoElementoForm.ascx" TagPrefix="uc1" TagName="ctrGrupoElementoForm" %>

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
            <uc1:ctrGrupoElementoForm runat="server" id="ctrGrupoElementoForm" />
        </div>
    </form>
</body>
</html>
