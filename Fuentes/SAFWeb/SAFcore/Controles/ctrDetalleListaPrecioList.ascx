<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrDetalleListaPrecioList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrDetalleListaPrecioList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmDetalleListaPrecioForm.aspx?IdDetalleListaPrecio=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idListaPrecios" Caption="idListaPrecios">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idElemento" Caption="idElemento">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="PrecioAlquiler" Caption="PrecioAlquiler">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="PrecioVenta" Caption="PrecioVenta">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="PrecioPerdida" Caption="PrecioPerdida">
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
