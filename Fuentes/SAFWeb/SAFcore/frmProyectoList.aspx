<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProyectoList.aspx.cs" Inherits="SAFWeb.SAFcore.frmProyectoList" %>

<%@ Register Src="~/SAFcore/Controles/ctrProyectoList.ascx" TagPrefix="uc1" TagName="ctrProyectoList" %>

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
            <uc1:ctrProyectoList runat="server" id="ctrProyectoList" />
        </div>
    </form>
</body>
</html>
