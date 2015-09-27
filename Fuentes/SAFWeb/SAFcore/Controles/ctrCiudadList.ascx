<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrCiudadList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrCiudadList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"  Border-BorderStyle="None"
         KeyFieldName="Id" >
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