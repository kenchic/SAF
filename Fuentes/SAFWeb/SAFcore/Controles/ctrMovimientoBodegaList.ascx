<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrMovimientoBodegaList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrMovimientoBodegaList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmMovimientoBodegaForm.aspx?IdMovimientoBodega=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idElemeto" Caption="idElemeto">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idBodegaOrigen" Caption="idBodegaOrigen">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idBodegaDestino" Caption="idBodegaDestino">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Documento" Caption="Documento">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Numero" Caption="Numero">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Operacion" Caption="Operacion">
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
