using BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAFcore 
{
    public partial class clsFachadaSAFcore
    {
        public long consultarSiguienteDocumento(long idDocumento)
        {
            m_clsDocumentoDALC = new clsDocumentoDALC(m_EjecutorBaseDatos);
            return 0;
        }
    }
}
