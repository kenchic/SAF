using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrProyectoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdProyecto
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
            if (long.TryParse(Request["IdProyecto"], out valor))
                IdProyecto = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsProyecto.Campos.id, IdProyecto, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsProyecto.Campos.nombre);

            DataTable Proyecto = fachadaCore.consultarDatosProyecto(sql);
            flDatos.DataSource = Proyecto;
        }
        private void insertarDatos()
        {
            clsProyecto Proyecto = new clsProyecto();
            Proyecto.Nombre = txtNombre.Text;
            Proyecto.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdProyecto == 0)
            {
                resultado = fachadaCore.insertarProyecto(Proyecto);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsProyecto.Campos.id, IdProyecto, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarProyecto(Proyecto, sql);
            }
        }
        #endregion
    }
}