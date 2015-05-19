<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SAFWeb.Default" %>

<%@ Register src="login.ascx" tagname="login" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/EstilosLogin.css" type="text/css" media="screen" />
    <title>SAF. Sistema de Alquiler de Formaleta</title>
</head>
<body id="body" runat="server">
    <form id="form1" runat="server">

        <table  style="margin: 0; padding: 0; position: fixed; left: -5px; top: -2px;  width: 102%; height: 102%">
            <tr style="padding: 0px; margin: 0px;">
                <td style="padding: 0px; margin: 0px; height: 100%; min-width: 0%; max-width:5%; cursor: pointer; width: 5%"></td>
                <td class="loginCentral">
                    <uc1:login ID="login1" runat="server" />
                </td>
                <td style="padding: 0px; margin: 0px; height: 100%; min-width: 0%; max-width: 70%; cursor: pointer;  width: 70% "></td>
            </tr>
        </table>
    </form>
</body>
</html>
