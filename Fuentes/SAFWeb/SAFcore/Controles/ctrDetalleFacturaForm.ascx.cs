using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleFacturaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleFactura
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
            if (long.TryParse(Request["IdDetalleFactura"], out valor))
                IdDetalleFactura = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleFactura.Campos.id, IdDetalleFactura, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleFactura.Campos.nombre);

            DataTable DetalleFactura = fachadaCore.consultarDatosDetalleFactura(sql);
            flDatos.DataSource = DetalleFactura;
        }
        private void insertarDatos()
        {
            clsDetalleFactura DetalleFactura = new clsDetalleFactura();
            if (cbidElemento.Value != null)
DetalleFactura.idElemento = (Int16)cbidElemento.Value;
if (cbidFactura.Value != null)
DetalleFactura.idFactura = (Int32)cbidFactura.Value;
DetalleFactura.Detalle = txtDetalle.Text;
DetalleFactura.Dias = txtDias.Text;
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleFactura.Cantidad = valorCantidad;
Int32 valorValor = 0;
Int32.TryParse(txtValor.Text, out valorValor);
DetalleFactura.Valor = valorValor;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleFactura == 0)
            {
                resultado = fachadaCore.insertarDetalleFactura(DetalleFactura);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleFactura.Campos.id, IdDetalleFactura, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleFactura(DetalleFactura, sql);
            }
        }
        #endregion
    }
}