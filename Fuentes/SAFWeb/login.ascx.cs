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

            List<ParametroBD> parametros = new List<ParametroBD>();
            parametros.Add(new ParametroBD("Usuario", inpUsuario.Value, ParametroBD.OperadorLogico.igual));
            parametros.Add(new ParametroBD("Clave", inpClave.Value, ParametroBD.OperadorLogico.igual));
            var usuario = fachadaSeg.consultarEntidadUsuario(parametros);
            if (usuario != null)
                Response.Redirect("~/sistema/Principal.aspx");
        }
    }
}