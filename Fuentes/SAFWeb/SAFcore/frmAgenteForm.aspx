<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAgenteForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmAgenteForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrAgenteForm.ascx" TagPrefix="uc1" TagName="ctrAgenteForm" %>

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
            <uc1:ctrAgenteForm runat="server" id="ctrAgenteForm" />
        </div>
    </form>
</body>
</html>
