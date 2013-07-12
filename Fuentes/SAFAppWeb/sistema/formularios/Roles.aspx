<%@ Page Title="" Language="C#" MasterPageFile="~/sistema/formularios/Formularios.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="SAFAppWeb.sistema.formularios.Roles" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
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
    <telerik:RadGrid ID="rgRoles" runat="server" AllowAutomaticDeletes="True"
    AllowAutomaticInserts="True" AllowPaging="True" AllowSorting="True" CellSpacing="0"
    Culture="es-ES" DataSourceID="odsRoles" GridLines="None" AllowAutomaticUpdates="True"
    AllowCustomPaging="True" Width="490px" 
    ongridexporting="rgRoles_GridExporting" 
    onitemcommand="rgRoles_ItemCommand" onitemcreated="rgRoles_ItemCreated" 
    onitemdatabound="rgRoles_ItemDataBound" onprerender="rgRoles_PreRender">
    <PagerStyle Visible="true" Mode="NextPrevAndNumeric" AlwaysVisible="True" />
    <ExportSettings ExportOnlyData="True" FileName="HSESP_Fuentes" HideStructureColumns="True"
        IgnorePaging="True" OpenInNewWindow="True">
    </ExportSettings>
    <MasterTableView AutoGenerateColumns="False" CommandItemDisplay="Top" 
        DataSourceID="odsRoles" EditMode="InPlace" Width="490px" 
        OverrideDataSourceControlSorting="True" DataKeyNames="Id">
        <CommandItemSettings ExportToPdfText="Export to PDF" ShowExportToExcelButton="True">
        </CommandItemSettings>
        <%--Encabezado manual--%>
        <CommandItemTemplate>
            <div style="padding: 5px 5px; float: left; text-align: left;">
                <asp:LinkButton ID="btnAdd" runat="server" CommandName="InitInsert" ToolTip=" Agregar Nuevo Registro">
                    <img style="border:0;vertical-align:middle;" alt="" src='<%=ResolveUrl("~/img/iconos/agregar.gif") %>' />&nbsp;&nbsp; Agregar &nbsp;&nbsp;
                </asp:LinkButton>|
                <asp:CheckBox ID="ckbActivarFiltro" runat="server" OnCheckedChanged="ckbActivarFiltro_CheckedChanged"
                    Text=" Activar Filtro" ToolTip=" Activar filtro de Busqueda" AutoPostBack="true"/>
            </div>
            <div style="padding: 6px 6px; float: right; text-align: right;">
                <asp:LinkButton ID="LinkButton2" runat="server" CommandName="RebindGrid" ToolTip=" Actualizar Tabla" >
                    <img style="border:0;vertical-align:middle;" alt="" src='<%=ResolveUrl("~/img/iconos/refrescar.gif") %>' />&nbsp;&nbsp; Actualizar&nbsp;&nbsp;
                </asp:LinkButton>|&nbsp;&nbsp;
                <asp:Button ID="btnExpXLS" runat="server" Text="" CssClass="rgExpXLS" CommandName="ExportToExcel" ToolTip=" Exportar a Excel" />
            </div>
        </CommandItemTemplate>
        <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
            <HeaderStyle Width="20px"></HeaderStyle>
        </RowIndicatorColumn>
        <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
            <HeaderStyle Width="20px"></HeaderStyle>
        </ExpandCollapseColumn>
        <Columns>
            <telerik:GridBoundColumn DataField="Nombre" 
                FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
                SortExpression="Nombre" UniqueName="Nombre">
            </telerik:GridBoundColumn>
            <telerik:GridCheckBoxColumn DataField="Activo" DataType="System.Boolean" FilterControlAltText="Filter Activo column"
                HeaderText="Activo" SortExpression="Activo" UniqueName="Activo" 
                DefaultInsertValue="True">
            </telerik:GridCheckBoxColumn>
            <telerik:GridTemplateColumn DataField="Activo" FilterControlAltText="Filter ActivoExportar column"
                HeaderText="Activo" SortExpression="Activo" UniqueName="ActivoExportar" Visible="False">
                <ItemTemplate>
                    <asp:Label ID="lblActivoExp" runat="server" Text='<%# Eval("Activo") %>'></asp:Label>
                </ItemTemplate>
            </telerik:GridTemplateColumn>
            <telerik:GridEditCommandColumn FilterControlAltText="Filter Editar column" UniqueName="Editar"
                ButtonType="ImageButton">
            </telerik:GridEditCommandColumn>
            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" ConfirmDialogType="RadWindow"
                ConfirmText="¿Eliminar el registro?" ConfirmTitle="Eliminar" FilterControlAltText="Filter DeleteColumn column"
                Text="Eliminar" UniqueName="DeleteColumn">
            </telerik:GridButtonColumn>
        </Columns>
        <EditFormSettings>
            <EditColumn FilterControlAltText="Filter EditCommandColumn column" ButtonType="ImageButton">
            </EditColumn>
        </EditFormSettings>
        <PagerStyle AlwaysVisible="True" />
    </MasterTableView>
    <HeaderStyle HorizontalAlign="Center" />
    <FilterMenu EnableImageSprites="False">
    </FilterMenu>
    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Web20">
    </HeaderContextMenu>
</telerik:RadGrid>
<asp:ObjectDataSource ID="odsRoles" runat="server" SelectMethod="ConsultarRoles"
    TypeName="Seguridad.DALC.clsFachadaClaseBase" ondeleted="odsRoles_Deleted" 
    oninserted="odsRoles_Inserted" 
    onobjectcreating="odsRoles_ObjectCreating" 
    onupdated="odsRoles_Updated" DataObjectTypeName="Seguridad.clsRol" DeleteMethod="EliminarRol" InsertMethod="InsertarRol" UpdateMethod="EditarRol">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="activo" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>
<telerik:RadWindowManager ID="rwmManagerPopUp" runat="server">
</telerik:RadWindowManager>
<telerik:RadAjaxLoadingPanel ID="rlpRoles" runat="server" Skin="Default" Width="256px">
    <img alt="" src="../../img/iconos/cargando.gif" />
</telerik:RadAjaxLoadingPanel>
<telerik:RadAjaxManagerProxy ID="RadAjaxManagerProxy1" runat="server">
    <ajaxsettings>
        <telerik:AjaxSetting AjaxControlID="rgRoles">
            <updatedcontrols>
                <telerik:AjaxUpdatedControl ControlID="rgRoles" LoadingPanelID="rlpRoles" />
                <telerik:AjaxUpdatedControl ControlID="rwmManagerPopUp" />
            </updatedcontrols>
        </telerik:AjaxSetting>
        <telerik:AjaxSetting AjaxControlID="rwmManagerPopUp">
            <updatedcontrols>
                <telerik:AjaxUpdatedControl ControlID="rgRoles" LoadingPanelID="rlpRoles" />
                <telerik:AjaxUpdatedControl ControlID="rwmManagerPopUp" />
            </updatedcontrols>
        </telerik:AjaxSetting>
    </ajaxsettings>
</telerik:RadAjaxManagerProxy>
</asp:Content>
