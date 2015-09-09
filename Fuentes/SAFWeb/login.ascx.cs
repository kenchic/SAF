using System;
using System.Collections.Generic;
using System.Linq;
using BaseDatos;
using SAFseg;

namespace SAFWeb
{
    public partial class login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFseg"];
            var fachadaSeg = new clsFachadaSAF(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsUsuario.Campos.usuario, inpUsuario.Value, FiltroBD.OperadorLogico.igual));
            sql.FiltroBD.Add(new FiltroBD(clsUsuario.Campos.clave, inpClave.Value, FiltroBD.OperadorLogico.igual));
            var usuario = fachadaSeg.consultarEntidadUsuario(sql);
            if (usuario != null)
            {
                Session["Usuario"] = usuario;
                
                sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsRol.Campos.id, usuario.idRol, FiltroBD.OperadorLogico.igual));
                var rol = fachadaSeg.consultarEntidadRol(sql);

                Session["UsuarioRol"] = rol;
                Response.Redirect("~/sistema/Principal.aspx");
            }
        }
    }
}