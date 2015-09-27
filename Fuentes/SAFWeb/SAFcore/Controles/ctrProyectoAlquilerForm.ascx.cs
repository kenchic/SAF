using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrProyectoAlquilerForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdProyectoAlquiler
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
            if (long.TryParse(Request["IdProyectoAlquiler"], out valor))
                IdProyectoAlquiler = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsProyectoAlquiler.Campos.id, IdProyectoAlquiler, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsProyectoAlquiler.Campos.nombre);

            DataTable ProyectoAlquiler = fachadaCore.consultarDatosProyectoAlquiler(sql);
            flDatos.DataSource = ProyectoAlquiler;
        }
        private void insertarDatos()
        {
            clsProyectoAlquiler ProyectoAlquiler = new clsProyectoAlquiler();
            if (cbidProyecto.Value != null)
ProyectoAlquiler.idProyecto = (Int16)cbidProyecto.Value;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdProyectoAlquiler == 0)
            {
                resultado = fachadaCore.insertarProyectoAlquiler(ProyectoAlquiler);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsProyectoAlquiler.Campos.id, IdProyectoAlquiler, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarProyectoAlquiler(ProyectoAlquiler, sql);
            }
        }
        #endregion
    }
}