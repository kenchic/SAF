<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrProyectoList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrProyectoList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmProyectoPrincipal.aspx?IdProyecto=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
            </dx:GridViewDataTextColumn>            
            <dx:GridViewDataTextColumn FieldName="NombreCliente" Caption="Cliente">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="NombreCiudad" Caption="Ciudad">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Nombre" Caption="Nombre">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Tipo" Caption="Tipo">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Direccion" Caption="Dirección">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Telefono" Caption="Teléfono">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Fecha" Caption="Fecha">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Estado" Caption="Estado">
            </dx:GridViewDataTextColumn>
        </Columns>
        <SettingsPager AlwaysShowPager="True" PageSize="20">
        </SettingsPager>
        <Styles>
            <AlternatingRow Enabled="True">
            </AlternatingRow>
        </Styles>
        <Border BorderStyle="None"></Border>
    </dx:ASPxGridView>
</div>
