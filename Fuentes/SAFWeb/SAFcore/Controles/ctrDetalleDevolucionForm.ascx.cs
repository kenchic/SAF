using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleDevolucionForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleDevolucion
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
            if (long.TryParse(Request["IdDetalleDevolucion"], out valor))
                IdDetalleDevolucion = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleDevolucion.Campos.id, IdDetalleDevolucion, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleDevolucion.Campos.nombre);

            DataTable DetalleDevolucion = fachadaCore.consultarDatosDetalleDevolucion(sql);
            flDatos.DataSource = DetalleDevolucion;
        }
        private void insertarDatos()
        {
            clsDetalleDevolucion DetalleDevolucion = new clsDetalleDevolucion();
            if (cbidDevolucion.Value != null)
DetalleDevolucion.idDevolucion = (Int32)cbidDevolucion.Value;
if (cbidElemento.Value != null)
DetalleDevolucion.idElemento = (Int16)cbidElemento.Value;
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleDevolucion.Cantidad = valorCantidad;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleDevolucion == 0)
            {
                resultado = fachadaCore.insertarDetalleDevolucion(DetalleDevolucion);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleDevolucion.Campos.id, IdDetalleDevolucion, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleDevolucion(DetalleDevolucion, sql);
            }
        }
        #endregion
    }
}