using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleDevolucionServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleDevolucionServicio
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

        const string nombreForm = "DetalleDevolucionServicioForm";
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
            if (long.TryParse(Request["IdDetalleDevolucionServicio"], out valor))
                IdDetalleDevolucionServicio = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleDevolucionServicio.Campos.Id, IdDetalleDevolucionServicio, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosDetalleDevolucionServicio(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsDetalleDevolucionServicio DetalleDevolucionServicio = new clsDetalleDevolucionServicio();
            if (cbidDevolucionServicio.Value != null)
DetalleDevolucionServicio.idDevolucionServicio = Convert.ToInt32(cbidDevolucionServicio.Value);
if (cbidElemento.Value != null)
DetalleDevolucionServicio.idElemento = Convert.ToInt16(cbidElemento.Value);
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleDevolucionServicio.Cantidad = valorCantidad;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleDevolucionServicio == 0)
            {
                resultado = fachadaCore.insertarDetalleDevolucionServicio(DetalleDevolucionServicio);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleDevolucionServicio.Campos.Id, IdDetalleDevolucionServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleDevolucionServicio(DetalleDevolucionServicio, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidDevolucionServicio.DataSource = fachadaCore.consultarDatosDevolucionServicio(sql);
cbidDevolucionServicio.ValueField = "Id";
cbidDevolucionServicio.TextField = "Nombre";
cbidDevolucionServicio.DataBind();
cbidElemento.DataSource = fachadaCore.consultarDatosElemento(sql);
cbidElemento.ValueField = "Id";
cbidElemento.TextField = "Nombre";
cbidElemento.DataBind();

        }
        #endregion
    }
}