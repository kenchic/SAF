<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrProyectoList.ascx.cs" Inherits="SAFWeb.Proyectos.Controles.ctrProyectoList" %>
<div style="margin-left: -8px">
    <dx:ASPxGridView ID="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%" Border-BorderStyle="None">
        <Columns>
            <dx:GridViewDataTextColumn Name="NombreCliente" Caption="Cliente " VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Name="NombreCiudad" Caption="Ciudad" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Name="Nombre" Caption="Nombre" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
        </Columns>
    </dx:ASPxGridView>
</div>
