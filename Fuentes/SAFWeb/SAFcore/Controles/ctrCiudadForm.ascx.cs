using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrCiudadForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdCiudad
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
            if (long.TryParse(Request["IdCiudad"], out valor))
                IdCiudad = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsCiudad.Campos.id, IdCiudad, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsCiudad.Campos.nombre);

            DataTable Ciudad = fachadaCore.consultarDatosCiudad(sql);
            flDatos.DataSource = Ciudad;
        }
        private void insertarDatos()
        {
            clsCiudad Ciudad = new clsCiudad();
            Ciudad.Nombre = txtNombre.Text;
            Ciudad.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdCiudad == 0)
            {
                resultado = fachadaCore.insertarCiudad(Ciudad);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsCiudad.Campos.id, IdCiudad, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarCiudad(Ciudad, sql);
            }
        }
        #endregion
    }
}