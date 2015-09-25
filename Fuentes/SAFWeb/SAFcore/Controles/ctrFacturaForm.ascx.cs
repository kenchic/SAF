using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrFacturaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdFactura
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
            if (long.TryParse(Request["IdFactura"], out valor))
                IdFactura = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsFactura.Campos.id, IdFactura, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsFactura.Campos.nombre);

            DataTable Factura = fachadaCore.consultarDatosFactura(sql);
            flDatos.DataSource = Factura;
        }
        private void insertarDatos()
        {
            clsFactura Factura = new clsFactura();
            Factura.Nombre = txtNombre.Text;
            Factura.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdFactura == 0)
            {
                resultado = fachadaCore.insertarFactura(Factura);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsFactura.Campos.id, IdFactura, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarFactura(Factura, sql);
            }
        }
        #endregion
    }
}