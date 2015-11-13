<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrClienteForm.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrClienteForm" %>
<div class="layoutForm">
    <dx:ASPxFormLayout ID="flDatos" runat="server" OnDataBinding="flDatos_DataBinding">
        <Items>
            <dx:LayoutGroup Caption="Datos Cliente">
                <Items>
                    <dx:LayoutItem Caption="Id" FieldName="Id">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxLabel ID="lbId" runat="server" Text="0">
                                </dx:ASPxLabel>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="idCiudad" FieldName="idCiudad">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxComboBox ID="cbidCiudad" runat="server" CssClass="ComboBox">
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Identificacion" FieldName="Identificacion">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtIdentificacion" runat="server" CssClass="TextBox">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Nombre1" FieldName="Nombre1">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtNombre1" runat="server" CssClass="TextBox">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Nombre2" FieldName="Nombre2">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtNombre2" runat="server" CssClass="TextBox">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Apellido1" FieldName="Apellido1">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtApellido1" runat="server" CssClass="TextBox">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Apellido2" FieldName="Apellido2">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtApellido2" runat="server" CssClass="TextBox">
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
                    <dx:LayoutItem Caption="Celular" FieldName="Celular">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtCelular" runat="server" CssClass="TextBox">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Correo" FieldName="Correo">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtCorreo" runat="server" CssClass="TextBox">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Activo" FieldName="Activo">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="ckActivo" runat="server" CheckState="Unchecked" CssClass="CheckBox">
                                </dx:ASPxCheckBox>
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
