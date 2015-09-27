using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrMovimientoBodegaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdMovimientoBodega
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
            if (long.TryParse(Request["IdMovimientoBodega"], out valor))
                IdMovimientoBodega = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsMovimientoBodega.Campos.id, IdMovimientoBodega, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsMovimientoBodega.Campos.nombre);

            DataTable MovimientoBodega = fachadaCore.consultarDatosMovimientoBodega(sql);
            flDatos.DataSource = MovimientoBodega;
        }
        private void insertarDatos()
        {
            clsMovimientoBodega MovimientoBodega = new clsMovimientoBodega();
            if (cbidElemeto.Value != null)
MovimientoBodega.idElemeto = (Int16)cbidElemeto.Value;
if (cbidBodegaOrigen.Value != null)
MovimientoBodega.idBodegaOrigen = (Byte)cbidBodegaOrigen.Value;
if (cbidBodegaDestino.Value != null)
MovimientoBodega.idBodegaDestino = (Byte)cbidBodegaDestino.Value;
MovimientoBodega.Documento = txtDocumento.Text;
MovimientoBodega.Numero = txtNumero.Text;
MovimientoBodega.Operacion = txtOperacion.Text;
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
MovimientoBodega.Cantidad = valorCantidad;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdMovimientoBodega == 0)
            {
                resultado = fachadaCore.insertarMovimientoBodega(MovimientoBodega);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsMovimientoBodega.Campos.id, IdMovimientoBodega, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarMovimientoBodega(MovimientoBodega, sql);
            }
        }
        #endregion
    }
}