using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleListaPrecioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleListaPrecio
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

        const string nombreForm = "DetalleListaPrecioForm";
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
            if (long.TryParse(Request["IdDetalleListaPrecio"], out valor))
                IdDetalleListaPrecio = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleListaPrecio.Campos.Id, IdDetalleListaPrecio, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosDetalleListaPrecio(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsDetalleListaPrecio DetalleListaPrecio = new clsDetalleListaPrecio();
            if (cbidListaPrecios.Value != null)
DetalleListaPrecio.idListaPrecios = Convert.ToByte(cbidListaPrecios.Value);
if (cbidElemento.Value != null)
DetalleListaPrecio.idElemento = Convert.ToInt16(cbidElemento.Value);
Int32 valorPrecioAlquiler = 0;
Int32.TryParse(txtPrecioAlquiler.Text, out valorPrecioAlquiler);
DetalleListaPrecio.PrecioAlquiler = valorPrecioAlquiler;
Int32 valorPrecioVenta = 0;
Int32.TryParse(txtPrecioVenta.Text, out valorPrecioVenta);
DetalleListaPrecio.PrecioVenta = valorPrecioVenta;
Int32 valorPrecioPerdida = 0;
Int32.TryParse(txtPrecioPerdida.Text, out valorPrecioPerdida);
DetalleListaPrecio.PrecioPerdida = valorPrecioPerdida;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleListaPrecio == 0)
            {
                resultado = fachadaCore.insertarDetalleListaPrecio(DetalleListaPrecio);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleListaPrecio.Campos.Id, IdDetalleListaPrecio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleListaPrecio(DetalleListaPrecio, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidListaPrecios.DataSource = fachadaCore.consultarDatosListaPrecios(sql);
cbidListaPrecios.ValueField = "Id";
cbidListaPrecios.TextField = "Nombre";
cbidListaPrecios.DataBind();
cbidElemento.DataSource = fachadaCore.consultarDatosElemento(sql);
cbidElemento.ValueField = "Id";
cbidElemento.TextField = "Nombre";
cbidElemento.DataBind();

        }
        #endregion
    }
}