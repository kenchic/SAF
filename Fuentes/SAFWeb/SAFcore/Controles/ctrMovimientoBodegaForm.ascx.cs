using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

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

        const string nombreForm = "MovimientoBodegaForm";
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
            if (long.TryParse(Request["IdMovimientoBodega"], out valor))
                IdMovimientoBodega = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsMovimientoBodega.Campos.Id, IdMovimientoBodega, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosMovimientoBodega(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsMovimientoBodega MovimientoBodega = new clsMovimientoBodega();
            if (cbidElemeto.Value != null)
MovimientoBodega.idElemeto = Convert.ToInt16(cbidElemeto.Value);
if (cbidBodegaOrigen.Value != null)
MovimientoBodega.idBodegaOrigen = Convert.ToByte(cbidBodegaOrigen.Value);
if (cbidBodegaDestino.Value != null)
MovimientoBodega.idBodegaDestino = Convert.ToByte(cbidBodegaDestino.Value);
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
                sql.FiltroBD.Add(new FiltroBD(clsMovimientoBodega.Campos.Id, IdMovimientoBodega, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarMovimientoBodega(MovimientoBodega, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidElemeto.DataSource = fachadaCore.consultarDatosElemeto(sql);
cbidElemeto.ValueField = "Id";
cbidElemeto.TextField = "Nombre";
cbidElemeto.DataBind();
cbidBodegaOrigen.DataSource = fachadaCore.consultarDatosBodegaOrigen(sql);
cbidBodegaOrigen.ValueField = "Id";
cbidBodegaOrigen.TextField = "Nombre";
cbidBodegaOrigen.DataBind();
cbidBodegaDestino.DataSource = fachadaCore.consultarDatosBodegaDestino(sql);
cbidBodegaDestino.ValueField = "Id";
cbidBodegaDestino.TextField = "Nombre";
cbidBodegaDestino.DataBind();

        }
        #endregion
    }
}