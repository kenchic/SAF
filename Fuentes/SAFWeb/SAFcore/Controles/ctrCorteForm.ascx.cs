using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrCorteForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdCorte
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

        const string nombreForm = "CorteForm";
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
            if (long.TryParse(Request["IdCorte"], out valor))
                IdCorte = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsCorte.Campos.Id, IdCorte, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosCorte(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsCorte Corte = new clsCorte();
            if (cbidProyectoVenta.Value != null)
Corte.idProyectoVenta = Convert.ToInt16(cbidProyectoVenta.Value);
if (cbidProyectoAlquiler.Value != null)
Corte.idProyectoAlquiler = Convert.ToInt16(cbidProyectoAlquiler.Value);
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
Corte.Numero = valorNumero;
Corte.Fecha = txtFecha.Text;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdCorte == 0)
            {
                resultado = fachadaCore.insertarCorte(Corte);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsCorte.Campos.Id, IdCorte, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarCorte(Corte, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidProyectoVenta.DataSource = fachadaCore.consultarDatosProyectoVenta(sql);
cbidProyectoVenta.ValueField = "Id";
cbidProyectoVenta.TextField = "Nombre";
cbidProyectoVenta.DataBind();
cbidProyectoAlquiler.DataSource = fachadaCore.consultarDatosProyectoAlquiler(sql);
cbidProyectoAlquiler.ValueField = "Id";
cbidProyectoAlquiler.TextField = "Nombre";
cbidProyectoAlquiler.DataBind();

        }
        #endregion
    }
}