using System;
using System.Collections.Generic;
using System.Linq;

namespace SAFWeb.SAFcore
{
    public partial class frmOrdenServicioList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btCrear_Click(object sender, EventArgs e)
{
Response.Redirect("frmOrdenServicioForm.aspx");
}

    }
}