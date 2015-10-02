using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrProyectoAlquilerForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdProyectoAlquiler
        {
            get
            {
                long valor = 0;
                long.TryParse(lbId.Text, out valor);
                return valor;
            }

            set
            {
                lbId.Text = value.ToString();
            }
        }

        const string nombreForm = "ProyectoAlquilerForm";
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Datos" + nombreForm] = null;
                obtenerQueryString();
                flDatos.DataBind();
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            registarDatos();
        }

        protected void flDatos_DataBinding(object sender, EventArgs e)
        {
            ASPxFormLayout form = sender as ASPxFormLayout;
            if (Session["Datos" + nombreForm] == null)
                form.DataSource = obtenerDatos();
            else
                form.DataSource = Session["Datos" + nombreForm];
        }
        #endregion

        #region Metodos
        private void obtenerQueryString()
        {
            long valor = 0;
            if (long.TryParse(Request["IdProyectoAlquiler"], out valor))
                IdProyectoAlquiler = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsProyectoAlquiler.Campos.Id, IdProyectoAlquiler, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosProyectoAlquiler(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsProyectoAlquiler ProyectoAlquiler = new clsProyectoAlquiler();
            if (cbidProyecto.Value != null)
ProyectoAlquiler.idProyecto = Convert.ToInt16(cbidProyecto.Value);


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdProyectoAlquiler == 0)
            {
                resultado = fachadaCore.insertarProyectoAlquiler(ProyectoAlquiler);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsProyectoAlquiler.Campos.Id, IdProyectoAlquiler, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarProyectoAlquiler(ProyectoAlquiler, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidProyecto.DataSource = fachadaCore.consultarDatosProyecto(sql);
cbidProyecto.ValueField = "Id";
cbidProyecto.TextField = "Nombre";
cbidProyecto.DataBind();

        }
        #endregion
    }
}