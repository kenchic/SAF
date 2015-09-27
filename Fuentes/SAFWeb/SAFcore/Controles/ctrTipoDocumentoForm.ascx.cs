using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            if (long.TryParse(Request["IdTipoDocumento"], out valor))
                IdTipoDocumento = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsTipoDocumento.Campos.id, IdTipoDocumento, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsTipoDocumento.Campos.nombre);

            DataTable TipoDocumento = fachadaCore.consultarDatosTipoDocumento(sql);
            flDatos.DataSource = TipoDocumento;
        }
        private void insertarDatos()
        {
            clsTipoDocumento TipoDocumento = new clsTipoDocumento();
            TipoDocumento.Nombre = txtNombre.Text;
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
                sql.FiltroBD.Add(new FiltroBD(clsTipoDocumento.Campos.id, IdTipoDocumento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarTipoDocumento(TipoDocumento, sql);
            }
        }
        #endregion
    }
}