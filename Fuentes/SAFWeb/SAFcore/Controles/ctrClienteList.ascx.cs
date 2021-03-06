using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrClienteList : System.Web.UI.UserControl
    {
        #region Propiedades
        const string nombreForm = "ClienteList";
        #endregion

        #region eventos

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["DatosCiudad" + nombreForm] = null;
            }

            if (Session["DatosCiudad" + nombreForm] != null)
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idCiudad"]).PropertiesComboBox.DataSource = Session["DatosCiudad" + nombreForm];
            else
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idCiudad"]).PropertiesComboBox.DataSource = obtenerDatoCiudad();



            ((GridViewDataComboBoxColumn)gvDatos.Columns["idCiudad"]).PropertiesComboBox.TextField = "Nombre";
            ((GridViewDataComboBoxColumn)gvDatos.Columns["idCiudad"]).PropertiesComboBox.ValueField = "Id";
            
        }
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

        private DataTable obtenerDatoCiudad()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaSeg = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsCiudad.Campos.Activo, true, FiltroBD.OperadorLogico.igual));
            DataTable datos = fachadaSeg.consultarDatosCiudad(sql);
            Session["DatosCiudad" + nombreForm] = datos;
            return datos;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaSeg = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            DataTable datos = fachadaSeg.consultarDatosCliente(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }
        #endregion
    }
}