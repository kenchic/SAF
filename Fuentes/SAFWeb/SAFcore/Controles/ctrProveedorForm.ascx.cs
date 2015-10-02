using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrProveedorForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdProveedor
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

        const string nombreForm = "ProveedorForm";
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
            if (long.TryParse(Request["IdProveedor"], out valor))
                IdProveedor = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsProveedor.Campos.Id, IdProveedor, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosProveedor(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsProveedor Proveedor = new clsProveedor();
            Proveedor.Identificacion = txtIdentificacion.Text;
Proveedor.Nombre = txtNombre.Text;
Proveedor.Iniciales = txtIniciales.Text;
Proveedor.Telefono = txtTelefono.Text;
Proveedor.Direccion = txtDireccion.Text;
Proveedor.Activo = ckActivo.Checked ? true : false;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdProveedor == 0)
            {
                resultado = fachadaCore.insertarProveedor(Proveedor);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsProveedor.Campos.Id, IdProveedor, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarProveedor(Proveedor, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            
        }
        #endregion
    }
}