<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrTipoDocumentoList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrTipoDocumentoList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmTipoDocumentoForm.aspx?IdTipoDocumento=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Nombre" Caption="Nombre">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Consecutivo" Caption="Consecutivo">
</dx:GridViewDataTextColumn>
<dx:GridViewDataCheckColumn Caption="Activo" FieldName="Activo" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataTextColumn FieldName="Operacion" Caption="Operacion">
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
