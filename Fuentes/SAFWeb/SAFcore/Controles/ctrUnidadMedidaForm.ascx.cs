using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

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

        const string nombreForm = "UnidadMedidaForm";
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Datos" + nombreForm] = null;
                obtenerQueryString();
                flDatos.DataBind();
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            registarDatos();
        }

        protected void flDatos_DataBinding(object sender, EventArgs e)
        {
            ASPxFormLayout form = sender as ASPxFormLayout;
            if (Session["Datos" + nombreForm] == null)
                form.DataSource = obtenerDatos();
            else
                form.DataSource = Session["Datos" + nombreForm];
        }
        #endregion

        #region Metodos
        private void obtenerQueryString()
        {
            long valor = 0;
            if (long.TryParse(Request["IdUnidadMedida"], out valor))
                IdUnidadMedida = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsUnidadMedida.Campos.Id, IdUnidadMedida, FiltroBD.OperadorLogico.igual));

            DataTable datos = fachadaCore.consultarDatosUnidadMedida(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        public void registarDatos()
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
                sql.FiltroBD.Add(new FiltroBD(clsUnidadMedida.Campos.Id, IdUnidadMedida, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarUnidadMedida(UnidadMedida, sql);
            }
        }

       
        #endregion
    }
}