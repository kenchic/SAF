using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleReposicionForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleReposicion
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
            if (long.TryParse(Request["IdDetalleReposicion"], out valor))
                IdDetalleReposicion = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleReposicion.Campos.id, IdDetalleReposicion, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleReposicion.Campos.nombre);

            DataTable DetalleReposicion = fachadaCore.consultarDatosDetalleReposicion(sql);
            flDatos.DataSource = DetalleReposicion;
        }
        private void insertarDatos()
        {
            clsDetalleReposicion DetalleReposicion = new clsDetalleReposicion();
            DetalleReposicion.Nombre = txtNombre.Text;
            DetalleReposicion.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleReposicion == 0)
            {
                resultado = fachadaCore.insertarDetalleReposicion(DetalleReposicion);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleReposicion.Campos.id, IdDetalleReposicion, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleReposicion(DetalleReposicion, sql);
            }
        }
        #endregion
    }
}