<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrParametroForm.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrParametroForm" %>
<div class="layoutForm">
    <dx:ASPxFormLayout ID="flDatos" runat="server">
        <Items>
            <dx:LayoutGroup Caption="Datos Parametro">
                <Items>
                   <dx:LayoutItem Caption="Id">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxLabel ID="lbId" runat="server" Text="0">
</dx:ASPxLabel>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Nombre">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtNombre" runat="server" CssClass="TextBox">
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