using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                obtenerQueryString();
                obtenerDatos();
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            insertarDatos();
        }
        #endregion

        #region Metodos
        private void obtenerQueryString()
        {
            long valor = 0;
            if (long.TryParse(Request["IdDetalleListaPrecio"], out valor))
                IdDetalleListaPrecio = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleListaPrecio.Campos.id, IdDetalleListaPrecio, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleListaPrecio.Campos.nombre);

            DataTable DetalleListaPrecio = fachadaCore.consultarDatosDetalleListaPrecio(sql);
            flDatos.DataSource = DetalleListaPrecio;
        }
        private void insertarDatos()
        {
            clsDetalleListaPrecio DetalleListaPrecio = new clsDetalleListaPrecio();
            if (cbidListaPrecios.Value != null)
DetalleListaPrecio.idListaPrecios = (Byte)cbidListaPrecios.Value;
if (cbidElemento.Value != null)
DetalleListaPrecio.idElemento = (Int16)cbidElemento.Value;
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
                sql.FiltroBD.Add(new FiltroBD(clsDetalleListaPrecio.Campos.id, IdDetalleListaPrecio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleListaPrecio(DetalleListaPrecio, sql);
            }
        }
        #endregion
    }
}