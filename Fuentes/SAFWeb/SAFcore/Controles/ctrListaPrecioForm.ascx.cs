using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrListaPrecioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdListaPrecio
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
            if (long.TryParse(Request["IdListaPrecio"], out valor))
                IdListaPrecio = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsListaPrecio.Campos.id, IdListaPrecio, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsListaPrecio.Campos.nombre);

            DataTable ListaPrecio = fachadaCore.consultarDatosListaPrecio(sql);
            flDatos.DataSource = ListaPrecio;
        }
        private void insertarDatos()
        {
            clsListaPrecio ListaPrecio = new clsListaPrecio();
            ListaPrecio.Nombre = txtNombre.Text;
            ListaPrecio.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdListaPrecio == 0)
            {
                resultado = fachadaCore.insertarListaPrecio(ListaPrecio);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsListaPrecio.Campos.id, IdListaPrecio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarListaPrecio(ListaPrecio, sql);
            }
        }
        #endregion
    }
}