using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrRepDevolucionServicioForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdRepDevolucionServicio
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
            if (long.TryParse(Request["IdRepDevolucionServicio"], out valor))
                IdRepDevolucionServicio = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsRepDevolucionServicio.Campos.id, IdRepDevolucionServicio, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsRepDevolucionServicio.Campos.nombre);

            DataTable RepDevolucionServicio = fachadaCore.consultarDatosRepDevolucionServicio(sql);
            flDatos.DataSource = RepDevolucionServicio;
        }
        private void insertarDatos()
        {
            clsRepDevolucionServicio RepDevolucionServicio = new clsRepDevolucionServicio();
            if (cbidDevolucion.Value != null)
RepDevolucionServicio.idDevolucion = (Int32)cbidDevolucion.Value;
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
RepDevolucionServicio.Numero = valorNumero;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdRepDevolucionServicio == 0)
            {
                resultado = fachadaCore.insertarRepDevolucionServicio(RepDevolucionServicio);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsRepDevolucionServicio.Campos.id, IdRepDevolucionServicio, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarRepDevolucionServicio(RepDevolucionServicio, sql);
            }
        }
        #endregion
    }
}