<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrParametroSistemaForm.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrParametroSistemaForm" %>
<div class="layoutForm">
    <dx:ASPxFormLayout ID="flDatos" runat="server" OnDataBinding="flDatos_DataBinding">
        <Items>
            <dx:LayoutGroup Caption="Datos ParametroSistema">
                <Items>
                   <dx:LayoutItem Caption="Codigo" FieldName="Codigo">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtCodigo" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="idParametro" FieldName="idParametro">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxComboBox ID="cbidParametro" runat="server" CssClass="ComboBox">
</dx:ASPxComboBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Valor" FieldName="Valor">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtValor" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>

                   <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" Width="100">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainerDatos" runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxButton ID="btGuardar" runat="server" Text="Guardar" OnClick="btGuardar_Click" Width="100" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
</div>