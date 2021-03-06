using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrProyectoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdProyecto
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

        const string nombreForm = "ProyectoForm";
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
                iniciarControles();
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
            if (long.TryParse(Request["IdProyecto"], out valor))
                IdProyecto = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsProyecto.Campos.Id, IdProyecto, FiltroBD.OperadorLogico.igual));

            DataTable datos = fachadaCore.consultarDatosProyecto(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        public void registarDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            clsProyecto Proyecto = new clsProyecto();
            if (cbidCliente.SelectedItem != null)
                Proyecto.idCliente = Convert.ToInt32(cbidCliente.Value);
            else
            {
                if (cbidCliente.Text != string.Empty)
                {
                    clsCliente Cliente = new clsCliente();
                    Cliente.Nombre = cbidCliente.Text;
                    Cliente.Activo = true;
                    Proyecto.idCliente = (short)fachadaCore.insertarCliente(Cliente);
                }
            }
            if (cbidCiudad.SelectedItem != null)
                Proyecto.idCiudad = Convert.ToInt16(cbidCiudad.Value);
            else
            {
                if (cbidCiudad.Text != string.Empty)
                {
                    clsCiudad Ciudad = new clsCiudad();
                    Ciudad.Nombre = cbidCiudad.Text;
                    Ciudad.Activo = true;
                    Proyecto.idCiudad = (short)fachadaCore.insertarCiudad(Ciudad);
                }
            }
            Proyecto.NombreCliente = cbidCliente.Text;
            Proyecto.NombreCiudad = cbidCiudad.Text;
            Proyecto.Nombre = txtNombre.Text;
            Proyecto.Tipo = txtTipo.Text;
            Proyecto.Direccion = txtDireccion.Text;
            Proyecto.Telefono = txtTelefono.Text;
            Proyecto.Observacion = txtObservacion.Text;
            Proyecto.Fecha = DateTime.Today.ToString("yyyy-MM-dd");
            Proyecto.FormaContacto = txtFormaContacto.Text;
            Proyecto.SistemaMedida = txtSistemaMedida.Text;
            Proyecto.IdentificacionResponsable = txtIdentificacionResponsable.Text;
            Proyecto.NombreResponsable = txtNombreResponsable.Text;
            Proyecto.TelResponsable = txtTelResponsable.Text;
            Proyecto.Activo = ckActivo.Checked ? true : false;

            if (cbEstado.SelectedItem != null)
                Proyecto.Estado = Convert.ToByte(cbEstado.Value);

            int resultado = 0;
            if (IdProyecto == 0)
            {
                resultado = fachadaCore.insertarProyecto(Proyecto);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsProyecto.Campos.Id, IdProyecto, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarProyecto(Proyecto, sql);
            }
        }

        private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsCliente.Campos.Activo, true, FiltroBD.OperadorLogico.igual));
            cbidCliente.DataSource = fachadaCore.consultarDatosCliente(sql);
            cbidCliente.ValueField = "Id";
            cbidCliente.TextField = "Nombre";
            cbidCliente.DataBind();

            sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsCiudad.Campos.Activo, true, FiltroBD.OperadorLogico.igual));
            cbidCiudad.DataSource = fachadaCore.consultarDatosCiudad(sql);
            cbidCiudad.ValueField = "Id";
            cbidCiudad.TextField = "Nombre";
            cbidCiudad.DataBind();

        }

        private void iniciarControles()
        {
            txtFecha.Date = DateTime.Today;
        }
        #endregion
    }
}