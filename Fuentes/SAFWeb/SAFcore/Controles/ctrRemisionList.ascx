<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrRemisionList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrRemisionList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmRemisionForm.aspx?IdRemision=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idProyectoAlquiler" Caption="idProyectoAlquiler">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idProyectoVenta" Caption="idProyectoVenta">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idConductor" Caption="idConductor">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Numero" Caption="Numero">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FechaPedido" Caption="FechaPedido">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FechaEntrega" Caption="FechaEntrega">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FechaCreacion" Caption="FechaCreacion">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Hora" Caption="Hora">
</dx:GridViewDataTextColumn>
<dx:GridViewDataCheckColumn Caption="Anulado" FieldName="Anulado" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="Transporte" FieldName="Transporte" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataTextColumn FieldName="ValorTransporte" Caption="ValorTransporte">
</dx:GridViewDataTextColumn>
<dx:GridViewDataCheckColumn Caption="Despachado" FieldName="Despachado" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="EquipoAdecuado" FieldName="EquipoAdecuado" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataTextColumn FieldName="PesoEquipo" Caption="PesoEquipo">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="ValorEquipo" Caption="ValorEquipo">
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
