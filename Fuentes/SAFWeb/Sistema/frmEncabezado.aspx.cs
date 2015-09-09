using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BaseDatos;
using SAFseg;

namespace SAFWeb.Sistema.Controles
{
    public partial class frmEncabezado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var ejecutor = (Comandos)Session["ejecutorBDSAFseg"];
                var fachadaSeg = new clsFachadaAdicionalSAF(ref ejecutor);
                var rol = (clsRol)Session["UsuarioRol"];

                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsMenuRol.Campos.idrol, rol.Id, FiltroBD.OperadorLogico.igual));
                List<clsMenu> menu = fachadaSeg.consultarListaMenuRol(sql);
                if (menu != null)
                {
                    //Menu.Items.Clear();
                    //foreach (var item in menu)
                    //{
                            
                    //}
                    //Menu.NameField = "Nombre";
                    //Menu.NavigateUrlField = "Url";
                    //Menu.TextField = "Nombre";
                    //Menu.DataSource = menu;
                    //Menu.DataBind();
                }
            }
        }
    }
}