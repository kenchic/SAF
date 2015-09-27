using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleMantenimientoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleMantenimiento
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
            if (long.TryParse(Request["IdDetalleMantenimiento"], out valor))
                IdDetalleMantenimiento = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleMantenimiento.Campos.id, IdDetalleMantenimiento, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleMantenimiento.Campos.nombre);

            DataTable DetalleMantenimiento = fachadaCore.consultarDatosDetalleMantenimiento(sql);
            flDatos.DataSource = DetalleMantenimiento;
        }
        private void insertarDatos()
        {
            clsDetalleMantenimiento DetalleMantenimiento = new clsDetalleMantenimiento();
            if (cbidMantenimiento.Value != null)
DetalleMantenimiento.idMantenimiento = (Int32)cbidMantenimiento.Value;
if (cbidElemento.Value != null)
DetalleMantenimiento.idElemento = (Int16)cbidElemento.Value;
Int16 valorTipoMantenimiento = 0;
Int16.TryParse(txtTipoMantenimiento.Text, out valorTipoMantenimiento);
DetalleMantenimiento.TipoMantenimiento = valorTipoMantenimiento;
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleMantenimiento.Cantidad = valorCantidad;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleMantenimiento == 0)
            {
                resultado = fachadaCore.insertarDetalleMantenimiento(DetalleMantenimiento);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleMantenimiento.Campos.id, IdDetalleMantenimiento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleMantenimiento(DetalleMantenimiento, sql);
            }
        }
        #endregion
    }
}