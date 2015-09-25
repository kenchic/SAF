<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProyectoList.aspx.cs" Inherits="SAFWeb.SAFcore.frmProyectoList" %>

<%@ Register src="Controles/ctrProyectoList.ascx" tagname="ctrProyectoList" tagprefix="uc1" %>

<!DOCTYPE html>
<link href="../css/EstilosApp.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxButton ID="btCrear" runat="server" Text="Nuevo" OnClick="btCrear_Click"></dx:ASPxButton>
        <uc1:ctrProyectoList ID="ctrProyectoList1" runat="server" />
    
    </div>
    </form>
</body>
</html>
