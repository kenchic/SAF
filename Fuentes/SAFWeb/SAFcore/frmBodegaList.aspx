<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBodegaList.aspx.cs" Inherits="SAFWeb.SAFcore.frmBodegaList" %>

<%@ Register Src="~/SAFcore/Controles/ctrBodegaList.ascx" TagPrefix="uc1" TagName="ctrBodegaList" %>

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
            <uc1:ctrBodegaList runat="server" id="ctrBodegaList" />
        </div>
    </form>
</body>
</html>
