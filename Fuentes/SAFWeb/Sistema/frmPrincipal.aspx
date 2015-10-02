<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="SAFWeb.Sistema.Principal" ClientIDMode="Static"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxSplitter ID="spContenido" runat="server" FullscreenMode="True" Width="100%" Height="100%" Orientation="Vertical">
                <Panes>
                    <dx:SplitterPane Size="40px" Name="Encabezado" ContentUrl="frmEncabezado.aspx" PaneStyle-BackColor="#333333">
                        <Separators>
                            <SeparatorStyle>
                            <Border BorderStyle="None" />
                            </SeparatorStyle>
                        </Separators>
                        <PaneStyle>
                            <Border BorderStyle="None" />
                        </PaneStyle>
                        <ContentCollection>
                            <dx:SplitterContentControl runat="server">
                            </dx:SplitterContentControl>
                        </ContentCollection>
                    </dx:SplitterPane>

                    <dx:SplitterPane Name="Contenido">                        
                        <Separator Visible="False">
                        </Separator>
                        <Panes>
                            <%--IZQUIERDA--%>
                            <dx:SplitterPane Size="200px" Name="contenidoIzquierda" ShowCollapseBackwardButton="True" ContentUrlIFrameName="contenidoIzquierda" ContentUrl="frmContenidoVacio.aspx">
                                <PaneStyle>
                                    <Border BorderStyle="None" />
                                </PaneStyle>
                                <ContentCollection>
                                    <dx:SplitterContentControl runat="server">
                                    </dx:SplitterContentControl>
                                </ContentCollection>
                            </dx:SplitterPane>
                            <%--CONTENIDO--%>
                            <dx:SplitterPane Name="Central" ContentUrlIFrameName="contenidoCentral" ContentUrl="frmContenidoVacio.aspx">
                                <PaneStyle>
                                    <Border BorderStyle="None" />
                                </PaneStyle>
                                <ContentCollection>
                                    <dx:SplitterContentControl runat="server"></dx:SplitterContentControl>
                                </ContentCollection>
                            </dx:SplitterPane>
                        </Panes>
                        <PaneStyle>
                            <Border BorderStyle="None" />
                        </PaneStyle>
                        <ContentCollection>
                            <dx:SplitterContentControl runat="server"></dx:SplitterContentControl>
                        </ContentCollection>
                    </dx:SplitterPane>

                    <dx:SplitterPane Size="40px" Name="Pie" PaneStyle-BackColor="#333333">
                        <Separator Visible="False">
                        </Separator>
                        <PaneStyle>
                            <Border BorderStyle="None" />
                        </PaneStyle>
                        <ContentCollection>
                            <dx:SplitterContentControl runat="server">
                            </dx:SplitterContentControl>
                        </ContentCollection>
                    </dx:SplitterPane>

                </Panes>
            </dx:ASPxSplitter>
        </div>
    </form>
</body>
</html>
