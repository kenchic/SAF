using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrOrdenServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdOrdenServicio
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

        const string nombreForm = "OrdenServicioForm";
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
            if (long.TryParse(Request["IdOrdenServicio"], out valor))
                IdOrdenServicio = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsOrdenServicio.Campos.Id, IdOrdenServicio, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosOrdenServicio(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsOrdenServicio OrdenServicio = new clsOrdenServicio();
            if (cbidRemision.Value != null)
OrdenServicio.idRemision = Convert.ToInt32(cbidRemision.Value);
if (cbidProveedor.Value != null)
OrdenServicio.idProveedor = Convert.ToInt16(cbidProveedor.Value);
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
OrdenServicio.Numero = valorNumero;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdOrdenServicio == 0)
            {
                resultado = fachadaCore.insertarOrdenServicio(OrdenServicio);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsOrdenServicio.Campos.Id, IdOrdenServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarOrdenServicio(OrdenServicio, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidRemision.DataSource = fachadaCore.consultarDatosRemision(sql);
cbidRemision.ValueField = "Id";
cbidRemision.TextField = "Nombre";
cbidRemision.DataBind();
cbidProveedor.DataSource = fachadaCore.consultarDatosProveedor(sql);
cbidProveedor.ValueField = "Id";
cbidProveedor.TextField = "Nombre";
cbidProveedor.DataBind();

        }
        #endregion
    }
}