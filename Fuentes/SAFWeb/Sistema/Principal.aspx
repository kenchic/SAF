<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="SAFWeb.Sistema.Principal" %>

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
                    <dx:SplitterPane Size="80px">
                        <ContentCollection>
                            <dx:SplitterContentControl runat="server">
                            </dx:SplitterContentControl>
                        </ContentCollection>
                    </dx:SplitterPane>

                    <dx:SplitterPane>
                        <Panes>
                            <dx:SplitterPane Size="300px">
                                <ContentCollection>
                                    <dx:SplitterContentControl runat="server">
                                    </dx:SplitterContentControl>
                                </ContentCollection>
                            </dx:SplitterPane>
                            <dx:SplitterPane>
                                <Panes>
                                    <dx:SplitterPane>
                                        <ContentCollection>
                                            <dx:SplitterContentControl runat="server">
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
                            </dx:SplitterContentControl>
                        </ContentCollection>
                    </dx:SplitterPane>

                </Panes>
            </dx:ASPxSplitter>
        </div>
    </form>
</body>
</html>
