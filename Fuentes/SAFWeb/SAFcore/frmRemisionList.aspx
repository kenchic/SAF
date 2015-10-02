<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRemisionList.aspx.cs" Inherits="SAFWeb.SAFcore.frmRemisionList" %>

<%@ Register Src="~/SAFcore/Controles/ctrRemisionList.ascx" TagPrefix="uc1" TagName="ctrRemisionList" %>

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
                    <dx:ASPxButton ID="btCrear" runat="server" Text= "Nuevo" OnClick="btCrear_Click"></dx:ASPxButton>

                </div>
                <div class="tablaFilaPie">
                </div>
            </div>
            <uc1:ctrRemisionList runat="server" id="ctrRemisionList" />
        </div>
    </form>
</body>
</html>
