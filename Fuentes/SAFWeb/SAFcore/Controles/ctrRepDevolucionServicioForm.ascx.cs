using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrRepDevolucionServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdRepDevolucionServicio
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

        const string nombreForm = "RepDevolucionServicioForm";
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
            if (long.TryParse(Request["IdRepDevolucionServicio"], out valor))
                IdRepDevolucionServicio = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsRepDevolucionServicio.Campos.Id, IdRepDevolucionServicio, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosRepDevolucionServicio(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsRepDevolucionServicio RepDevolucionServicio = new clsRepDevolucionServicio();
            if (cbidDevolucion.Value != null)
RepDevolucionServicio.idDevolucion = Convert.ToInt32(cbidDevolucion.Value);
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
RepDevolucionServicio.Numero = valorNumero;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdRepDevolucionServicio == 0)
            {
                resultado = fachadaCore.insertarRepDevolucionServicio(RepDevolucionServicio);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsRepDevolucionServicio.Campos.Id, IdRepDevolucionServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarRepDevolucionServicio(RepDevolucionServicio, sql);
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

        }
        #endregion
    }
}