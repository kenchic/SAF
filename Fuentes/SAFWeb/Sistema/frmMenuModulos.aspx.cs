using BaseDatos;
using SAFseg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAFWeb.Sistema
{
    public partial class frmMenuModulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["ModuloID"] != null)
                {
                    var idModulo = Request["ModuloID"];
                    var ejecutor = (Comandos)Session["ejecutorBDSAFseg"];
                    var fachadaSeg = new clsFachadaSAFSegAdicional(ref ejecutor);
                    var rol = (clsRol)Session["UsuarioRol"];

                    SentenciaSQL sql = new SentenciaSQL();
                    sql.FiltroBD.Add(new FiltroBD(clsMenuRol.Campos.idrol, rol.Id, FiltroBD.OperadorLogico.igual));
                    sql.FiltroBD.Add(new FiltroBD(clsMenu.Campos.idmenunivel1, idModulo, FiltroBD.OperadorLogico.igual));
                    sql.OrdenBD.Add(clsMenu.Campos.orden);
                    
                    List<clsMenu> menu = fachadaSeg.consultarListaMenuRol(sql);

                    if (menu != null)
                    {
                        var index = -1;
                        var idNivel2 = -1;
                        foreach (var item in menu)
                        {
                            if (item.idMenuNivel2 == 0)
                            {
                                index++;
                                nbMenuModulo.Groups.Add(item.Nombre);
                                idNivel2 = item.idMenuNivel2.Value;
                            }
                            else
                                nbMenuModulo.Groups[index].Items.Add(item.Nombre, "ID" + item.Id, item.Imagen, item.Url);
                        }
                    }
                }
            }

        }
    }
}