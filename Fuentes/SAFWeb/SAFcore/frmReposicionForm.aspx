<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmReposicionForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmReposicionForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrReposicionForm.ascx" TagPrefix="uc1" TagName="ctrReposicionForm" %>

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
            <uc1:ctrReposicionForm runat="server" id="ctrReposicionForm" />
        </div>
    </form>
</body>
</html>
