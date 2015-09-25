using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrAgenteForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdAgente
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
            if (long.TryParse(Request["IdAgente"], out valor))
                IdAgente = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsAgente.Campos.id, IdAgente, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsAgente.Campos.nombre);

            DataTable Agente = fachadaCore.consultarDatosAgente(sql);
            flDatos.DataSource = Agente;
        }
        private void insertarDatos()
        {
            clsAgente Agente = new clsAgente();
            Agente.Nombre = txtNombre.Text;
            Agente.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdAgente == 0)
            {
                resultado = fachadaCore.insertarAgente(Agente);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsAgente.Campos.id, IdAgente, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarAgente(Agente, sql);
            }
        }
        #endregion
    }
}