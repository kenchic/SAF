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
            sql.FiltroBD.Add(new FiltroBD("Usuario", inpUsuario.Value, FiltroBD.OperadorLogico.igual));
            sql.FiltroBD.Add(new FiltroBD("Clave", inpClave.Value, FiltroBD.OperadorLogico.igual));
            var usuario = fachadaSeg.consultarEntidadUsuario(sql);
            if (usuario != null)
                Response.Redirect("~/sistema/Principal.aspx");
        }
    }
}