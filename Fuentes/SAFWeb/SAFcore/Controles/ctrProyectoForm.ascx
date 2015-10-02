<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrProyectoForm.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrProyectoForm" %>
<div class="layoutForm">
    <dx:ASPxFormLayout ID="flDatos" runat="server" OnDataBinding="flDatos_DataBinding">
        <Items>
            <dx:LayoutGroup Caption="Datos Proyecto">
                <Items>
                   <dx:LayoutItem Caption="Id" FieldName="Id">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxLabel ID="lbId" runat="server" Text="0">
</dx:ASPxLabel>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="idCliente" FieldName="idCliente">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxComboBox ID="cbidCliente" runat="server" CssClass="ComboBox">
</dx:ASPxComboBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="idCiudad" FieldName="idCiudad">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxComboBox ID="cbidCiudad" runat="server" CssClass="ComboBox">
</dx:ASPxComboBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="NombreCliente" FieldName="NombreCliente">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtNombreCliente" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="NombreCiudad" FieldName="NombreCiudad">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtNombreCiudad" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Nombre" FieldName="Nombre">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtNombre" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Tipo" FieldName="Tipo">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtTipo" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Direccion" FieldName="Direccion">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtDireccion" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Telefono" FieldName="Telefono">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtTelefono" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Observacion" FieldName="Observacion">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtObservacion" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Fecha" FieldName="Fecha">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtFecha" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="FormaContacto" FieldName="FormaContacto">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtFormaContacto" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="SistemaMedida" FieldName="SistemaMedida">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtSistemaMedida" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="IdentificacionResponsable" FieldName="IdentificacionResponsable">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtIdentificacionResponsable" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="NombreResponsable" FieldName="NombreResponsable">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtNombreResponsable" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="TelResponsable" FieldName="TelResponsable">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxTextBox ID="txtTelResponsable" runat="server" CssClass="TextBox">
</dx:ASPxTextBox>
</dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Activo" FieldName="Activo">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxCheckBox ID="ckActivo" runat="server" CheckState="Unchecked" CssClass="CheckBox">
</dx:ASPxCheckBox></dx:LayoutItemNestedControlContainer>
</LayoutItemNestedControlCollection>
</dx:LayoutItem>
<dx:LayoutItem Caption="Estado" FieldName="Estado">
<LayoutItemNestedControlCollection>
<dx:LayoutItemNestedControlContainer runat="server">
<dx:ASPxComboBox ID="cbEstado" runat="server" CssClass="ComboBox">
</dx:ASPxComboBox></dx:LayoutItemNestedControlContainer>
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