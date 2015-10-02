using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDevolucionServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDevolucionServicio
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

        const string nombreForm = "DevolucionServicioForm";
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
            if (long.TryParse(Request["IdDevolucionServicio"], out valor))
                IdDevolucionServicio = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDevolucionServicio.Campos.Id, IdDevolucionServicio, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosDevolucionServicio(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsDevolucionServicio DevolucionServicio = new clsDevolucionServicio();
            if (cbidDevolucion.Value != null)
DevolucionServicio.idDevolucion = Convert.ToInt32(cbidDevolucion.Value);
if (cbidProveedor.Value != null)
DevolucionServicio.idProveedor = Convert.ToInt16(cbidProveedor.Value);
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
DevolucionServicio.Numero = valorNumero;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDevolucionServicio == 0)
            {
                resultado = fachadaCore.insertarDevolucionServicio(DevolucionServicio);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDevolucionServicio.Campos.Id, IdDevolucionServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDevolucionServicio(DevolucionServicio, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidDevolucion.DataSource = fachadaCore.consultarDatosDevolucion(sql);
cbidDevolucion.ValueField = "Id";
cbidDevolucion.TextField = "Nombre";
cbidDevolucion.DataBind();
cbidProveedor.DataSource = fachadaCore.consultarDatosProveedor(sql);
cbidProveedor.ValueField = "Id";
cbidProveedor.TextField = "Nombre";
cbidProveedor.DataBind();

        }
        #endregion
    }
}