using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrRemisionForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdRemision
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
            if (long.TryParse(Request["IdRemision"], out valor))
                IdRemision = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsRemision.Campos.id, IdRemision, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsRemision.Campos.nombre);

            DataTable Remision = fachadaCore.consultarDatosRemision(sql);
            flDatos.DataSource = Remision;
        }
        private void insertarDatos()
        {
            clsRemision Remision = new clsRemision();
            Remision.Nombre = txtNombre.Text;
            Remision.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdRemision == 0)
            {
                resultado = fachadaCore.insertarRemision(Remision);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsRemision.Campos.id, IdRemision, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarRemision(Remision, sql);
            }
        }
        #endregion
    }
}