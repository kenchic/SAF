using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

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

    public static void MostrarResultadoOperacionBd(ref RadGrid grilla, string texto, bool resultado)
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
    public static void SeleccionarItemCombo(ref RadComboBox combo, string valor, string texto)
    {
        combo.ClearSelection();
        if ((combo.Items.FindItemByValue(valor) == null))
            combo.Items.Insert(0, new RadComboBoxItem(texto, valor));
        combo.Items.FindItemByValue(valor).Selected = true;
    }
    public static void AgregarToolTipCombo(ref DropDownList combo)
    {
        foreach (ListItem item in combo.Items)
            item.Attributes.Add("title", item.Text);
    }
    public static void AgregarToolTipCombo(ref RadComboBox combo)
    {
        foreach (RadComboBoxItem item in combo.Items)
            item.Attributes.Add("title", item.Text);
    }
    public static void AgregarItemVacio(ref DropDownList combo)
    {
        var itemvacio = new ListItem(TEXTO_ITEM_VACIO, VALOR_ITEM_VACIO);
        combo.Items.Insert(0, itemvacio);
    }
    public static void AgregarItemVacio(ref RadComboBox combo)
    {
        var itemVacio = new RadComboBoxItem(TEXTO_ITEM_VACIO, VALOR_ITEM_VACIO);
        combo.Items.Insert(0, itemVacio);
    }
    public static void AgregarItemVacio(ref DropDownList combo, string textoItem, string valorItem)
    {
        var itemvacio = new ListItem(textoItem, valorItem);
        combo.Items.Insert(0, itemvacio);
    }
    public static void AgregarItemVacio(ref RadComboBox combo, string textoItem, string valorItem)
    {
        var itemvacio = new RadComboBoxItem(textoItem, valorItem);
        combo.Items.Insert(0, itemvacio);
    }

    public static void AbrirVentana(Page pagina, string url)
    {
        var script = "<script>window.open('" + url + "');</script>";
        if ((!(pagina.ClientScript.IsStartupScriptRegistered("AbrirVentana"))))
            pagina.ClientScript.RegisterClientScriptBlock(pagina.GetType(), "AbrirVentana", script);
    }

    public static void CrearValidador(GridEditableItem item, string editorColumna, string idControl)
    {
        var editor = (GridTextBoxColumnEditor)item.EditManager.GetColumnEditor(editorColumna);
        var cell = (TableCell)editor.TextBoxControl.Parent;
        var validator = new RequiredFieldValidator();
        editor.TextBoxControl.ID = idControl;
        validator.ControlToValidate = editor.TextBoxControl.ID;
        validator.Display = ValidatorDisplay.Dynamic;
        validator.ErrorMessage = @"<span style='display: inline; float: right'><img src='../Imagenes/Controles/imgError.gif' title='Este campo es requerido.' alt='' /></span>";
        cell.Controls.Add(validator);
    }
}
