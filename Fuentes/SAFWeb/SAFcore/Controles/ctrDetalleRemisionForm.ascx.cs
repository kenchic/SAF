using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleRemisionForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleRemision
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
            if (long.TryParse(Request["IdDetalleRemision"], out valor))
                IdDetalleRemision = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleRemision.Campos.id, IdDetalleRemision, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleRemision.Campos.nombre);

            DataTable DetalleRemision = fachadaCore.consultarDatosDetalleRemision(sql);
            flDatos.DataSource = DetalleRemision;
        }
        private void insertarDatos()
        {
            clsDetalleRemision DetalleRemision = new clsDetalleRemision();
            if (cbidRemision.Value != null)
DetalleRemision.idRemision = (Int32)cbidRemision.Value;
if (cbidElemento.Value != null)
DetalleRemision.idElemento = (Int16)cbidElemento.Value;
Int32 valorCantidad = 0;
Int32.TryParse(txtCantidad.Text, out valorCantidad);
DetalleRemision.Cantidad = valorCantidad;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleRemision == 0)
            {
                resultado = fachadaCore.insertarDetalleRemision(DetalleRemision);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleRemision.Campos.id, IdDetalleRemision, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleRemision(DetalleRemision, sql);
            }
        }
        #endregion
    }
}