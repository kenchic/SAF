using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleOrdenServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleOrdenServicio
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

        const string nombreForm = "DetalleOrdenServicioForm";
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
            if (long.TryParse(Request["IdDetalleOrdenServicio"], out valor))
                IdDetalleOrdenServicio = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleOrdenServicio.Campos.Id, IdDetalleOrdenServicio, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosDetalleOrdenServicio(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsDetalleOrdenServicio DetalleOrdenServicio = new clsDetalleOrdenServicio();
            if (cbidOrdenServicio.Value != null)
DetalleOrdenServicio.idOrdenServicio = Convert.ToInt32(cbidOrdenServicio.Value);
if (cbidElemento.Value != null)
DetalleOrdenServicio.idElemento = Convert.ToInt16(cbidElemento.Value);
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleOrdenServicio.Cantidad = valorCantidad;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleOrdenServicio == 0)
            {
                resultado = fachadaCore.insertarDetalleOrdenServicio(DetalleOrdenServicio);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleOrdenServicio.Campos.Id, IdDetalleOrdenServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleOrdenServicio(DetalleOrdenServicio, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidOrdenServicio.DataSource = fachadaCore.consultarDatosOrdenServicio(sql);
cbidOrdenServicio.ValueField = "Id";
cbidOrdenServicio.TextField = "Nombre";
cbidOrdenServicio.DataBind();
cbidElemento.DataSource = fachadaCore.consultarDatosElemento(sql);
cbidElemento.ValueField = "Id";
cbidElemento.TextField = "Nombre";
cbidElemento.DataBind();

        }
        #endregion
    }
}