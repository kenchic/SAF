<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrClienteList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrClienteList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmClienteForm.aspx?IdCliente=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn FieldName="idCiudad" Caption="idCiudad">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn FieldName="Identificacion" Caption="Identificacion">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Nombre1" Caption="Nombre1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Nombre2" Caption="Nombre2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Apellido1" Caption="Apellido1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Apellido2" Caption="Apellido2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Nombre" Caption="Nombre">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Direccion" Caption="Direccion">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Telefono" Caption="Telefono">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Celular" Caption="Celular">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Correo" Caption="Correo">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn Caption="Activo" FieldName="Activo" UnboundType="Boolean">
            </dx:GridViewDataCheckColumn>

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
