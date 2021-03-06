using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrClienteForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdCliente
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

        const string nombreForm = "ClienteForm";
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
            if (long.TryParse(Request["IdCliente"], out valor))
                IdCliente = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsCliente.Campos.Id, IdCliente, FiltroBD.OperadorLogico.igual));

            DataTable datos = fachadaCore.consultarDatosCliente(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }
        public void registarDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            clsCliente Cliente = new clsCliente();           
            if (cbidCiudad.SelectedItem != null)
                Cliente.idCiudad = Convert.ToInt16(cbidCiudad.Value);
            else
            {
                if(cbidCiudad.Text != string.Empty)
                {
                    clsCiudad Ciudad = new clsCiudad();
                    Ciudad.Nombre = cbidCiudad.Text;
                    Ciudad.Activo = true;
                    Cliente.idCiudad = (short)fachadaCore.insertarCiudad(Ciudad);
                }
            }

            Cliente.Identificacion = txtIdentificacion.Text;
            Cliente.Nombre1 = txtNombre1.Text;
            Cliente.Nombre2 = txtNombre2.Text;
            Cliente.Apellido1 = txtApellido1.Text;
            Cliente.Apellido2 = txtApellido2.Text;
            Cliente.Direccion = txtDireccion.Text;
            Cliente.Telefono = txtTelefono.Text;
            Cliente.Celular = txtCelular.Text;
            Cliente.Correo = txtCorreo.Text;
            Cliente.Activo = ckActivo.Checked ? true : false;

            int resultado = 0;
            if (IdCliente == 0)
            {
                resultado = fachadaCore.insertarCliente(Cliente);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsCliente.Campos.Id, IdCliente, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarCliente(Cliente, sql);
            }
        }

        private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsCiudad.Campos.Activo, true, FiltroBD.OperadorLogico.igual));
            cbidCiudad.DataSource = fachadaCore.consultarDatosCiudad(sql);
            cbidCiudad.ValueField = "Id";
            cbidCiudad.TextField = "Nombre";
            cbidCiudad.DataBind();

        }
        #endregion
    }
}