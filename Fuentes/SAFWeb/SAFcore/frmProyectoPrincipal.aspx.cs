using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAFWeb.SAFcore
{
    public partial class frmProyectoPrincipal : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                obtenerQueryString();
        }
        #endregion

        #region Metodos
        private void obtenerQueryString()
        {
            long valor = 0;
            if (long.TryParse(Request["IdProyecto"], out valor))
                hlInfoProyecto.NavigateUrl += "?IdProyecto=" + valor;
        }
        #endregion
    }
}