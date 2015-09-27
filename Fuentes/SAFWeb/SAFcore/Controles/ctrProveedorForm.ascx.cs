using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            if (long.TryParse(Request["IdProveedor"], out valor))
                IdProveedor = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsProveedor.Campos.id, IdProveedor, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsProveedor.Campos.nombre);

            DataTable Proveedor = fachadaCore.consultarDatosProveedor(sql);
            flDatos.DataSource = Proveedor;
        }
        private void insertarDatos()
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
                sql.FiltroBD.Add(new FiltroBD(clsProveedor.Campos.id, IdProveedor, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarProveedor(Proveedor, sql);
            }
        }
        #endregion
    }
}