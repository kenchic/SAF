using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrOrdenServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdOrdenServicio
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
            if (long.TryParse(Request["IdOrdenServicio"], out valor))
                IdOrdenServicio = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsOrdenServicio.Campos.id, IdOrdenServicio, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsOrdenServicio.Campos.nombre);

            DataTable OrdenServicio = fachadaCore.consultarDatosOrdenServicio(sql);
            flDatos.DataSource = OrdenServicio;
        }
        private void insertarDatos()
        {
            clsOrdenServicio OrdenServicio = new clsOrdenServicio();
            if (cbidRemision.Value != null)
OrdenServicio.idRemision = (Int32)cbidRemision.Value;
if (cbidProveedor.Value != null)
OrdenServicio.idProveedor = (Int16)cbidProveedor.Value;
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
OrdenServicio.Numero = valorNumero;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdOrdenServicio == 0)
            {
                resultado = fachadaCore.insertarOrdenServicio(OrdenServicio);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsOrdenServicio.Campos.id, IdOrdenServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarOrdenServicio(OrdenServicio, sql);
            }
        }
        #endregion
    }
}