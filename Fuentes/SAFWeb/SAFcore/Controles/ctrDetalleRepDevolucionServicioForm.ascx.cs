using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleRepDevolucionServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleRepDevolucionServicio
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
            if (long.TryParse(Request["IdDetalleRepDevolucionServicio"], out valor))
                IdDetalleRepDevolucionServicio = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleRepDevolucionServicio.Campos.id, IdDetalleRepDevolucionServicio, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleRepDevolucionServicio.Campos.nombre);

            DataTable DetalleRepDevolucionServicio = fachadaCore.consultarDatosDetalleRepDevolucionServicio(sql);
            flDatos.DataSource = DetalleRepDevolucionServicio;
        }
        private void insertarDatos()
        {
            clsDetalleRepDevolucionServicio DetalleRepDevolucionServicio = new clsDetalleRepDevolucionServicio();
            if (cbidRepDevolucionServicio.Value != null)
DetalleRepDevolucionServicio.idRepDevolucionServicio = (Int32)cbidRepDevolucionServicio.Value;
if (cbidElemento.Value != null)
DetalleRepDevolucionServicio.idElemento = (Int16)cbidElemento.Value;
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleRepDevolucionServicio.Cantidad = valorCantidad;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleRepDevolucionServicio == 0)
            {
                resultado = fachadaCore.insertarDetalleRepDevolucionServicio(DetalleRepDevolucionServicio);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleRepDevolucionServicio.Campos.id, IdDetalleRepDevolucionServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleRepDevolucionServicio(DetalleRepDevolucionServicio, sql);
            }
        }
        #endregion
    }
}