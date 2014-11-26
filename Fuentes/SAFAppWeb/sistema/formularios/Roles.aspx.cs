using System;
using System.Web.UI.WebControls;
using Seguridad.DALC;
using Telerik.Web.UI;

namespace SAFAppWeb.sistema.formularios
{
    public partial class Datos : System.Web.UI.Page
    {
        bool _flag;
        private const string Nombremodulo = "Datos";
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
                rgDatos.AllowFilteringByColumn = true;
            }
            else
            {
                ViewState["ckbActivarFiltro"] = "false";
                rgDatos.AllowFilteringByColumn = false;
            }
            rgDatos.Rebind();
        }
        protected void rgDatos_ItemCreated(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridEditableItem && e.Item.IsInEditMode)
            {
                var item = (GridEditableItem)e.Item;
                Utilidad.CrearValidador(item, "Nombre", "rfvNombre");
            }
        }
        protected void rgDatos_PreRender(object sender, EventArgs e)
        {
            //Si seleccion filtrar se debe habilitar el checkbox
            if (!_flag)
            {
                var cmdItem = (GridCommandItem)rgDatos.MasterTableView.GetItems(GridItemType.CommandItem)[0];
                var cbox = (CheckBox)cmdItem.FindControl("ckbActivarFiltro");
                if (cbox != null)
                    cbox.Checked = ViewState["ckbActivarFiltro"].ToString() == "true";
            }
            else
                _flag = false;
            
        }
        protected void rgDatos_ItemCommand(object sender, GridCommandEventArgs e)
        {
            //Ocultar columnas de comando "Editar" y "Eliminar" al exportar
            if (e.CommandName == RadGrid.ExportToExcelCommandName)
            {
                _flag = true;
                rgDatos.MasterTableView.GridLines = GridLines.Both;
                rgDatos.ExportSettings.OpenInNewWindow = true;
                rgDatos.ExportSettings.ExportOnlyData = true;
                rgDatos.ExportSettings.HideStructureColumns = true;
                rgDatos.ExportSettings.IgnorePaging = true;
                rgDatos.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None;
                rgDatos.MasterTableView.GetColumn("Editar").Visible = false;
                rgDatos.MasterTableView.GetColumn("DeleteColumn").Visible = false;
                //Ocultar columna Activo con CheckBox y usa la columna template con el label
                rgDatos.MasterTableView.GetColumn("Activo").Visible = false;
                rgDatos.MasterTableView.GetColumn("ActivoExportar").Visible = true;
            }
            if (e.CommandName == "Borrar")
            {
                string Ids="-1,";
                foreach (GridDataItem item in rgDatos.SelectedItems)                
                    Ids = Ids + item.GetDataKeyValue("Id").ToString() + ",";
                Ids= Ids + "-1";
                if (rgDatos.SelectedItems.Count > 0)
                {
                    int resultado;
                    var ejecutor = (BaseDatos.Comandos)Session["ejecutorBD"];
                    clsFachadaClaseBase clsFachas = new clsFachadaClaseBase(ref ejecutor);
                    resultado = clsFachas.EliminarRoles(Ids);
                    
                    if ((resultado > 0))
                        Utilidad.MostrarResultadoOperacionBd(ref rgDatos, ((Clases.Mensaje)Session["mensajes"]).EliminarBien, true);
                    else
                        Utilidad.MostrarResultadoOperacionBd(ref rgDatos, ((Clases.Mensaje)Session["mensajes"]).EliminarMal + ". " + ((BaseDatos.Comandos)Session["ejecutorBD"]).UltimoError, false);
                    rgDatos.Rebind();
                }
            }
        }
        protected void rgDatos_ItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                var item = (GridDataItem)e.Item;
                var activo = (Label)item.FindControl("lblActivoExp");
                activo.Text = activo.Text.ToUpper() == "TRUE" ? @"SI" : @"NO";
            }
        }
        protected void rgDatos_GridExporting(object sender, GridExportingArgs e)
        {
            //Insertar encabezado en las primeras filas de la hoja de excel
            string customHTML = "<div style='text-align:center; font-weight:bold; font-size:1.25em;'>Reporte</div>" + "<div style='text-align:center; font-weight:bold; font-size:1.25em;'>SAF</div>" + "<div style='text-align:center; font-weight:bold; font-size:1.25em;'>" + Nombremodulo + "</div><br />";
            e.ExportOutput = e.ExportOutput.Replace("<body>", String.Format("<body>{0}", customHTML));
        }
        protected void odsDatos_ObjectCreating(object sender, ObjectDataSourceEventArgs e)
        {
            var ejecutor = (BaseDatos.Comandos)Session["ejecutorBD"];
            e.ObjectInstance = new clsFachadaClaseBase(ref ejecutor);
        }
        protected void odsDatos_Updated(object sender, ObjectDataSourceStatusEventArgs e)
        {
            int resultado;
            resultado = Convert.ToInt32(e.ReturnValue);
            if ((resultado > 0))
                Utilidad.MostrarResultadoOperacionBd(ref rgDatos, ((Clases.Mensaje)Session["mensajes"]).ActualizarBien, true);
            else
                Utilidad.MostrarResultadoOperacionBd(ref rgDatos, ((Clases.Mensaje)Session["mensajes"]).ActualizarMal + ". " + ((BaseDatos.Comandos)Session["ejecutorBD"]).UltimoError, false);
        }
        protected void odsDatos_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            int resultado;
            resultado = Convert.ToInt32(e.ReturnValue);
            if ((resultado > 0))
                Utilidad.MostrarResultadoOperacionBd(ref rgDatos, ((Clases.Mensaje)Session["mensajes"]).InsertarBien, true);
            else
                Utilidad.MostrarResultadoOperacionBd(ref rgDatos, ((Clases.Mensaje)Session["mensajes"]).InsertarMal + ". " + ((BaseDatos.Comandos)Session["ejecutorBD"]).UltimoError, false);
        }
        protected void odsDatos_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            int resultado;
            resultado = Convert.ToInt32(e.ReturnValue);
            if ((resultado > 0))
                Utilidad.MostrarResultadoOperacionBd(ref rgDatos, ((Clases.Mensaje)Session["mensajes"]).EliminarBien, true);
            else
                Utilidad.MostrarResultadoOperacionBd(ref rgDatos, ((Clases.Mensaje)Session["mensajes"]).EliminarMal + ". " + ((BaseDatos.Comandos)Session["ejecutorBD"]).UltimoError, false);
        }

        private void validarPermisos(GridItemEventArgs e)
        {
            Seguridad.clsUsuario usuario = (Seguridad.clsUsuario)Session["UsuarioSesion"];
            if (!usuario.Admin)
            {
                var ejecutor = (BaseDatos.Comandos)Session["ejecutorBD"];
                clsFachadaClaseBase clsFachas = new clsFachadaClaseBase(ref ejecutor);

                if (!clsFachas.TienePermiso("Admin.Roles", enuTipoAccionBaseDatos.ConsultarTodos.ToString()))
                    rgDatos.Visible = false;

                if (rgDatos.EditIndexes.Count <= 0)
                    if (!clsFachas.TienePermiso("Admin.Roles", enuTipoAccionBaseDatos.Adicionar.ToString()))
                        if (e.Item is GridCommandItem)
                        {
                            e.Item.FindControl("btnAdd").Visible = false;
                            //Elimina el link de Agregar nuevo registro
                        }

                if (rgDatos.EditIndexes.Count <= 0)
                    if (!clsFachas.TienePermiso("Admin.Roles", enuTipoAccionBaseDatos.Modificar.ToString()))
                        foreach (GridColumn col in rgDatos.MasterTableView.Columns)
                        {
                            //Ocultar la columna de Editar
                            if (col.UniqueName == "Editar")
                            {
                                col.Visible = false;
                            }
                        }

                if (!clsFachas.TienePermiso("Admin.Roles", enuTipoAccionBaseDatos.Eliminar.ToString()))
                    foreach (GridColumn col in rgDatos.MasterTableView.Columns)
                    {
                        //Ocultar la columna Autogenerada de Eliminar
                        if (col.UniqueName == "DeleteColumn")
                        {
                            col.Visible = false;
                        }
                    }
            }
        }
    }
}