<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFacturaForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmFacturaForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrFacturaForm.ascx" TagPrefix="uc1" TagName="ctrFacturaForm" %>

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
            <uc1:ctrFacturaForm runat="server" id="ctrFacturaForm" />
        </div>
    </form>
</body>
</html>
