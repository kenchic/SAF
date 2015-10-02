<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrParametroSistemaList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrParametroSistemaList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmParametroSistemaForm.aspx?IdParametroSistema=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Codigo" Caption="Codigo">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idParametro" Caption="idParametro">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Valor" Caption="Valor">
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
