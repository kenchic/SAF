using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleFacturaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDetalleFactura
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
            if (long.TryParse(Request["IdDetalleFactura"], out valor))
                IdDetalleFactura = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleFactura.Campos.id, IdDetalleFactura, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDetalleFactura.Campos.nombre);

            DataTable DetalleFactura = fachadaCore.consultarDatosDetalleFactura(sql);
            flDatos.DataSource = DetalleFactura;
        }
        private void insertarDatos()
        {
            clsDetalleFactura DetalleFactura = new clsDetalleFactura();
            DetalleFactura.Nombre = txtNombre.Text;
            DetalleFactura.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDetalleFactura == 0)
            {
                resultado = fachadaCore.insertarDetalleFactura(DetalleFactura);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDetalleFactura.Campos.id, IdDetalleFactura, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDetalleFactura(DetalleFactura, sql);
            }
        }
        #endregion
    }
}