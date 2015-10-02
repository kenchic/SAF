using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrParametroSistemaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdParametroSistema
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

        const string nombreForm = "ParametroSistemaForm";
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
            if (long.TryParse(Request["IdParametroSistema"], out valor))
                IdParametroSistema = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsParametroSistema.Campos.Id, IdParametroSistema, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosParametroSistema(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsParametroSistema ParametroSistema = new clsParametroSistema();
            ParametroSistema.Codigo = txtCodigo.Text;
if (cbidParametro.Value != null)
ParametroSistema.idParametro = Convert.ToInt16(cbidParametro.Value);
ParametroSistema.Valor = txtValor.Text;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdParametroSistema == 0)
            {
                resultado = fachadaCore.insertarParametroSistema(ParametroSistema);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsParametroSistema.Campos.Id, IdParametroSistema, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarParametroSistema(ParametroSistema, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidParametro.DataSource = fachadaCore.consultarDatosParametro(sql);
cbidParametro.ValueField = "Id";
cbidParametro.TextField = "Nombre";
cbidParametro.DataBind();

        }
        #endregion
    }
}