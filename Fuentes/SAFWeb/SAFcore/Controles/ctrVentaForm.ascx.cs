using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrVentaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdVenta
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
            if (long.TryParse(Request["IdVenta"], out valor))
                IdVenta = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsVenta.Campos.id, IdVenta, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsVenta.Campos.nombre);

            DataTable Venta = fachadaCore.consultarDatosVenta(sql);
            flDatos.DataSource = Venta;
        }
        private void insertarDatos()
        {
            clsVenta Venta = new clsVenta();
            if (cbidRemision.Value != null)
Venta.idRemision = (Int32)cbidRemision.Value;
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
Venta.Numero = valorNumero;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdVenta == 0)
            {
                resultado = fachadaCore.insertarVenta(Venta);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsVenta.Campos.id, IdVenta, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarVenta(Venta, sql);
            }
        }
        #endregion
    }
}