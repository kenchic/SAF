using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrMantenimientoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdMantenimiento
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
            if (long.TryParse(Request["IdMantenimiento"], out valor))
                IdMantenimiento = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsMantenimiento.Campos.id, IdMantenimiento, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsMantenimiento.Campos.nombre);

            DataTable Mantenimiento = fachadaCore.consultarDatosMantenimiento(sql);
            flDatos.DataSource = Mantenimiento;
        }
        private void insertarDatos()
        {
            clsMantenimiento Mantenimiento = new clsMantenimiento();
            if (cbidDevolucion.Value != null)
Mantenimiento.idDevolucion = (Int32)cbidDevolucion.Value;
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
Mantenimiento.Numero = valorNumero;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdMantenimiento == 0)
            {
                resultado = fachadaCore.insertarMantenimiento(Mantenimiento);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsMantenimiento.Campos.id, IdMantenimiento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarMantenimiento(Mantenimiento, sql);
            }
        }
        #endregion
    }
}