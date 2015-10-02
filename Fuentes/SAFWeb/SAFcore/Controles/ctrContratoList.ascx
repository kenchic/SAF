<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrContratoList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrContratoList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmContratoForm.aspx?IdContrato=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idListaPrecios" Caption="idListaPrecios">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idAgente" Caption="idAgente">
</dx:GridViewDataTextColumn>
<dx:GridViewDataCheckColumn Caption="InformacionBD" FieldName="InformacionBD" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="ContratoAlquiler" FieldName="ContratoAlquiler" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="CartaPagare" FieldName="CartaPagare" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="Pagare" FieldName="Pagare" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="LetraCambio" FieldName="LetraCambio" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="GarantiasCondiciones" FieldName="GarantiasCondiciones" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="Deposito" FieldName="Deposito" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="Anticipo" FieldName="Anticipo" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="PersonaJuridica" FieldName="PersonaJuridica" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="PersonaNatural" FieldName="PersonaNatural" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="FotoCopiaCedula" FieldName="FotoCopiaCedula" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="FotoCopiaNit" FieldName="FotoCopiaNit" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="CamaraComercio" FieldName="CamaraComercio" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataTextColumn FieldName="DescuentoAlquiler" Caption="DescuentoAlquiler">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="DescuentoVenta" Caption="DescuentoVenta">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="DescuentoReposicion" Caption="DescuentoReposicion">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="DescuentoMantenimiento" Caption="DescuentoMantenimiento">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="DescuentoTransporte" Caption="DescuentoTransporte">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="PorcentajeAgente" Caption="PorcentajeAgente">
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
