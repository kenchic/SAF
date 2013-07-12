<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SAFAppWeb.sistema.Default" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SAF. Sistema de Alquiler de Formaleta</title>
    <link rel="stylesheet" href="../css/EstilosApp.css" type="text/css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="encabezado">
            <telerik:RadMenu ID="RadMenu1" runat="server">
                <Items>
                    <telerik:RadMenuItem runat="server" Text="Inicio" Target="rpMenuIzquierdo" NavigateUrl="menus/Bienvenido.aspx">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Usuarios" Target="rpMenuIzquierdo" NavigateUrl="menus/Administracion.aspx">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Root RadMenuItem3">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Root RadMenuItem4">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Root RadMenuItem5">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Root RadMenuItem6">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Root RadMenuItem7">
                    </telerik:RadMenuItem>
                </Items>
            </telerik:RadMenu>
        </div>
        <div id="contenido">
            <telerik:RadSplitter ID="rsContenido" runat="server" Width="100%" Height="100%">
                <telerik:RadPane ID="rpMenuIzquierdo" runat="server" Width="19%" ContentUrl="menus/Bienvenido.aspx">
                </telerik:RadPane>
                <telerik:RadSplitBar ID="Radsplitbar6" runat="server" CollapseMode="Forward">
                </telerik:RadSplitBar>
                <telerik:RadPane ID="rpFormulario" runat="server" ContentUrl="formularios/Bienvenido.aspx">
                </telerik:RadPane>
            </telerik:RadSplitter>
        </div>
        <div id="pie">
            <telerik:RadAjaxManager ID="RadAjaxManagerGeneral" runat="server">
                <AjaxSettings>
                    <telerik:AjaxSetting AjaxControlID="RadMenu1">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="RadMenu1" />
                            <telerik:AjaxUpdatedControl ControlID="rpMenuIzquierdo" LoadingPanelID="RadAjaxLoadingPanelGeneral" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                </AjaxSettings>
            </telerik:RadAjaxManager>
            <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanelGeneral" Runat="server" Skin="Default">
                <asp:Label ID="lbProcesar" runat="server" ForeColor="Red" Style="color: #000000">Procesando... </asp:Label>
                <br />
                <img src="../img/iconos/cargando.gif" alt=""/>
            </telerik:RadAjaxLoadingPanel>
            <telerik:RadScriptManager ID="RadScriptManagerGeneral" runat="server">
                <Scripts>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
                </Scripts>
            </telerik:RadScriptManager>
        </div>
    </form>
</body>
</html>
