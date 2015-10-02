using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleVentaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleVenta
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

        const string nombreForm = "DetalleVentaForm";
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
            if (long.TryParse(Request["IdDetalleVenta"], out valor))
                IdDetalleVenta = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleVenta.Campos.Id, IdDetalleVenta, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosDetalleVenta(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsDetalleVenta DetalleVenta = new clsDetalleVenta();
            if (cbidElemento.Value != null)
DetalleVenta.idElemento = Convert.ToInt16(cbidElemento.Value);
if (cbidVenta.Value != null)
DetalleVenta.idVenta = Convert.ToInt32(cbidVenta.Value);
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleVenta.Cantidad = valorCantidad;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleVenta == 0)
            {
                resultado = fachadaCore.insertarDetalleVenta(DetalleVenta);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleVenta.Campos.Id, IdDetalleVenta, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleVenta(DetalleVenta, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidElemento.DataSource = fachadaCore.consultarDatosElemento(sql);
cbidElemento.ValueField = "Id";
cbidElemento.TextField = "Nombre";
cbidElemento.DataBind();
cbidVenta.DataSource = fachadaCore.consultarDatosVenta(sql);
cbidVenta.ValueField = "Id";
cbidVenta.TextField = "Nombre";
cbidVenta.DataBind();

        }
        #endregion
    }
}