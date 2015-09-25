using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrContratoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdContrato
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
            if (long.TryParse(Request["IdContrato"], out valor))
                IdContrato = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsContrato.Campos.id, IdContrato, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsContrato.Campos.nombre);

            DataTable Contrato = fachadaCore.consultarDatosContrato(sql);
            flDatos.DataSource = Contrato;
        }
        private void insertarDatos()
        {
            clsContrato Contrato = new clsContrato();
            Contrato.Nombre = txtNombre.Text;
            Contrato.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdContrato == 0)
            {
                resultado = fachadaCore.insertarContrato(Contrato);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsContrato.Campos.id, IdContrato, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarContrato(Contrato, sql);
            }
        }
        #endregion
    }
}