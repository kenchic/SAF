using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleRepDevolucionServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleRepDevolucionServicio
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

        const string nombreForm = "DetalleRepDevolucionServicioForm";
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
            if (long.TryParse(Request["IdDetalleRepDevolucionServicio"], out valor))
                IdDetalleRepDevolucionServicio = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleRepDevolucionServicio.Campos.Id, IdDetalleRepDevolucionServicio, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosDetalleRepDevolucionServicio(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsDetalleRepDevolucionServicio DetalleRepDevolucionServicio = new clsDetalleRepDevolucionServicio();
            if (cbidRepDevolucionServicio.Value != null)
DetalleRepDevolucionServicio.idRepDevolucionServicio = Convert.ToInt32(cbidRepDevolucionServicio.Value);
if (cbidElemento.Value != null)
DetalleRepDevolucionServicio.idElemento = Convert.ToInt16(cbidElemento.Value);
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleRepDevolucionServicio.Cantidad = valorCantidad;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleRepDevolucionServicio == 0)
            {
                resultado = fachadaCore.insertarDetalleRepDevolucionServicio(DetalleRepDevolucionServicio);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleRepDevolucionServicio.Campos.Id, IdDetalleRepDevolucionServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleRepDevolucionServicio(DetalleRepDevolucionServicio, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidRepDevolucionServicio.DataSource = fachadaCore.consultarDatosRepDevolucionServicio(sql);
cbidRepDevolucionServicio.ValueField = "Id";
cbidRepDevolucionServicio.TextField = "Nombre";
cbidRepDevolucionServicio.DataBind();
cbidElemento.DataSource = fachadaCore.consultarDatosElemento(sql);
cbidElemento.ValueField = "Id";
cbidElemento.TextField = "Nombre";
cbidElemento.DataBind();

        }
        #endregion
    }
}