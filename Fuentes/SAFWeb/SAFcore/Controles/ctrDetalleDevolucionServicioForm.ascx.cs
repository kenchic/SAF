using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleDevolucionServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleDevolucionServicio
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
            if (long.TryParse(Request["IdDetalleDevolucionServicio"], out valor))
                IdDetalleDevolucionServicio = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleDevolucionServicio.Campos.id, IdDetalleDevolucionServicio, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleDevolucionServicio.Campos.nombre);

            DataTable DetalleDevolucionServicio = fachadaCore.consultarDatosDetalleDevolucionServicio(sql);
            flDatos.DataSource = DetalleDevolucionServicio;
        }
        private void insertarDatos()
        {
            clsDetalleDevolucionServicio DetalleDevolucionServicio = new clsDetalleDevolucionServicio();
            DetalleDevolucionServicio.Nombre = txtNombre.Text;
            DetalleDevolucionServicio.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleDevolucionServicio == 0)
            {
                resultado = fachadaCore.insertarDetalleDevolucionServicio(DetalleDevolucionServicio);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleDevolucionServicio.Campos.id, IdDetalleDevolucionServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleDevolucionServicio(DetalleDevolucionServicio, sql);
            }
        }
        #endregion
    }
}