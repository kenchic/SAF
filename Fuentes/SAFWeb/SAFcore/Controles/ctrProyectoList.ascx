<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrProyectoList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrProyectoList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" ClientInstanceName="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"
        KeyFieldName="Id">
        <Columns>
            <dx:GridViewDataTextColumn Caption="" Width="15%" ReadOnly="true">
                <DataItemTemplate>
                    <a id="hrefEditar" href="FrmProyectoForm.aspx?IdProyecto=<%# Container.KeyValue %>">Editar</a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idCliente" Caption="idCliente">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="idCiudad" Caption="idCiudad">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="NombreCliente" Caption="NombreCliente">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="NombreCiudad" Caption="NombreCiudad">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Nombre" Caption="Nombre">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Tipo" Caption="Tipo">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Direccion" Caption="Direccion">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Telefono" Caption="Telefono">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Observacion" Caption="Observacion">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Fecha" Caption="Fecha">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FormaContacto" Caption="FormaContacto">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="SistemaMedida" Caption="SistemaMedida">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="IdentificacionResponsable" Caption="IdentificacionResponsable">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="NombreResponsable" Caption="NombreResponsable">
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="TelResponsable" Caption="TelResponsable">
</dx:GridViewDataTextColumn>
<dx:GridViewDataCheckColumn Caption="Activo" FieldName="Activo" UnboundType="Boolean">
</dx:GridViewDataCheckColumn>
<dx:GridViewDataTextColumn FieldName="Estado" Caption="Estado">
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
