<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrFacturaList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrFacturaList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmFacturaForm.aspx?IdFactura=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idCorte" Caption="idCorte">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Numero" Caption="Numero">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FechaEmision" Caption="FechaEmision">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FechaVencimiento" Caption="FechaVencimiento">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Son" Caption="Son">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="ParcialTotal" Caption="ParcialTotal">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Dcto" Caption="Dcto">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="SubTotal" Caption="SubTotal">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Iva" Caption="Iva">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Total" Caption="Total">
</dx:GridViewDataTextColumn>
<dx:GridViewDataCheckColumn Caption="Anulada" FieldName="Anulada" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataTextColumn FieldName="idTipoFactura" Caption="idTipoFactura">
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
