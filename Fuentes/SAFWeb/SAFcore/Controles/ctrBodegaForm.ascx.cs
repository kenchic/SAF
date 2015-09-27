using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrBodegaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdBodega
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
            if (long.TryParse(Request["IdBodega"], out valor))
                IdBodega = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsBodega.Campos.id, IdBodega, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsBodega.Campos.nombre);

            DataTable Bodega = fachadaCore.consultarDatosBodega(sql);
            flDatos.DataSource = Bodega;
        }
        private void insertarDatos()
        {
            clsBodega Bodega = new clsBodega();
            Bodega.Nombre = txtNombre.Text;
Bodega.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdBodega == 0)
            {
                resultado = fachadaCore.insertarBodega(Bodega);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsBodega.Campos.id, IdBodega, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarBodega(Bodega, sql);
            }
        }
        #endregion
    }
}