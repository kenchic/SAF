<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVentaList.aspx.cs" Inherits="SAFWeb.SAFcore.frmVentaList" %>

<%@ Register Src="~/SAFcore/Controles/ctrVentaList.ascx" TagPrefix="uc1" TagName="ctrVentaList" %>

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
            <uc1:ctrVentaList runat="server" id="ctrVentaList" />
        </div>
    </form>
</body>
</html>
