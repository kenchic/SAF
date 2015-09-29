<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrCiudadList.ascx.cs" Inherits="SAFWeb.SAFcore.Controles.ctrCiudadList" %>
<div class="grillasForm">
    <dx:ASPxGridView ID="gvDatos" runat="server" AutoGenerateColumns="False" OnDataBinding="gvDatos_DataBinding" Width="100%"  Border-BorderStyle="None"
         KeyFieldName="Id" >
        <Columns>
            <dx:GridViewDataTextColumn FieldName="Id" Caption="Id Ciudad" VisibleIndex="0" Visible="false">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Nombre" Caption="Nombre" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Activo" Caption="Activo" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataHyperLinkColumn Caption="Editar" VisibleIndex="3">
                <PropertiesHyperLinkEdit NavigateUrlFormatString"ver">
                </PropertiesHyperLinkEdit>
            </dx:GridViewDataHyperLinkColumn>
        </Columns>

<Border BorderStyle="None"></Border>
    </dx:ASPxGridView>
</div>