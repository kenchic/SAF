using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrRemisionForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdRemision
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

        const string nombreForm = "RemisionForm";
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Datos" + nombreForm] = null;
                obtenerQueryString();
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
            if (long.TryParse(Request["IdRemision"], out valor))
                IdRemision = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsRemision.Campos.Id, IdRemision, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosRemision(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsRemision Remision = new clsRemision();
            if (cbidProyectoAlquiler.Value != null)
Remision.idProyectoAlquiler = Convert.ToInt16(cbidProyectoAlquiler.Value);
if (cbidProyectoVenta.Value != null)
Remision.idProyectoVenta = Convert.ToInt16(cbidProyectoVenta.Value);
if (cbidConductor.Value != null)
Remision.idConductor = Convert.ToInt16(cbidConductor.Value);
Int32 valorNumero = 0;
Int32.TryParse(txtNumero.Text, out valorNumero);
Remision.Numero = valorNumero;
Remision.FechaPedido = txtFechaPedido.Text;
Remision.FechaEntrega = txtFechaEntrega.Text;
Remision.FechaCreacion = txtFechaCreacion.Text;
Remision.Hora = txtHora.Text;
Remision.Anulado = ckAnulado.Checked ? true : false;
Remision.Transporte = ckTransporte.Checked ? true : false;
Decimal valorValorTransporte = 0;
Decimal.TryParse(txtValorTransporte.Text, out valorValorTransporte);
Remision.ValorTransporte = valorValorTransporte;
Remision.Despachado = ckDespachado.Checked ? true : false;
Remision.EquipoAdecuado = ckEquipoAdecuado.Checked ? true : false;
Decimal valorPesoEquipo = 0;
Decimal.TryParse(txtPesoEquipo.Text, out valorPesoEquipo);
Remision.PesoEquipo = valorPesoEquipo;
Decimal valorValorEquipo = 0;
Decimal.TryParse(txtValorEquipo.Text, out valorValorEquipo);
Remision.ValorEquipo = valorValorEquipo;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdRemision == 0)
            {
                resultado = fachadaCore.insertarRemision(Remision);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsRemision.Campos.Id, IdRemision, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarRemision(Remision, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidProyectoAlquiler.DataSource = fachadaCore.consultarDatosProyectoAlquiler(sql);
cbidProyectoAlquiler.ValueField = "Id";
cbidProyectoAlquiler.TextField = "Nombre";
cbidProyectoAlquiler.DataBind();
cbidProyectoVenta.DataSource = fachadaCore.consultarDatosProyectoVenta(sql);
cbidProyectoVenta.ValueField = "Id";
cbidProyectoVenta.TextField = "Nombre";
cbidProyectoVenta.DataBind();
cbidConductor.DataSource = fachadaCore.consultarDatosConductor(sql);
cbidConductor.ValueField = "Id";
cbidConductor.TextField = "Nombre";
cbidConductor.DataBind();

        }
        #endregion
    }
}