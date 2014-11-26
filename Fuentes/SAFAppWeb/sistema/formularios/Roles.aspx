<%@ Page Title="" Language="C#" MasterPageFile="~/sistema/formularios/Formularios.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="SAFAppWeb.sistema.formularios.Datos" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <div id="encabezadoForm">
        ROLES</div>
    <div id="grillasForm">
        <telerik:RadGrid ID="rgDatos" runat="server" AllowAutomaticDeletes="True"
            AllowAutomaticInserts="True" AllowPaging="True" AllowSorting="True" CellSpacing="0" 
            Culture="es-ES" DataSourceID="odsDatos" GridLines="None" AllowAutomaticUpdates="True"
            AllowCustomPaging="True" Width="100%"
            OnGridExporting="rgDatos_GridExporting"
            OnItemCommand="rgDatos_ItemCommand" OnItemCreated="rgDatos_ItemCreated"
            OnItemDataBound="rgDatos_ItemDataBound" OnPreRender="rgDatos_PreRender" AllowMultiRowSelection="True">
            <PagerStyle Visible="true" Mode="NextPrevAndNumeric" AlwaysVisible="True" />
            <ExportSettings ExportOnlyData="True" FileName="HSESP_Fuentes" HideStructureColumns="True"
                IgnorePaging="True" OpenInNewWindow="True">
            </ExportSettings>
            <MasterTableView AutoGenerateColumns="False" CommandItemDisplay="Top" 
                DataSourceID="odsDatos" Width="100%"
                OverrideDataSourceControlSorting="True" DataKeyNames="Id">
                <CommandItemSettings ExportToPdfText="Export to PDF" ShowExportToExcelButton="True"></CommandItemSettings>
                <%--Encabezado manual--%>
                <CommandItemTemplate>
                    <div style="padding: 5px 5px; float: left; text-align: left;">
                        <asp:LinkButton ID="btnAdd" runat="server" CommandName="InitInsert" ToolTip=" Agregar Nuevo Registro">
                        <img style="border:0;vertical-align:middle;" alt="" src='<%=ResolveUrl("~/img/iconos/agregar.gif") %>' />&nbsp;&nbsp; Agregar &nbsp;&nbsp;
                        </asp:LinkButton>

                         <asp:LinkButton ID="btnDelete" runat="server" CommandName="Borrar" ToolTip=" Borrar Registro">
                        <img style="border:0;vertical-align:middle;" alt="" src='<%=ResolveUrl("~/img/iconos/eliminar.gif") %>' />&nbsp;&nbsp; Borrar &nbsp;&nbsp;
                        </asp:LinkButton>|
                    
                        <asp:CheckBox ID="ckbActivarFiltro" runat="server" OnCheckedChanged="ckbActivarFiltro_CheckedChanged"
                            Text=" Activar Filtro" ToolTip=" Activar filtro de Busqueda" AutoPostBack="true" />
                    </div>
                    <div style="padding: 5px 5px; float: right; text-align: right;">
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="RebindGrid" ToolTip=" Actualizar Tabla">
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
                    <telerik:GridClientSelectColumn UniqueName="ClientSelectColumn" HeaderStyle-Width="10px">
                    <HeaderStyle Width="10px"></HeaderStyle>
                    </telerik:GridClientSelectColumn>
                    <telerik:GridEditCommandColumn FilterControlAltText="Filter Editar column" UniqueName="Editar" ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="10px"
                        ButtonType="ImageButton">
                    <HeaderStyle Width="10px"></HeaderStyle>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </telerik:GridEditCommandColumn>
                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" ConfirmDialogType="RadWindow" ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="10px"
                        ConfirmText="¿Eliminar el registro?" ConfirmTitle="Eliminar" FilterControlAltText="Filter DeleteColumn column"
                        Text="Eliminar" UniqueName="DeleteColumn">
<HeaderStyle Width="10px"></HeaderStyle>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </telerik:GridButtonColumn>
                    <telerik:GridCheckBoxColumn DataField="Activo" DataType="System.Boolean" FilterControlAltText="Filter Activo column" ItemStyle-HorizontalAlign="Center"
                        HeaderText="Activo" SortExpression="Activo" UniqueName="Activo" HeaderStyle-Width="10px"
                        DefaultInsertValue="True">
<HeaderStyle Width="10px"></HeaderStyle>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </telerik:GridCheckBoxColumn>
                    <telerik:GridTemplateColumn DataField="Activo" FilterControlAltText="Filter ActivoExportar column"
                        HeaderText="Activo" SortExpression="Activo" UniqueName="ActivoExportar" Visible="False">
                        <ItemTemplate>
                            <asp:Label ID="lblActivoExp" runat="server" Text='<%# Eval("Activo") %>'></asp:Label>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridBoundColumn DataField="Nombre"
                        FilterControlAltText="Filter Nombre column" HeaderText="Nombre"
                        SortExpression="Nombre" UniqueName="Nombre">
                    </telerik:GridBoundColumn>
                </Columns>
                <EditFormSettings>
                    <EditColumn FilterControlAltText="Filter EditCommandColumn column" ButtonType="ImageButton">
                    </EditColumn>
                </EditFormSettings>
                <PagerStyle AlwaysVisible="True" />
            </MasterTableView>
             <ClientSettings EnableRowHoverStyle="true">
                <Selecting AllowRowSelect="True"></Selecting>
            </ClientSettings>
            <HeaderStyle HorizontalAlign="Center" />
            <FilterMenu EnableImageSprites="False">
            </FilterMenu>
            <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Web20">
            </HeaderContextMenu>
        </telerik:RadGrid>
        <asp:ObjectDataSource ID="odsDatos" runat="server" SelectMethod="ConsultarRoles"
            TypeName="Seguridad.DALC.clsFachadaClaseBase" OnDeleted="odsDatos_Deleted"
            OnInserted="odsDatos_Inserted"
            OnObjectCreating="odsDatos_ObjectCreating"
            OnUpdated="odsDatos_Updated" DataObjectTypeName="Seguridad.clsRol" DeleteMethod="EliminarRol" InsertMethod="InsertarRol" UpdateMethod="EditarRol">
            <SelectParameters>
                <asp:Parameter DefaultValue="-1" Name="activo" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <telerik:RadWindowManager ID="PopUp" runat="server">
        </telerik:RadWindowManager>
        <telerik:RadAjaxLoadingPanel ID="rlpDatos" runat="server" Skin="Default" Width="256px">
            <img alt="" src="../../img/iconos/cargando.gif" />
        </telerik:RadAjaxLoadingPanel>
        <telerik:RadAjaxManagerProxy ID="RadAjaxManagerProxy1" runat="server">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="rgDatos">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="rgDatos" LoadingPanelID="rlpDatos" />
                        <telerik:AjaxUpdatedControl ControlID="rwmManagerPopUp" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="rwmManagerPopUp">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="rgDatos" LoadingPanelID="rlpDatos" />
                        <telerik:AjaxUpdatedControl ControlID="rwmManagerPopUp" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManagerProxy>
    </div>
</asp:Content>
