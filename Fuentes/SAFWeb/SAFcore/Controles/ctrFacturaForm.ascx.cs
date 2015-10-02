using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

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

        const string nombreForm = "FacturaForm";
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
            if (long.TryParse(Request["IdFactura"], out valor))
                IdFactura = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsFactura.Campos.Id, IdFactura, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosFactura(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsFactura Factura = new clsFactura();
            if (cbidCorte.Value != null)
Factura.idCorte = Convert.ToInt32(cbidCorte.Value);
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
Factura.idTipoFactura = Convert.ToByte(cbidTipoFactura.Value);


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
                sql.FiltroBD.Add(new FiltroBD(clsFactura.Campos.Id, IdFactura, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarFactura(Factura, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidCorte.DataSource = fachadaCore.consultarDatosCorte(sql);
cbidCorte.ValueField = "Id";
cbidCorte.TextField = "Nombre";
cbidCorte.DataBind();
cbidTipoFactura.DataSource = fachadaCore.consultarDatosTipoFactura(sql);
cbidTipoFactura.ValueField = "Id";
cbidTipoFactura.TextField = "Nombre";
cbidTipoFactura.DataBind();

        }
        #endregion
    }
}