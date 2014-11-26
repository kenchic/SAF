using System;
using Telerik.Web.UI;

namespace SAFAppWeb.sistema.menus
{
    public partial class Sistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Permisos
            var itemPadre = new RadPanelItem();
            itemPadre.Text = "Administración Permisos";
            itemPadre.Expanded = true;
            Menu.Items.Add(itemPadre);

            var itemHijos = new RadPanelItem();
            itemHijos.Text = "Roles";
            itemHijos.Target = "rpFormulario";
            itemHijos.NavigateUrl = "../formularios/Roles.aspx";
            itemPadre.Items.Add(itemHijos);

            itemHijos = new RadPanelItem();
            itemHijos.Text = "Permisos";
            itemHijos.Target = "rpFormulario";
            itemHijos.NavigateUrl = "../formularios/Permisos.aspx";
            itemPadre.Items.Add(itemHijos);
            #endregion

            #region Usuarios
            itemPadre = new RadPanelItem();
            itemPadre.Text = "Usuarios";
            itemPadre.Expanded = true;
            Menu.Items.Add(itemPadre);

            itemHijos = new RadPanelItem();
            itemHijos.Text = "Usuarios";
            itemHijos.Target = "rpFormulario";
            itemHijos.NavigateUrl = "../formularios/Usuarios.aspx";
            itemPadre.Items.Add(itemHijos);
            #endregion

        }
    }
}