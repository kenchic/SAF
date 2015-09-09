<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEncabezado.aspx.cs" Inherits="SAFWeb.Sistema.Controles.frmEncabezado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    
        <dx:ASPxMenu ID="ASPxMenu1" runat="server" Target="contenidoCentral">
            <Items>
                <dx:MenuItem Name="Administracion" NavigateUrl="~/Sistema/frmMenuIzq.aspx" Text="Administración">
                </dx:MenuItem>
            </Items>
        </dx:ASPxMenu>
    
    
    </div>
    </form>
</body>
</html>
