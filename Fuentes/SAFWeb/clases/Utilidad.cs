using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public sealed class Utilidad
{
    public const string TEXTO_ITEM_VACIO = "--Seleccione--";
    public const string VALOR_ITEM_VACIO = "-1";
    public const string SIN_FILTRO_BUSCAR = "todos";
    public const string COLOR_RESULTADO_BIEN = "green";
    public const string COLOR_RESULTADO_MAL = "red";
    public static void ColocarEstilomsg(ref Label etiqueta, string texto, bool resultado)
    {
        etiqueta.Text = texto;
        etiqueta.ForeColor = (resultado) ? System.Drawing.Color.Green : System.Drawing.Color.Red;
    }

    public static void MostrarResultadoOperacionBd(ref ASPxGridView grilla, string texto, bool resultado)
    {
        var color = COLOR_RESULTADO_MAL;
        if ((resultado))
            color = COLOR_RESULTADO_BIEN;
        grilla.Controls.Add(new LiteralControl(string.Format("<span style='color:{0}; font-weight:bold; width:100%; text-align:center;'>{1}</span>", color, texto)));
    }

    public static void SeleccionarItemCombo(ref DropDownList combo, string valor, string texto)
    {
        combo.ClearSelection();
        if ((combo.Items.FindByValue(valor) == null))
            combo.Items.Insert(0, new ListItem(texto, valor));
        combo.Items.FindByValue(valor).Selected = true;
    }
    public static void SeleccionarItemCombo(ref ASPxComboBox combo, string valor, string texto)
    {        
        
        combo.SelectedIndex = -1;
        if ((combo.Items.FindByValue(valor) == null))
            combo.Items.Insert(0, new ListEditItem(texto, valor));
        combo.Items.FindByValue(valor).Selected = true;
    }
    public static void AgregarToolTipCombo(ref DropDownList combo)
    {
        foreach (ListItem item in combo.Items)
            item.Attributes.Add("title", item.Text);
    }    
    public static void AgregarItemVacio(ref DropDownList combo)
    {
        var itemvacio = new ListItem(TEXTO_ITEM_VACIO, VALOR_ITEM_VACIO);
        combo.Items.Insert(0, itemvacio);
    }
    public static void AgregarItemVacio(ref ASPxComboBox combo)
    {
        var itemVacio = new ListEditItem(TEXTO_ITEM_VACIO, VALOR_ITEM_VACIO);
        combo.Items.Insert(0, itemVacio);
    }
    public static void AgregarItemVacio(ref DropDownList combo, string textoItem, string valorItem)
    {
        var itemvacio = new ListItem(textoItem, valorItem);
        combo.Items.Insert(0, itemvacio);
    }
    public static void AgregarItemVacio(ref ASPxComboBox combo, string textoItem, string valorItem)
    {
        var itemvacio = new ListEditItem(textoItem, valorItem);
        combo.Items.Insert(0, itemvacio);
    }

}
