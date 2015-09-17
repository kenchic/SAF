<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMenuModulos.aspx.cs" Inherits="SAFWeb.Sistema.frmMenuModulos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%">
                <tr>
                    <td>
                        <dx:ASPxLabel ID="lbTituloMenu" runat="server" ClientInstanceName="lbTituloMenu">
                        </dx:ASPxLabel>
                    </td>
                </tr>
                <tr>
                    <td>
                        
                        <dx:ASPxNavBar ID="nbMenuModulo" runat="server" ClientInstanceName="nbMenuModulo" Target="contenidoCentral" Width="100%">
                        </dx:ASPxNavBar>
                        
                    </td>
                </tr>
            </table>


        </div>
    </form>
</body>
</html>
