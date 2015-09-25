using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDevolucionServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdDevolucionServicio
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
            if (long.TryParse(Request["IdDevolucionServicio"], out valor))
                IdDevolucionServicio = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDevolucionServicio.Campos.id, IdDevolucionServicio, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsDevolucionServicio.Campos.nombre);

            DataTable DevolucionServicio = fachadaCore.consultarDatosDevolucionServicio(sql);
            flDatos.DataSource = DevolucionServicio;
        }
        private void insertarDatos()
        {
            clsDevolucionServicio DevolucionServicio = new clsDevolucionServicio();
            DevolucionServicio.Nombre = txtNombre.Text;
            DevolucionServicio.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdDevolucionServicio == 0)
            {
                resultado = fachadaCore.insertarDevolucionServicio(DevolucionServicio);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsDevolucionServicio.Campos.id, IdDevolucionServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarDevolucionServicio(DevolucionServicio, sql);
            }
        }
        #endregion
    }
}