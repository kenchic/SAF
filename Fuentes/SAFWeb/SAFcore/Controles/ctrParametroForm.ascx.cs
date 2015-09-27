using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrParametroForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdParametro
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
            if (long.TryParse(Request["IdParametro"], out valor))
                IdParametro = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsParametro.Campos.id, IdParametro, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsParametro.Campos.nombre);

            DataTable Parametro = fachadaCore.consultarDatosParametro(sql);
            flDatos.DataSource = Parametro;
        }
        private void insertarDatos()
        {
            clsParametro Parametro = new clsParametro();
            Parametro.Nombre = txtNombre.Text;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdParametro == 0)
            {
                resultado = fachadaCore.insertarParametro(Parametro);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsParametro.Campos.id, IdParametro, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarParametro(Parametro, sql);
            }
        }
        #endregion
    }
}