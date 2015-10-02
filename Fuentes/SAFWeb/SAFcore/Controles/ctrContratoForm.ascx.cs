using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrContratoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdContrato
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

        const string nombreForm = "ContratoForm";
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
            if (long.TryParse(Request["IdContrato"], out valor))
                IdContrato = valor;
        }

        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsContrato.Campos.Id, IdContrato, FiltroBD.OperadorLogico.igual));            

            DataTable datos = fachadaCore.consultarDatosContrato(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }

        private void registarDatos()
        {
            clsContrato Contrato = new clsContrato();
            if (cbidListaPrecios.Value != null)
Contrato.idListaPrecios = Convert.ToByte(cbidListaPrecios.Value);
if (cbidAgente.Value != null)
Contrato.idAgente = Convert.ToInt16(cbidAgente.Value);
Contrato.InformacionBD = ckInformacionBD.Checked ? true : false;
Contrato.ContratoAlquiler = ckContratoAlquiler.Checked ? true : false;
Contrato.CartaPagare = ckCartaPagare.Checked ? true : false;
Contrato.Pagare = ckPagare.Checked ? true : false;
Contrato.LetraCambio = ckLetraCambio.Checked ? true : false;
Contrato.GarantiasCondiciones = ckGarantiasCondiciones.Checked ? true : false;
Contrato.Deposito = ckDeposito.Checked ? true : false;
Contrato.Anticipo = ckAnticipo.Checked ? true : false;
Contrato.PersonaJuridica = ckPersonaJuridica.Checked ? true : false;
Contrato.PersonaNatural = ckPersonaNatural.Checked ? true : false;
Contrato.FotoCopiaCedula = ckFotoCopiaCedula.Checked ? true : false;
Contrato.FotoCopiaNit = ckFotoCopiaNit.Checked ? true : false;
Contrato.CamaraComercio = ckCamaraComercio.Checked ? true : false;
Contrato.DescuentoAlquiler = txtDescuentoAlquiler.Text;
Contrato.DescuentoVenta = txtDescuentoVenta.Text;
Contrato.DescuentoReposicion = txtDescuentoReposicion.Text;
Contrato.DescuentoMantenimiento = txtDescuentoMantenimiento.Text;
Contrato.DescuentoTransporte = txtDescuentoTransporte.Text;
Contrato.PorcentajeAgente = txtPorcentajeAgente.Text;


            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdContrato == 0)
            {
                resultado = fachadaCore.insertarContrato(Contrato);
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsContrato.Campos.Id, IdContrato, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarContrato(Contrato, sql);
            }
        }

		private void cargarCombos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);
            
            SentenciaSQL sql = new SentenciaSQL();

            cbidListaPrecios.DataSource = fachadaCore.consultarDatosListaPrecios(sql);
cbidListaPrecios.ValueField = "Id";
cbidListaPrecios.TextField = "Nombre";
cbidListaPrecios.DataBind();
cbidAgente.DataSource = fachadaCore.consultarDatosAgente(sql);
cbidAgente.ValueField = "Id";
cbidAgente.TextField = "Nombre";
cbidAgente.DataBind();

        }
        #endregion
    }
}