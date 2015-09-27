using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrReposicionForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdReposicion
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
            if (long.TryParse(Request["IdReposicion"], out valor))
                IdReposicion = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsReposicion.Campos.id, IdReposicion, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsReposicion.Campos.nombre);

            DataTable Reposicion = fachadaCore.consultarDatosReposicion(sql);
            flDatos.DataSource = Reposicion;
        }
        private void insertarDatos()
        {
            clsReposicion Reposicion = new clsReposicion();
            if (cbidDevolucion.Value != null)
Reposicion.idDevolucion = (Int32)cbidDevolucion.Value;
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
Reposicion.Numero = valorNumero;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdReposicion == 0)
            {
                resultado = fachadaCore.insertarReposicion(Reposicion);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsReposicion.Campos.id, IdReposicion, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarReposicion(Reposicion, sql);
            }
        }
        #endregion
    }
}