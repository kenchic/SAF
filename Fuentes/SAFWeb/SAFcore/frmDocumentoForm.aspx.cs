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

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            ctrDocumentoForm.registarDatos();
            ctrDetalleDocumentoList.IdDocumento = ctrDocumentoForm.IdDocumento;
            ctrDetalleDocumentoList.registraDatos();
        }
        #endregion
    }
}