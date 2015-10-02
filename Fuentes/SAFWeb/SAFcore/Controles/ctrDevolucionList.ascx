<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrDevolucionList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrDevolucionList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmDevolucionForm.aspx?IdDevolucion=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idProyecto" Caption="idProyecto">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idConductor" Caption="idConductor">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Numero" Caption="Numero">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FechaAnunciada" Caption="FechaAnunciada">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FechaRecogida" Caption="FechaRecogida">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FechaCreacion" Caption="FechaCreacion">
</dx:GridViewDataTextColumn>
<dx:GridViewDataCheckColumn Caption="EntregaCliente" FieldName="EntregaCliente" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataCheckColumn Caption="EntregaParcial" FieldName="EntregaParcial" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataTextColumn FieldName="TipoMantenimiento" Caption="TipoMantenimiento">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Hora" Caption="Hora">
</dx:GridViewDataTextColumn>
<dx:GridViewDataCheckColumn Caption="Anulado" FieldName="Anulado" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataTextColumn FieldName="ValorTransporte" Caption="ValorTransporte">
</dx:GridViewDataTextColumn>
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
