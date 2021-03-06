using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrElementoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdElemento
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

        const string nombreForm = "ElementoForm";
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Datos" + nombreForm] = null;
                obtenerQueryString();
                cargarCombos();
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
            if (long.TryParse(Request["IdElemento"], out valor))
                IdElemento = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsElemento.Campos.Id, IdElemento, FiltroBD.OperadorLogico.igual));

            DataTable datos = fachadaCore.consultarDatosElemento(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        public void registarDatos()
        {
            clsElemento Elemento = new clsElemento();
            if (cbidGrupoElemento.Value != null)
                Elemento.idGrupoElemento = Convert.ToByte(cbidGrupoElemento.Value);
            if (cbidUnidadMedida.Value != null)
                Elemento.idUnidadMedida = Convert.ToByte(cbidUnidadMedida.Value);
            Elemento.Referencia = txtReferencia.Text;
            Elemento.Nombre = txtNombre.Text;
            Double valorMt2 = 0;
            Double.TryParse(txtMt2.Text, out valorMt2);
            Elemento.Mt2 = valorMt2;
            Double valorPeso = 0;
            Double.TryParse(txtPeso.Text, out valorPeso);
            Elemento.Peso = valorPeso;
            Elemento.Rotacion = ckRotacion.Checked ? true : false;
            Elemento.Activo = ckActivo.Checked ? true : false;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdElemento == 0)
            {
                resultado = fachadaCore.insertarElemento(Elemento);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsElemento.Campos.Id, IdElemento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarElemento(Elemento, sql);
            }
        }

        private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();

            cbidGrupoElemento.DataSource = fachadaCore.consultarDatosGrupoElemento(sql);
            cbidGrupoElemento.ValueField = "Id";
            cbidGrupoElemento.TextField = "Nombre";
            cbidGrupoElemento.DataBind();

            cbidUnidadMedida.DataSource = fachadaCore.consultarDatosUnidadMedida(sql);
            cbidUnidadMedida.ValueField = "Id";
            cbidUnidadMedida.TextField = "Nombre";
            cbidUnidadMedida.DataBind();

        }
        #endregion
    }
}