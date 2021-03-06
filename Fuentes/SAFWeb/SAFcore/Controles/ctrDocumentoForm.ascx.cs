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

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDocumento == 0)
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsTipoDocumento.Campos.Id, Documento.idTipoDocumento, FiltroBD.OperadorLogico.igual));
                clsTipoDocumento tipoDocumento = fachadaCore.consultarEntidadTipoDocumento(sql);

                int numero = 0;
                int.TryParse(tipoDocumento.Consecutivo.ToString(), out numero);
                Documento.Numero = numero;
               
                resultado = fachadaCore.insertarDocumento(Documento);
                if (resultado > 0)
                {
                    txtNumero.Text = Documento.Numero.ToString();
                    lbId.Text = resultado.ToString();

                    tipoDocumento.Id = null;
                    tipoDocumento.Consecutivo += 1;
                    resultado = fachadaCore.editarTipoDocumento(tipoDocumento, sql);
                }
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
            sql.FiltroBD.Add(new FiltroBD(clsTipoDocumento.Campos.Id, IdDocumento, FiltroBD.OperadorLogico.igual));
            sql.FiltroBD.Add(new FiltroBD(clsTipoDocumento.Campos.Activo, true, FiltroBD.OperadorLogico.igual));

            cbidTipoDocumento.DataSource = fachadaCore.consultarDatosTipoDocumento(sql);
            cbidTipoDocumento.ValueField = "Id";
            cbidTipoDocumento.TextField = "Nombre";
            cbidTipoDocumento.DataBind();

            txtFecha.Date = DateTime.Now;

        }
        #endregion
    }
}