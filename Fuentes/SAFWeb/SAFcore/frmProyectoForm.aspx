<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProyectoForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmProyectoForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrProyectoForm.ascx" TagPrefix="uc1" TagName="ctrProyectoForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/EstilosApp.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:ctrProyectoForm runat="server" ID="ctrProyectoForm" />
    </div>
    </form>
</body>
</html>
