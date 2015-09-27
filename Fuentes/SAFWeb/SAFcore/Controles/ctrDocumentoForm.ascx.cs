using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                obtenerQueryString();
                obtenerDatos();
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            insertarDatos();
        }
        #endregion

        #region Metodos
        private void obtenerQueryString()
        {
            long valor = 0;
            if (long.TryParse(Request["IdDocumento"], out valor))
                IdDocumento = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDocumento.Campos.id, IdDocumento, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDocumento.Campos.nombre);

            DataTable Documento = fachadaCore.consultarDatosDocumento(sql);
            flDatos.DataSource = Documento;
        }
        private void insertarDatos()
        {
            clsDocumento Documento = new clsDocumento();
            if (cbidTipoDocumento.Value != null)
Documento.idTipoDocumento = (Byte)cbidTipoDocumento.Value;
Documento.Fecha = txtFecha.Text;
Documento.Descripcion = txtDescripcion.Text;
Documento.Anulado = ckAnulado.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDocumento == 0)
            {
                resultado = fachadaCore.insertarDocumento(Documento);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDocumento.Campos.id, IdDocumento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDocumento(Documento, sql);
            }
        }
        #endregion
    }
}