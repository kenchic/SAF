using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleVentaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleVenta
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
            if (long.TryParse(Request["IdDetalleVenta"], out valor))
                IdDetalleVenta = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleVenta.Campos.id, IdDetalleVenta, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleVenta.Campos.nombre);

            DataTable DetalleVenta = fachadaCore.consultarDatosDetalleVenta(sql);
            flDatos.DataSource = DetalleVenta;
        }
        private void insertarDatos()
        {
            clsDetalleVenta DetalleVenta = new clsDetalleVenta();
            DetalleVenta.Nombre = txtNombre.Text;
            DetalleVenta.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleVenta == 0)
            {
                resultado = fachadaCore.insertarDetalleVenta(DetalleVenta);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleVenta.Campos.id, IdDetalleVenta, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleVenta(DetalleVenta, sql);
            }
        }
        #endregion
    }
}