using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDocumentoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDocumento
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

        const string nombreForm = "DocumentoForm";
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Datos" + nombreForm] = null;
                obtenerQueryString();
                cargarCombos();
                flDatos.DataBind();
            }
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
            if (long.TryParse(Request["IdDocumento"], out valor))
                IdDocumento = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDocumento.Campos.Id, IdDocumento, FiltroBD.OperadorLogico.igual));

            DataTable datos = fachadaCore.consultarDatosDocumento(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private long obtenerSiguienteNumero()
        {
            long resultado = 1;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDocumento.Campos.Id, IdDocumento, FiltroBD.OperadorLogico.igual));

            DataTable datos = fachadaCore.consultarDatosDocumento(sql);

            return resultado;
        }

        public void registarDatos()
        {
            clsDocumento Documento = new clsDocumento();
            if (cbidTipoDocumento.Value != null)
                Documento.idTipoDocumento = Convert.ToByte(cbidTipoDocumento.Value);
            if (txtFecha.Date != DateTime.MinValue)
                Documento.Fecha = txtFecha.Date;
            Documento.Descripcion = txtDescripcion.Text;
            Documento.Anulado = ckAnulado.Checked ? true : false;

            int numero = 0;
            int.TryParse(txtNumero.Text, out numero);
            Documento.Numero = numero;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDocumento == 0)
            {
                resultado = fachadaCore.insertarDocumento(Documento);
                if (resultado > 0)
                    lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDocumento.Campos.Id, IdDocumento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDocumento(Documento, sql);
            }
        }

        private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();

            cbidTipoDocumento.DataSource = fachadaCore.consultarDatosTipoDocumento(sql);
            cbidTipoDocumento.ValueField = "Id";
            cbidTipoDocumento.TextField = "Nombre";
            cbidTipoDocumento.DataBind();

        }
        #endregion
    }
}