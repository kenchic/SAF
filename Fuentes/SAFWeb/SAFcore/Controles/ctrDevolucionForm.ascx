<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrDevolucionForm.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrDevolucionForm" %>
<div class="layoutForm">
    <dx:ASPxFormLayout ID="flDatos" runat="server">
        <Items>
            <dx:LayoutGroup Caption="Datos Devolucion">
                <Items>
                   <dx:LayoutItem Caption="Id">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxLabel ID="lbId" runat="server" Text="0">
</dx:ASPxLabel>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="idProyecto">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxComboBox ID="cbidProyecto" runat="server" CssClass="ComboBox">
</dx:ASPxComboBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="idConductor">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxComboBox ID="cbidConductor" runat="server" CssClass="ComboBox">
</dx:ASPxComboBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="Numero">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtNumero" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="FechaAnunciada">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtFechaAnunciada" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="FechaRecogida">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtFechaRecogida" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="FechaCreacion">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtFechaCreacion" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="EntregaCliente">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckEntregaCliente" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="EntregaParcial">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckEntregaParcial" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="TipoMantenimiento">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtTipoMantenimiento" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="Hora">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtHora" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="Anulado">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckAnulado" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="ValorTransporte">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtValorTransporte" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="PesoEquipo">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtPesoEquipo" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem><dx:LayoutItem Caption="ValorEquipo">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtValorEquipo" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>    
				   
				                 
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
</div>