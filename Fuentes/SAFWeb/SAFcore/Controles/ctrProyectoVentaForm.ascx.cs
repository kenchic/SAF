using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrProyectoVentaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdProyectoVenta
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
            if (long.TryParse(Request["IdProyectoVenta"], out valor))
                IdProyectoVenta = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsProyectoVenta.Campos.id, IdProyectoVenta, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsProyectoVenta.Campos.nombre);

            DataTable ProyectoVenta = fachadaCore.consultarDatosProyectoVenta(sql);
            flDatos.DataSource = ProyectoVenta;
        }
        private void insertarDatos()
        {
            clsProyectoVenta ProyectoVenta = new clsProyectoVenta();
            if (cbidProyecto.Value != null)
ProyectoVenta.idProyecto = (Int16)cbidProyecto.Value;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdProyectoVenta == 0)
            {
                resultado = fachadaCore.insertarProyectoVenta(ProyectoVenta);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsProyectoVenta.Campos.id, IdProyectoVenta, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarProyectoVenta(ProyectoVenta, sql);
            }
        }
        #endregion
    }
}