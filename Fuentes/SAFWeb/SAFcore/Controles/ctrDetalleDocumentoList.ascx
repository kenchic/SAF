<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrDetalleDocumentoList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrDetalleDocumentoList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id" OnBatchUpdate="gvDatos_BatchUpdate">
        <ClientSideEvents BatchEditConfirmShowing="function(s, e) {
	                                                    e.cancel = true;
                                                    }" />
        <Columns>
            <dx:GridViewCommandColumn ShowEditButton="false" ShowNewButtonInHeader="true" ShowDeleteButton="true"></dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn FieldName="idElemento" Caption="Elemento">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn FieldName="idBodegaOrigen" Caption="Bodega Origen">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn FieldName="idBodegaDestino" Caption="Bodega Destino">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn FieldName="Cantidad" Caption="Cantidad">
            </dx:GridViewDataTextColumn>
        </Columns>
        <SettingsPager AlwaysShowPager="True" PageSize="20" />
        <SettingsEditing Mode="Batch" />
        <Settings ShowStatusBar="Hidden" />
        <Styles>
            <AlternatingRow Enabled="True">
            </AlternatingRow>
        </Styles>
        <Border BorderStyle="None"></Border>
    </dx:ASPxGridView>
    <dx:ASPxHiddenField ID="hdfValores" runat="server"></dx:ASPxHiddenField>
</div>
