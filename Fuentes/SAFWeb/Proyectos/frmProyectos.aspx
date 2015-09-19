<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProyectos.aspx.cs" Inherits="SAFWeb.Proyectos.frmProyectos" %>

<%@ Register Src="Controles/ctrProyectoList.ascx" TagName="ctrProyectoList" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Proyectos
        <uc1:ctrProyectoList ID="ctrProyectoList1" runat="server" />
        </div>
    </form>
</body>
</html>
