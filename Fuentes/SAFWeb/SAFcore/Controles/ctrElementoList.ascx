<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrElementoList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrElementoList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmElementoForm.aspx?IdElemento=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="idGrupoElemento" Caption="idGrupoElemento">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="idUnidadMedida" Caption="idUnidadMedida">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Referencia" Caption="Referencia">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Nombre" Caption="Nombre">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Mt2" Caption="Mt2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Peso" Caption="Peso">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn Caption="Rotacion" FieldName="Rotacion" UnboundType="Boolean">
            </dx:GridViewDataCheckColumn>
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
