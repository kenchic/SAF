using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrFacturaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdFactura
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
            if (long.TryParse(Request["IdFactura"], out valor))
                IdFactura = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsFactura.Campos.id, IdFactura, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsFactura.Campos.nombre);

            DataTable Factura = fachadaCore.consultarDatosFactura(sql);
            flDatos.DataSource = Factura;
        }
        private void insertarDatos()
        {
            clsFactura Factura = new clsFactura();
            if (cbidCorte.Value != null)
Factura.idCorte = (Int32)cbidCorte.Value;
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
Factura.Numero = valorNumero;
Factura.FechaEmision = txtFechaEmision.Text;
Factura.FechaVencimiento = txtFechaVencimiento.Text;
Factura.Son = txtSon.Text;
Decimal valorParcialTotal = 0;
Decimal.TryParse(txtParcialTotal.Text, out valorParcialTotal);
Factura.ParcialTotal = valorParcialTotal;
Factura.Dcto = txtDcto.Text;
Decimal valorSubTotal = 0;
Decimal.TryParse(txtSubTotal.Text, out valorSubTotal);
Factura.SubTotal = valorSubTotal;
Factura.Iva = txtIva.Text;
Decimal valorTotal = 0;
Decimal.TryParse(txtTotal.Text, out valorTotal);
Factura.Total = valorTotal;
Factura.Anulada = ckAnulada.Checked ? true : false;
if (cbidTipoFactura.Value != null)
Factura.idTipoFactura = (Byte)cbidTipoFactura.Value;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdFactura == 0)
            {
                resultado = fachadaCore.insertarFactura(Factura);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsFactura.Campos.id, IdFactura, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarFactura(Factura, sql);
            }
        }
        #endregion
    }
}