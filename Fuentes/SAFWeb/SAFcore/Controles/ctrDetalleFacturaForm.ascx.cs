using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

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

        const string nombreForm = "DetalleFacturaForm";
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
            if (long.TryParse(Request["IdDetalleFactura"], out valor))
                IdDetalleFactura = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleFactura.Campos.Id, IdDetalleFactura, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosDetalleFactura(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsDetalleFactura DetalleFactura = new clsDetalleFactura();
            if (cbidElemento.Value != null)
DetalleFactura.idElemento = Convert.ToInt16(cbidElemento.Value);
if (cbidFactura.Value != null)
DetalleFactura.idFactura = Convert.ToInt32(cbidFactura.Value);
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
                sql.FiltroBD.Add(new FiltroBD(clsDetalleFactura.Campos.Id, IdDetalleFactura, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleFactura(DetalleFactura, sql);
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
cbidFactura.DataSource = fachadaCore.consultarDatosFactura(sql);
cbidFactura.ValueField = "Id";
cbidFactura.TextField = "Nombre";
cbidFactura.DataBind();

        }
        #endregion
    }
}