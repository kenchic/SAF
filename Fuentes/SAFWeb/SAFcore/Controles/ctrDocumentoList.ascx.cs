using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDocumentoList : System.Web.UI.UserControl
    {
        #region Propiedades
        const string nombreForm = "DocumentoList";
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
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Session["DatosTipoDocumento" + nombreForm] = null;

            if (Session["DatosTipoDocumento" + nombreForm] != null)
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idTipoDocumento"]).PropertiesComboBox.DataSource = Session["DatosTipoDocumento" + nombreForm];
            else
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idTipoDocumento"]).PropertiesComboBox.DataSource = obtenerDatosTipoDocumento();

            ((GridViewDataComboBoxColumn)gvDatos.Columns["idTipoDocumento"]).PropertiesComboBox.TextField = "Nombre";
            ((GridViewDataComboBoxColumn)gvDatos.Columns["idTipoDocumento"]).PropertiesComboBox.ValueField = "Id";
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
            DataTable datos = fachadaSeg.consultarDatosDocumento(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private DataTable obtenerDatosTipoDocumento()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaSeg = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsTipoDocumento.Campos.Activo, true, FiltroBD.OperadorLogico.igual));
            DataTable datos = fachadaSeg.consultarDatosTipoDocumento(sql);
            Session["DatosTipoDocumento" + nombreForm] = datos;
            return datos;
        }
        #endregion
    }
}