using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrBodegaList : System.Web.UI.UserControl
    {
        #region Propiedades
        const string nombreForm = "BodegaList";
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Datos" + nombreForm] = null;
                gvDatos.SettingsSearchPanel.CustomEditorID = "txtBuscar";
                gvDatos.DataBind();
            }
        }

        protected void gvDatos_DataBinding(object sender, EventArgs e)
        {
            ASPxGridView grid = sender as ASPxGridView;
            if (Session["Datos" + nombreForm] == null)
                grid.DataSource = obtenerDatos();
            else
                grid.DataSource = Session["Datos" + nombreForm];
        }
        #endregion

        #region metodos
        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaSeg = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            DataTable datos = fachadaSeg.consultarDatosBodega(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }
        #endregion
    }
}