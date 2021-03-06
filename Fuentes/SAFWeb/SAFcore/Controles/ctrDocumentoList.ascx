<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrDocumentoList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrDocumentoList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmDocumentoForm.aspx?IdDocumento=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn FieldName="idTipoDocumento" Caption="Tipo Documento">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn FieldName="Numero" Caption="Número">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Fecha" Caption="Fecha">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Descripcion" Caption="Descripción">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn Caption="Anulado" FieldName="Anulado" UnboundType="Boolean">
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
