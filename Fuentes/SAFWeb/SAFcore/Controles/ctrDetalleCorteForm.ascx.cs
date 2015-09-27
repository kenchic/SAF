using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleCorteForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleCorte
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
            if (long.TryParse(Request["IdDetalleCorte"], out valor))
                IdDetalleCorte = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleCorte.Campos.id, IdDetalleCorte, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleCorte.Campos.nombre);

            DataTable DetalleCorte = fachadaCore.consultarDatosDetalleCorte(sql);
            flDatos.DataSource = DetalleCorte;
        }
        private void insertarDatos()
        {
            clsDetalleCorte DetalleCorte = new clsDetalleCorte();
            if (cbidCorte.Value != null)
DetalleCorte.idCorte = (Int32)cbidCorte.Value;
if (cbidElemento.Value != null)
DetalleCorte.idElemento = (Int16)cbidElemento.Value;
if (cbidRemision.Value != null)
DetalleCorte.idRemision = (Int32)cbidRemision.Value;
if (cbidProveedor.Value != null)
DetalleCorte.idProveedor = (Int16)cbidProveedor.Value;
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleCorte.Cantidad = valorCantidad;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleCorte == 0)
            {
                resultado = fachadaCore.insertarDetalleCorte(DetalleCorte);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleCorte.Campos.id, IdDetalleCorte, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleCorte(DetalleCorte, sql);
            }
        }
        #endregion
    }
}