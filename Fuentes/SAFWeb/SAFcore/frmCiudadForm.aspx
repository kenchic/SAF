<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCiudadForm.aspx.cs" Inherits="SAFWeb.SAFcore.frmCiudadForm" %>

<%@ Register Src="~/SAFcore/Controles/ctrCiudadForm.ascx" TagPrefix="uc1" TagName="ctrCiudadForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/EstilosApp.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:ctrCiudadForm runat="server" ID="ctrCiudadForm" />
    </div>
    </form>
</body>
</html>
