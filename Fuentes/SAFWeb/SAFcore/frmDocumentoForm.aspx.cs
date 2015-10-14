using System;
using System.Collections.Generic;
using System.Linq;

namespace SAFWeb.SAFcore
{
    public partial class frmDocumentoForm : System.Web.UI.Page
    {
        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (ctrDocumentoForm.IdDocumento > 0)
            {
                DetalleDocumento.Style.Clear();
                DetalleDocumento.Style.Add("display", "block");
                ctrDetalleDocumentoList.IdDocumento = ctrDocumentoForm.IdDocumento;
            }
        }
        #endregion
    }
}