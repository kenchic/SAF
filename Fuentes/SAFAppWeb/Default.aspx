<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SAFAppWeb.Default" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/EstilosLogin.css" type="text/css" media="screen" />
    <title>SAF. Sistema de Alquiler de Formaleta</title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManagerGeneral" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
            </Scripts>
        </telerik:RadScriptManager>
        <div>
            <div style="height: 150px"></div>
            <div style="float: left; width: 33%"></div>
            <div style="float: left; width: 33%;">
                <table class="tableInicio">
                    <thead>
                        <tr>
                            <td style="text-align: center">Inicio de Sesion</td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <asp:Login ID="InicioSesion" runat="server" OnAuthenticate="InicioSesion_Authenticate">
                                    <LayoutTemplate>
                                        <table>
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuario:</asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Clave:</asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:CheckBox ID="RememberMe" runat="server" Text="Recuerdame." />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" style="color: Red;">
                                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Iniciar" ValidationGroup="Login1" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </LayoutTemplate>
                                </asp:Login>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div style="float: right; width: 33%"></div>
        </div>
        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" />
    </form>
</body>
</html>
