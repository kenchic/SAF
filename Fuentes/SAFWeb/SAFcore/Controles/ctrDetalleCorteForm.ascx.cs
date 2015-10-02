using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleCorteForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleCorte
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

        const string nombreForm = "DetalleCorteForm";
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
            if (long.TryParse(Request["IdDetalleCorte"], out valor))
                IdDetalleCorte = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleCorte.Campos.Id, IdDetalleCorte, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosDetalleCorte(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsDetalleCorte DetalleCorte = new clsDetalleCorte();
            if (cbidCorte.Value != null)
DetalleCorte.idCorte = Convert.ToInt32(cbidCorte.Value);
if (cbidElemento.Value != null)
DetalleCorte.idElemento = Convert.ToInt16(cbidElemento.Value);
if (cbidRemision.Value != null)
DetalleCorte.idRemision = Convert.ToInt32(cbidRemision.Value);
if (cbidProveedor.Value != null)
DetalleCorte.idProveedor = Convert.ToInt16(cbidProveedor.Value);
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleCorte.Cantidad = valorCantidad;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleCorte == 0)
            {
                resultado = fachadaCore.insertarDetalleCorte(DetalleCorte);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleCorte.Campos.Id, IdDetalleCorte, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleCorte(DetalleCorte, sql);
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
cbidElemento.DataSource = fachadaCore.consultarDatosElemento(sql);
cbidElemento.ValueField = "Id";
cbidElemento.TextField = "Nombre";
cbidElemento.DataBind();
cbidRemision.DataSource = fachadaCore.consultarDatosRemision(sql);
cbidRemision.ValueField = "Id";
cbidRemision.TextField = "Nombre";
cbidRemision.DataBind();
cbidProveedor.DataSource = fachadaCore.consultarDatosProveedor(sql);
cbidProveedor.ValueField = "Id";
cbidProveedor.TextField = "Nombre";
cbidProveedor.DataBind();

        }
        #endregion
    }
}