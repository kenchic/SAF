<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMantenimientoList.aspx.cs" Inherits="SAFWeb.SAFcore.frmMantenimientoList" %>

<%@ Register Src="~/SAFcore/Controles/ctrMantenimientoList.ascx" TagPrefix="uc1" TagName="ctrMantenimientoList" %>

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
            <uc1:ctrMantenimientoList runat="server" id="ctrMantenimientoList" />
        </div>
    </form>
</body>
</html>
