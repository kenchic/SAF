using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrConductorForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdConductor
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
            if (long.TryParse(Request["IdConductor"], out valor))
                IdConductor = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsConductor.Campos.id, IdConductor, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsConductor.Campos.nombre);

            DataTable Conductor = fachadaCore.consultarDatosConductor(sql);
            flDatos.DataSource = Conductor;
        }
        private void insertarDatos()
        {
            clsConductor Conductor = new clsConductor();
            Conductor.Nombre = txtNombre.Text;
            Conductor.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdConductor == 0)
            {
                resultado = fachadaCore.insertarConductor(Conductor);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsConductor.Campos.id, IdConductor, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarConductor(Conductor, sql);
            }
        }
        #endregion
    }
}