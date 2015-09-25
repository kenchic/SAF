using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDevolucionForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDevolucion
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
            if (long.TryParse(Request["IdDevolucion"], out valor))
                IdDevolucion = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDevolucion.Campos.id, IdDevolucion, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDevolucion.Campos.nombre);

            DataTable Devolucion = fachadaCore.consultarDatosDevolucion(sql);
            flDatos.DataSource = Devolucion;
        }
        private void insertarDatos()
        {
            clsDevolucion Devolucion = new clsDevolucion();
            Devolucion.Nombre = txtNombre.Text;
            Devolucion.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDevolucion == 0)
            {
                resultado = fachadaCore.insertarDevolucion(Devolucion);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDevolucion.Campos.id, IdDevolucion, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDevolucion(Devolucion, sql);
            }
        }
        #endregion
    }
}