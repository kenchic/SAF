<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDevolucionForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmDevolucionForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrDevolucionForm.ascx" TagPrefix="uc1" TagName="ctrDevolucionForm" %>

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
            <uc1:ctrDevolucionForm runat="server" id="ctrDevolucionForm" />
        </div>
    </form>
</body>
</html>
