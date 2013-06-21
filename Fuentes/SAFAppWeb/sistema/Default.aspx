<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SAFAppWeb.sistema.Default" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI, Version=2012.3.1205.45, Culture=neutral, PublicKeyToken=121fae78165ba3d4" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js">
                </asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js">
                </asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js">
                </asp:ScriptReference>
            </Scripts>
        </telerik:RadScriptManager>
    <div>
     <telerik:RadSplitter ID="Radsplitter5" runat="server" Width="700px" Height="300px" Orientation="Horizontal" SplitBarsSize="">
          <telerik:RadPane ID="Radpane2" runat="server" Height="50">
               Menu Principal
          </telerik:RadPane>
          <telerik:RadSplitBar ID="Radsplitbar5" runat="server" CollapseMode="Forward">
          </telerik:RadSplitBar>
          <telerik:RadPane ID="Radpane6" runat="server" Scrolling="None">
               <telerik:RadSplitter ID="Radsplitter6" runat="server">
                    <telerik:RadPane ID="Radpane7" runat="server">
                        Menu Izquierda
                    </telerik:RadPane>
                    <telerik:RadSplitBar ID="Radsplitbar6" runat="server" CollapseMode="Forward">
                    </telerik:RadSplitBar>
                    <telerik:RadPane ID="Radpane8" runat="server">
                         Pagina Principal
                    </telerik:RadPane>
               </telerik:RadSplitter>
          </telerik:RadPane>
     </telerik:RadSplitter><br />
    </div>
    </form>
</body>
</html>
