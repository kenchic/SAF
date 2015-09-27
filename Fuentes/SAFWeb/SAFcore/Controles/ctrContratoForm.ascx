<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrContratoForm.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrContratoForm" %>
<div class="layoutForm">
    <dx:ASPxFormLayout ID="flDatos" runat="server">
        <Items>
            <dx:LayoutGroup Caption="Datos Contrato">
                <Items>
                   <dx:LayoutItem Caption="Id">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxLabel ID="lbId" runat="server" Text="0">
</dx:ASPxLabel>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="idListaPrecios">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxComboBox ID="cbidListaPrecios" runat="server" CssClass="ComboBox">
</dx:ASPxComboBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="idAgente">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxComboBox ID="cbidAgente" runat="server" CssClass="ComboBox">
</dx:ASPxComboBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="InformacionBD">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckInformacionBD" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="ContratoAlquiler">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckContratoAlquiler" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="CartaPagare">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckCartaPagare" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Pagare">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckPagare" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="LetraCambio">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckLetraCambio" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="GarantiasCondiciones">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckGarantiasCondiciones" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Deposito">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckDeposito" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Anticipo">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckAnticipo" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="PersonaJuridica">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckPersonaJuridica" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="PersonaNatural">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckPersonaNatural" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="FotoCopiaCedula">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckFotoCopiaCedula" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="FotoCopiaNit">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckFotoCopiaNit" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="CamaraComercio">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckCamaraComercio" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="DescuentoAlquiler">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtDescuentoAlquiler" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="DescuentoVenta">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtDescuentoVenta" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="DescuentoReposicion">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtDescuentoReposicion" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="DescuentoMantenimiento">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtDescuentoMantenimiento" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="DescuentoTransporte">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtDescuentoTransporte" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="PorcentajeAgente">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtPorcentajeAgente" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>

                   <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" Width="100">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxButton ID="btGuardar" runat="server" Text="Guardar" OnClick="btGuardar_Click" Width="100" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
</div>