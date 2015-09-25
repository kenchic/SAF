using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleDocumentoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleDocumento
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
            if (long.TryParse(Request["IdDetalleDocumento"], out valor))
                IdDetalleDocumento = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleDocumento.Campos.id, IdDetalleDocumento, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleDocumento.Campos.nombre);

            DataTable DetalleDocumento = fachadaCore.consultarDatosDetalleDocumento(sql);
            flDatos.DataSource = DetalleDocumento;
        }
        private void insertarDatos()
        {
            clsDetalleDocumento DetalleDocumento = new clsDetalleDocumento();
            DetalleDocumento.Nombre = txtNombre.Text;
            DetalleDocumento.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleDocumento == 0)
            {
                resultado = fachadaCore.insertarDetalleDocumento(DetalleDocumento);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleDocumento.Campos.id, IdDetalleDocumento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleDocumento(DetalleDocumento, sql);
            }
        }
        #endregion
    }
}