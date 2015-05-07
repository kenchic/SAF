<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SAFWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <dx:ASPxSplitter ID="spContenido" runat="server" FullscreenMode="True" Width="100%" Height="100%" Orientation="Vertical" >
                <Panes>
                    <dx:SplitterPane Size="80px">
                        <ContentCollection>
                            <dx:SplitterContentControl runat="server">
                                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%; height: 100%;">
                                    <tr>
                                        <td align="center">
                                            <dx:ASPxLabel runat="server" Text="Encabezado"
                                                Font-Size="14px" ID="ASPxLabel1" />
                                        </td>
                                    </tr>
                                </table>
                            </dx:SplitterContentControl>
                        </ContentCollection>
                    </dx:SplitterPane>

                    <dx:SplitterPane>
                        <Panes>
                            <dx:SplitterPane Size="300px">
                                <ContentCollection>
                                    <dx:SplitterContentControl runat="server">
                                        <table cellpadding="0" cellspacing="0" border="0" style="width: 100%; height: 100%;">
                                            <tr>
                                                <td align="center" style="text-align: left">
                                                    <dx:ASPxLabel runat="server" Text="Opciones"
                                                        Font-Size="14px" ID="lbTituloOpciones" />
                                                    <br />
                                                    <dx:ASPxMenu ID="menu" runat="server" Orientation="Vertical">
                                                    </dx:ASPxMenu>
                                                </td>
                                            </tr>
                                        </table>
                                    </dx:SplitterContentControl>
                                </ContentCollection>
                            </dx:SplitterPane>
                            <dx:SplitterPane>
                                <Panes>
                                    <dx:SplitterPane>
                                        <ContentCollection>
                                            <dx:SplitterContentControl runat="server">
                                                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%; height: 100%;">
                                                    <tr>
                                                        <td align="center">
                                                            <dx:ASPxLabel runat="server" Text="Contenido" Font-Size="14px"
                                                                ID="ASPxLabel3" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </dx:SplitterContentControl>
                                        </ContentCollection>
                                    </dx:SplitterPane>
                                </Panes>
<ContentCollection>
<dx:SplitterContentControl runat="server"></dx:SplitterContentControl>
</ContentCollection>
                            </dx:SplitterPane>
                        </Panes>
<ContentCollection>
<dx:SplitterContentControl runat="server"></dx:SplitterContentControl>
</ContentCollection>
                    </dx:SplitterPane>

                    <dx:SplitterPane Size="60px">
                        <ContentCollection>
                            <dx:SplitterContentControl runat="server">
                                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%; height: 100%;">
                                    <tr>
                                        <td align="center">
                                            <dx:ASPxLabel runat="server" Text="Pie Pagina." Font-Size="14px" ID="ASPxLabel4" />
                                        </td>
                                    </tr>
                                </table>
                            </dx:SplitterContentControl>
                        </ContentCollection>
                    </dx:SplitterPane>

                </Panes>
            </dx:ASPxSplitter>

        </div>
    </form>
</body>
</html>
