using System;
using System.Collections.Generic;
using System.Linq;

namespace SAFWeb.SAFcore
{
    public partial class frmElementoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            ctrElementoForm.registarDatos();
        }
    }
}