using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

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

        const string nombreForm = "ProyectoVentaForm";
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Datos" + nombreForm] = null;
                obtenerQueryString();
                flDatos.DataBind();
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            registarDatos();
        }

        protected void flDatos_DataBinding(object sender, EventArgs e)
        {
            ASPxFormLayout form = sender as ASPxFormLayout;
            if (Session["Datos" + nombreForm] == null)
                form.DataSource = obtenerDatos();
            else
                form.DataSource = Session["Datos" + nombreForm];
        }
        #endregion

        #region Metodos
        private void obtenerQueryString()
        {
            long valor = 0;
            if (long.TryParse(Request["IdProyectoVenta"], out valor))
                IdProyectoVenta = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsProyectoVenta.Campos.Id, IdProyectoVenta, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosProyectoVenta(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsProyectoVenta ProyectoVenta = new clsProyectoVenta();
            if (cbidProyecto.Value != null)
ProyectoVenta.idProyecto = Convert.ToInt16(cbidProyecto.Value);


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
                sql.FiltroBD.Add(new FiltroBD(clsProyectoVenta.Campos.Id, IdProyectoVenta, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarProyectoVenta(ProyectoVenta, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidProyecto.DataSource = fachadaCore.consultarDatosProyecto(sql);
cbidProyecto.ValueField = "Id";
cbidProyecto.TextField = "Nombre";
cbidProyecto.DataBind();

        }
        #endregion
    }
}