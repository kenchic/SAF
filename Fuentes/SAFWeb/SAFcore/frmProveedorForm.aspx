<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProveedorForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmProveedorForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrProveedorForm.ascx" TagPrefix="uc1" TagName="ctrProveedorForm" %>

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
            <uc1:ctrProveedorForm runat="server" id="ctrProveedorForm" />
        </div>
    </form>
</body>
</html>
