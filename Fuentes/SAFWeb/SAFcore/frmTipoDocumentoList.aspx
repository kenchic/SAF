<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTipoDocumentoList.aspx.cs" Inherits="SAFWeb.SAFcore.frmTipoDocumentoList" %>

<%@ Register Src="~/SAFcore/Controles/ctrTipoDocumentoList.ascx" TagPrefix="uc1" TagName="ctrTipoDocumentoList" %>

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
            <uc1:ctrTipoDocumentoList runat="server" id="ctrTipoDocumentoList" />
        </div>
    </form>
</body>
</html>
