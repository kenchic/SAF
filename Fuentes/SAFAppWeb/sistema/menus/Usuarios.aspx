<%@ Page Title="" Language="C#" MasterPageFile="~/sistema/menus/Menus.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="SAFAppWeb.sistema.menus.Usuarios" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI, Version=2012.3.1205.45, Culture=neutral, PublicKeyToken=121fae78165ba3d4" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js">
            </asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <telerik:RadPanelBar runat="server" ID="RadPanelBar1">
        <Items>
            <telerik:RadPanelItem Text="Mail" Expanded="True">
                <Items>
                    <telerik:RadPanelItem Text="Personal Folders" />
                    <telerik:RadPanelItem Text="Deleted Items" />
                    <telerik:RadPanelItem Text="Inbox" />
                    <telerik:RadPanelItem Text="My Mail" />
                    <telerik:RadPanelItem Text="Sent Items" />
                    <telerik:RadPanelItem Text="Outbox" />
                    <telerik:RadPanelItem Text="Search Folders" />
                </Items>
            </telerik:RadPanelItem>
            <telerik:RadPanelItem Text="Contacts">
                <Items>
                    <telerik:RadPanelItem Text="My Contacts" />
                    <telerik:RadPanelItem Text="Address Cards" />
                    <telerik:RadPanelItem Text="Phone List" />
                    <telerik:RadPanelItem Text="Shared Contacts" />
                </Items>
            </telerik:RadPanelItem>
            <telerik:RadPanelItem Text="Tasks">
                <Items>
                    <telerik:RadPanelItem Text="My Tasks" />
                    <telerik:RadPanelItem Text="Shared Tasks" />
                    <telerik:RadPanelItem Text="Active Tasks" />
                    <telerik:RadPanelItem Text="Completed Tasks" />
                </Items>
            </telerik:RadPanelItem>
            <telerik:RadPanelItem Text="Notes">
                <Items>
                    <telerik:RadPanelItem Text="My Notes" />
                    <telerik:RadPanelItem Text="Notes List" />
                    <telerik:RadPanelItem Text="Shared Notes" />
                    <telerik:RadPanelItem Text="Archive" />
                </Items>
            </telerik:RadPanelItem>
            <telerik:RadPanelItem Text="Folders List">
                <Items>
                    <telerik:RadPanelItem Text="My Client.Net" />
                    <telerik:RadPanelItem Text="My Profile" />
                    <telerik:RadPanelItem Text="My Support Tickets" />
                    <telerik:RadPanelItem Text="My Licenses" />
                </Items>
            </telerik:RadPanelItem>
        </Items>
        <ExpandAnimation Type="None" />
        <CollapseAnimation Type="None" />
    </telerik:RadPanelBar>
</asp:Content>
