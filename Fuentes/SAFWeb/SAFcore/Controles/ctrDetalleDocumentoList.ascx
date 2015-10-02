<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrDetalleDocumentoList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrDetalleDocumentoList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmDetalleDocumentoForm.aspx?IdDetalleDocumento=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idElemento" Caption="idElemento">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idDocumento" Caption="idDocumento">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Cantidad" Caption="Cantidad">
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
