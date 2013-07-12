using System;
using System.Web.UI.WebControls;
using Seguridad.DALC;
using Telerik.Web.UI;

namespace SAFAppWeb.sistema.formularios
{
    public partial class Roles : System.Web.UI.Page
    {
        bool _flag;
        private const string Nombremodulo = "ROLES";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["ckbActivarFiltro"] = "";
            }
        }
        protected void ckbActivarFiltro_CheckedChanged(object sender, EventArgs e)
        {
            var chkbox = (CheckBox)sender;
            if (chkbox.Checked)
            {
                ViewState["ckbActivarFiltro"] = "true";
                rgRoles.AllowFilteringByColumn = true;
            }
            else
            {
                ViewState["ckbActivarFiltro"] = "false";
                rgRoles.AllowFilteringByColumn = false;
            }
            rgRoles.Rebind();
        }
        protected void rgRoles_ItemCreated(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridEditableItem && e.Item.IsInEditMode)
            {
                var item = (GridEditableItem)e.Item;
                Utilidad.CrearValidador(item, "Nombre", "rfvNombre");
            }
        }
        protected void rgRoles_PreRender(object sender, EventArgs e)
        {
            //Si seleccion filtrar se debe habilitar el checkbox
            if (!_flag)
            {
                var cmdItem = (GridCommandItem)rgRoles.MasterTableView.GetItems(GridItemType.CommandItem)[0];
                var cbox = (CheckBox)cmdItem.FindControl("ckbActivarFiltro");
                if (cbox != null)
                    cbox.Checked = ViewState["ckbActivarFiltro"].ToString() == "true";
            }
            else
                _flag = false;
            
        }
        protected void rgRoles_ItemCommand(object sender, GridCommandEventArgs e)
        {
            //Ocultar columnas de comando "Editar" y "Eliminar" al exportar
            if (e.CommandName == RadGrid.ExportToExcelCommandName)
            {
                _flag = true;
                rgRoles.MasterTableView.GridLines = GridLines.Both;
                rgRoles.ExportSettings.OpenInNewWindow = true;
                rgRoles.ExportSettings.ExportOnlyData = true;
                rgRoles.ExportSettings.HideStructureColumns = true;
                rgRoles.ExportSettings.IgnorePaging = true;
                rgRoles.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None;
                rgRoles.MasterTableView.GetColumn("Editar").Visible = false;
                rgRoles.MasterTableView.GetColumn("DeleteColumn").Visible = false;
                //Ocultar columna Activo con CheckBox y usa la columna template con el label
                rgRoles.MasterTableView.GetColumn("Activo").Visible = false;
                rgRoles.MasterTableView.GetColumn("ActivoExportar").Visible = true;
            }
        }
        protected void rgRoles_ItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                var item = (GridDataItem)e.Item;
                var activo = (Label)item.FindControl("lblActivoExp");
                activo.Text = activo.Text.ToUpper() == "TRUE" ? @"SI" : @"NO";
            }
        }
        protected void rgRoles_GridExporting(object sender, GridExportingArgs e)
        {
            //Insertar encabezado en las primeras filas de la hoja de excel
            string customHTML = "<div style='text-align:center; font-weight:bold; font-size:1.25em;'>Reporte</div>" + "<div style='text-align:center; font-weight:bold; font-size:1.25em;'>SAF</div>" + "<div style='text-align:center; font-weight:bold; font-size:1.25em;'>" + Nombremodulo + "</div><br />";
            e.ExportOutput = e.ExportOutput.Replace("<body>", String.Format("<body>{0}", customHTML));
        }
        protected void odsRoles_ObjectCreating(object sender, ObjectDataSourceEventArgs e)
        {
            var ejecutor = (BaseDatos.Comandos)Session["ejecutorBD"];
            e.ObjectInstance = new clsFachadaClaseBase(ref ejecutor);
        }
        protected void odsRoles_Updated(object sender, ObjectDataSourceStatusEventArgs e)
        {
            int resultado;
            resultado = Convert.ToInt32(e.ReturnValue);
            if ((resultado > 0))
                Utilidad.MostrarResultadoOperacionBd(ref rgRoles, ((Clases.Mensaje)Session["mensajes"]).ActualizarBien, true);
            else
                Utilidad.MostrarResultadoOperacionBd(ref rgRoles, ((Clases.Mensaje)Session["mensajes"]).ActualizarMal + ". " + ((BaseDatos.Comandos)Session["ejecutorBD"]).UltimoError, false);
        }
        protected void odsRoles_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            int resultado;
            resultado = Convert.ToInt32(e.ReturnValue);
            if ((resultado > 0))
                Utilidad.MostrarResultadoOperacionBd(ref rgRoles, ((Clases.Mensaje)Session["mensajes"]).InsertarBien, true);
            else
                Utilidad.MostrarResultadoOperacionBd(ref rgRoles, ((Clases.Mensaje)Session["mensajes"]).InsertarMal + ". " + ((BaseDatos.Comandos)Session["ejecutorBD"]).UltimoError, false);
        }
        protected void odsRoles_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            int resultado;
            resultado = Convert.ToInt32(e.ReturnValue);
            if ((resultado > 0))
                Utilidad.MostrarResultadoOperacionBd(ref rgRoles, ((Clases.Mensaje)Session["mensajes"]).EliminarBien, true);
            else
                Utilidad.MostrarResultadoOperacionBd(ref rgRoles, ((Clases.Mensaje)Session["mensajes"]).EliminarMal + ". " + ((BaseDatos.Comandos)Session["ejecutorBD"]).UltimoError, false);
        }
    }
}