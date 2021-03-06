using BaseDatos;
using DevExpress.Web;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrDetalleDocumentoList : System.Web.UI.UserControl
    {
        #region Propiedades
        const string nombreForm = "DetalleDocumentoList";
        public long IdDocumento
        {
            get
            {
                long valor = 0;
                if (hdfValores.Contains("IdDocumento"))
                    long.TryParse(hdfValores["IdDocumento"].ToString(), out valor);
                return valor;
            }

            set
            {
                hdfValores["IdDocumento"] = value.ToString();
            }
        }
        #endregion

        #region eventos
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["DatosElemento" + nombreForm] = null;
                Session["DatosBodegaOrigen" + nombreForm] = null;
                Session["DatosBodegaDestino" + nombreForm] = null;
            }

            if (Session["DatosElemento" + nombreForm] != null)
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idElemento"]).PropertiesComboBox.DataSource = Session["DatosElemento" + nombreForm];
            else
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idElemento"]).PropertiesComboBox.DataSource = obtenerDatoElemento();

            if (Session["DatosBodegaOrigen" + nombreForm] != null)
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idBodegaOrigen"]).PropertiesComboBox.DataSource = Session["DatosBodegaOrigen" + nombreForm];
            else
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idBodegaOrigen"]).PropertiesComboBox.DataSource = obtenerDatoBodegaOrigen();

            if (Session["DatosBodegaDestino" + nombreForm] != null)
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idBodegaDestino"]).PropertiesComboBox.DataSource = Session["DatosBodegaDestino" + nombreForm];
            else
                ((GridViewDataComboBoxColumn)gvDatos.Columns["idBodegaDestino"]).PropertiesComboBox.DataSource = obtenerDatoBodegaDestino();

            ((GridViewDataComboBoxColumn)gvDatos.Columns["idElemento"]).PropertiesComboBox.TextField = "Nombre";
            ((GridViewDataComboBoxColumn)gvDatos.Columns["idElemento"]).PropertiesComboBox.ValueField = "Id";

            ((GridViewDataComboBoxColumn)gvDatos.Columns["idBodegaOrigen"]).PropertiesComboBox.TextField = "Nombre";
            ((GridViewDataComboBoxColumn)gvDatos.Columns["idBodegaOrigen"]).PropertiesComboBox.ValueField = "Id";
            ((GridViewDataComboBoxColumn)gvDatos.Columns["idBodegaDestino"]).PropertiesComboBox.TextField = "Nombre";
            ((GridViewDataComboBoxColumn)gvDatos.Columns["idBodegaDestino"]).PropertiesComboBox.ValueField = "Id";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Datos" + nombreForm] = null;
                obtenerQueryString();
                gvDatos.DataBind();
            }

        }

        protected void gvDatos_DataBinding(object sender, EventArgs e)
        {
            ASPxGridView grid = sender as ASPxGridView;
            if (Session["Datos" + nombreForm] == null)
                grid.DataSource = obtenerDatos();
            else
                grid.DataSource = Session["Datos" + nombreForm];
        }

        protected void gvDatos_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e)
        {
            foreach (var args in e.UpdateValues)
                actualizarDatos(args.Keys, args.NewValues);

            foreach (var args in e.InsertValues)
                insertarDatos(args.NewValues);

            foreach (var args in e.DeleteValues)
                eliminarDatos(args.Keys);

            e.Handled = true;
        }
        #endregion

        #region metodos
        private void obtenerQueryString()
        {
            long valor = 0;
            if (long.TryParse(Request["IdDocumento"], out valor))
                IdDocumento = valor;
        }
        private DataTable obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaSeg = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleDocumento.Campos.idDocumento, IdDocumento, FiltroBD.OperadorLogico.igual));
            DataTable datos = fachadaSeg.consultarDatosDetalleDocumento(sql);
            Session["Datos" + nombreForm] = datos;
            return datos;
        }
        private DataTable obtenerDatoElemento()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaSeg = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsElemento.Campos.Activo, true, FiltroBD.OperadorLogico.igual));
            DataTable datos = fachadaSeg.consultarDatosElemento(sql);
            Session["DatosElemento" + nombreForm] = datos;
            return datos;
        }
        private DataTable obtenerDatoBodegaOrigen()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaSeg = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsBodega.Campos.Activo, true, FiltroBD.OperadorLogico.igual));
            DataTable datos = fachadaSeg.consultarDatosBodega(sql);
            Session["DatosBodegaOrigen" + nombreForm] = datos;
            return datos;
        }
        private DataTable obtenerDatoBodegaDestino()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaSeg = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsBodega.Campos.Activo, true, FiltroBD.OperadorLogico.igual));
            DataTable datos = fachadaSeg.consultarDatosBodega(sql);
            Session["DatosBodegaDestino" + nombreForm] = datos;
            return datos;
        }


        protected void actualizarDatos(OrderedDictionary keys, OrderedDictionary newValues)
        {
            clsDetalleDocumento DetalleDocumento = new clsDetalleDocumento();
            DetalleDocumento.Id = keys["Id"] as int?;
            DetalleDocumento.idElemento = newValues["idElemento"] as short?;
            DetalleDocumento.idDocumento = (int)IdDocumento;
            DetalleDocumento.idBodegaOrigen = newValues["idBodegaOrigen"] as byte?;
            DetalleDocumento.idBodegaDestino = newValues["idBodegaDestino"] as byte?;
            Int32 valorCantidad = 0;
            Int32.TryParse(newValues["Cantidad"].ToString(), out valorCantidad);
            DetalleDocumento.Cantidad = valorCantidad;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleDocumento.Campos.Id, DetalleDocumento.Id, FiltroBD.OperadorLogico.igual));
            resultado = fachadaCore.editarDetalleDocumento(DetalleDocumento, sql);

            Session["Datos" + nombreForm] = null;
            gvDatos.DataBind();
        }

        protected void insertarDatos(OrderedDictionary newValues)
        {
            clsDetalleDocumento DetalleDocumento = new clsDetalleDocumento();
            DetalleDocumento.idDocumento = (int)IdDocumento;
            DetalleDocumento.idElemento = newValues["idElemento"] as short?;
            DetalleDocumento.idBodegaOrigen = newValues["idBodegaOrigen"] as byte?;
            DetalleDocumento.idBodegaDestino = newValues["idBodegaDestino"] as byte?;
            Int32 valorCantidad = 0;
            Int32.TryParse(newValues["Cantidad"].ToString(), out valorCantidad);
            DetalleDocumento.Cantidad = valorCantidad;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            resultado = fachadaCore.insertarDetalleDocumento(DetalleDocumento);

            Session["Datos" + nombreForm] = null;
            gvDatos.DataBind();
        }

        protected void eliminarDatos(OrderedDictionary keys)
        {
            clsDetalleDocumento DetalleDocumento = new clsDetalleDocumento();
            DetalleDocumento.Id = keys["Id"] as int?;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsDetalleDocumento.Campos.Id, DetalleDocumento.Id, FiltroBD.OperadorLogico.igual));
            resultado = fachadaCore.eliminarDetalleDocumento(DetalleDocumento, sql);

            Session["Datos" + nombreForm] = null;
            gvDatos.DataBind();
        }

        public void registraDatos()
        {
            gvDatos.UpdateEdit();
        }
        #endregion

    }
}