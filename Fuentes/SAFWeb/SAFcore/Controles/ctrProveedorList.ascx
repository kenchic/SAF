<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrProveedorList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrProveedorList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmProveedorForm.aspx?IdProveedor=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Identificacion" Caption="Identificacion">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Nombre" Caption="Nombre">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Iniciales" Caption="Iniciales">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Telefono" Caption="Telefono">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Direccion" Caption="Direccion">
</dx:GridViewDataTextColumn>
<dx:GridViewDataCheckColumn Caption="Activo" FieldName="Activo" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>

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
