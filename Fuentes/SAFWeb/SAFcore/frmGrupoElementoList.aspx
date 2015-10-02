<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGrupoElementoList.aspx.cs" Inherits="SAFWeb.SAFcore.frmGrupoElementoList" %>

<%@ Register Src="~/SAFcore/Controles/ctrGrupoElementoList.ascx" TagPrefix="uc1" TagName="ctrGrupoElementoList" %>

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
            <uc1:ctrGrupoElementoList runat="server" id="ctrGrupoElementoList" />
        </div>
    </form>
</body>
</html>
