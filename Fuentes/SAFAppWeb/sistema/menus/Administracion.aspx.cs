using System;
using Telerik.Web.UI;

namespace SAFAppWeb.sistema.menus
{
    public partial class Administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var itemPadre = new RadPanelItem();
            itemPadre.Text = "Administración Permisos";
            itemPadre.Expanded = true;
            RadPanelBar1.Items.Add(itemPadre);

            var itemHijos = new RadPanelItem();
            itemHijos.Text = "Roles";
            itemHijos.Target = "rpFormulario";
            itemHijos.NavigateUrl = "../formularios/Roles.aspx";
            itemPadre.Items.Add(itemHijos);

            itemHijos = new RadPanelItem();
            itemHijos.Text = "Permisos";
            itemHijos.Target = "rpFormulario";
            itemHijos.NavigateUrl = "../formularios/Roles.aspx";
            itemPadre.Items.Add(itemHijos);
        }
    }
}