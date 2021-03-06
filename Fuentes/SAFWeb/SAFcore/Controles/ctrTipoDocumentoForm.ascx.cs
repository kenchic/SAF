using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrTipoDocumentoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdTipoDocumento
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

        const string nombreForm = "TipoDocumentoForm";
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
            if (long.TryParse(Request["IdTipoDocumento"], out valor))
                IdTipoDocumento = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsTipoDocumento.Campos.Id, IdTipoDocumento, FiltroBD.OperadorLogico.igual));

            DataTable datos = fachadaCore.consultarDatosTipoDocumento(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        public void registarDatos()
        {
            clsTipoDocumento TipoDocumento = new clsTipoDocumento();
            TipoDocumento.Nombre = txtNombre.Text;
            Int64 valorConsecutivo = 0;
            Int64.TryParse(txtConsecutivo.Text, out valorConsecutivo);
            TipoDocumento.Consecutivo = valorConsecutivo;
            TipoDocumento.Activo = ckActivo.Checked ? true : false;
            TipoDocumento.Operacion = txtOperacion.Text;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdTipoDocumento == 0)
            {
                resultado = fachadaCore.insertarTipoDocumento(TipoDocumento);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsTipoDocumento.Campos.Id, IdTipoDocumento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarTipoDocumento(TipoDocumento, sql);
            }
        }
       
        #endregion
    }
}