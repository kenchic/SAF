using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrCorteForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdCorte
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
            if (long.TryParse(Request["IdCorte"], out valor))
                IdCorte = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsCorte.Campos.id, IdCorte, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsCorte.Campos.nombre);

            DataTable Corte = fachadaCore.consultarDatosCorte(sql);
            flDatos.DataSource = Corte;
        }
        private void insertarDatos()
        {
            clsCorte Corte = new clsCorte();
            if (cbidProyectoVenta.Value != null)
Corte.idProyectoVenta = (Int16)cbidProyectoVenta.Value;
if (cbidProyectoAlquiler.Value != null)
Corte.idProyectoAlquiler = (Int16)cbidProyectoAlquiler.Value;
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
Corte.Numero = valorNumero;
Corte.Fecha = txtFecha.Text;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdCorte == 0)
            {
                resultado = fachadaCore.insertarCorte(Corte);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsCorte.Campos.id, IdCorte, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarCorte(Corte, sql);
            }
        }
        #endregion
    }
}