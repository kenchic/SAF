<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="SAFWeb.login" %>

<link rel="stylesheet" href="css/EstilosLogin.css" type="text/css" media="screen" />
<script src="js/prefixfree_login.min.js"></script>

<script language="javascript" type="text/javascript">
    function fireServerButtonEvent() {
        document.getElementById("btnSubmit").click();
    }
</script>

<div id="login">    
    <div class="header">
        <div>SAF</div>
    </div>
    <br />
    <div class="login">
        <input type="text" placeholder="Usuario" name="user" runat="server" id="inpUsuario" /><br />
        <input type="password" placeholder="Clave" name="password" runat="server" id="inpClave" /><br />
        <asp:Button ID="btnIngresar" runat="server" Text="Iniciar" CssClass="botonASP" OnClick="btnIngresar_Click" />
    </div>
</div>

