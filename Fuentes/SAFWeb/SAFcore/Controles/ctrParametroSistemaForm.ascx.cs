using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrParametroSistemaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdParametroSistema
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
            if (long.TryParse(Request["IdParametroSistema"], out valor))
                IdParametroSistema = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsParametroSistema.Campos.id, IdParametroSistema, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsParametroSistema.Campos.nombre);

            DataTable ParametroSistema = fachadaCore.consultarDatosParametroSistema(sql);
            flDatos.DataSource = ParametroSistema;
        }
        private void insertarDatos()
        {
            clsParametroSistema ParametroSistema = new clsParametroSistema();
            ParametroSistema.Nombre = txtNombre.Text;
            ParametroSistema.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdParametroSistema == 0)
            {
                resultado = fachadaCore.insertarParametroSistema(ParametroSistema);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsParametroSistema.Campos.id, IdParametroSistema, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarParametroSistema(ParametroSistema, sql);
            }
        }
        #endregion
    }
}