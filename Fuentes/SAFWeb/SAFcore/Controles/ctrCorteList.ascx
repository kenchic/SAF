<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrCorteList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrCorteList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmCorteForm.aspx?IdCorte=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idProyectoVenta" Caption="idProyectoVenta">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idProyectoAlquiler" Caption="idProyectoAlquiler">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Numero" Caption="Numero">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Fecha" Caption="Fecha">
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
