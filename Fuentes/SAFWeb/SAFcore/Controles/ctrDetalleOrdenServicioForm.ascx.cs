using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleOrdenServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleOrdenServicio
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
            if (long.TryParse(Request["IdDetalleOrdenServicio"], out valor))
                IdDetalleOrdenServicio = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleOrdenServicio.Campos.id, IdDetalleOrdenServicio, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleOrdenServicio.Campos.nombre);

            DataTable DetalleOrdenServicio = fachadaCore.consultarDatosDetalleOrdenServicio(sql);
            flDatos.DataSource = DetalleOrdenServicio;
        }
        private void insertarDatos()
        {
            clsDetalleOrdenServicio DetalleOrdenServicio = new clsDetalleOrdenServicio();
            if (cbidOrdenServicio.Value != null)
DetalleOrdenServicio.idOrdenServicio = (Int32)cbidOrdenServicio.Value;
if (cbidElemento.Value != null)
DetalleOrdenServicio.idElemento = (Int16)cbidElemento.Value;
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleOrdenServicio.Cantidad = valorCantidad;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleOrdenServicio == 0)
            {
                resultado = fachadaCore.insertarDetalleOrdenServicio(DetalleOrdenServicio);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleOrdenServicio.Campos.id, IdDetalleOrdenServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleOrdenServicio(DetalleOrdenServicio, sql);
            }
        }
        #endregion
    }
}