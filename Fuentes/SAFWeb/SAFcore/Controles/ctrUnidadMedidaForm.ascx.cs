using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrUnidadMedidaForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdUnidadMedida
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
            if (long.TryParse(Request["IdUnidadMedida"], out valor))
                IdUnidadMedida = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsUnidadMedida.Campos.id, IdUnidadMedida, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsUnidadMedida.Campos.nombre);

            DataTable UnidadMedida = fachadaCore.consultarDatosUnidadMedida(sql);
            flDatos.DataSource = UnidadMedida;
        }
        private void insertarDatos()
        {
            clsUnidadMedida UnidadMedida = new clsUnidadMedida();
            UnidadMedida.Nombre = txtNombre.Text;
            UnidadMedida.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdUnidadMedida == 0)
            {
                resultado = fachadaCore.insertarUnidadMedida(UnidadMedida);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsUnidadMedida.Campos.id, IdUnidadMedida, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarUnidadMedida(UnidadMedida, sql);
            }
        }
        #endregion
    }
}