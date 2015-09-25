using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            if (long.TryParse(Request["IdCliente"], out valor))
                IdCliente = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsCliente.Campos.id, IdCliente, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsCliente.Campos.nombre);

            DataTable Cliente = fachadaCore.consultarDatosCliente(sql);
            flDatos.DataSource = Cliente;
        }
        private void insertarDatos()
        {
            clsCliente Cliente = new clsCliente();
            Cliente.Nombre = txtNombre.Text;
            Cliente.Activo = ckActivo.Checked ? true : false;

            int valor = 0;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdCliente == 0)
            {
                resultado = fachadaCore.insertarCliente(Cliente);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsCliente.Campos.id, IdCliente, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarCliente(Cliente, sql);
            }
        }
        #endregion
    }
}