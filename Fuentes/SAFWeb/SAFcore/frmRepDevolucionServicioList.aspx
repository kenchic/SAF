<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRepDevolucionServicioList.aspx.cs" Inherits="SAFWeb.SAFcore.frmRepDevolucionServicioList" %>

<%@ Register Src="~/SAFcore/Controles/ctrRepDevolucionServicioList.ascx" TagPrefix="uc1" TagName="ctrRepDevolucionServicioList" %>

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
            <uc1:ctrRepDevolucionServicioList runat="server" id="ctrRepDevolucionServicioList" />
        </div>
    </form>
</body>
</html>
