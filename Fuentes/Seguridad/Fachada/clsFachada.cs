///////////////////////////////////////////////////////////
//  clsFachada.cs
//  Implementation of the Class Fachada SAFseg
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using BaseDatos;

namespace SAFseg {

    public partial class clsFachadaSAFseg
    {
        private Comandos m_EjecutorBaseDatos;
        #region Miembros
        private clsAuditoriaDALC m_clsAuditoriaDALC;
private clsEventoAuditoriaDALC m_clsEventoAuditoriaDALC;
private clsMenuDALC m_clsMenuDALC;
private clsMenuRolDALC m_clsMenuRolDALC;
private clsParametroDALC m_clsParametroDALC;
private clsParametroSistemaDALC m_clsParametroSistemaDALC;
private clsPrivilegioDALC m_clsPrivilegioDALC;
private clsPrivilegioRolDALC m_clsPrivilegioRolDALC;
private clsRolDALC m_clsRolDALC;
private clsUsuarioDALC m_clsUsuarioDALC;

        #endregion

		public clsFachadaSAFseg(ref Comandos ejecutor)
        {
            this.m_EjecutorBaseDatos = ejecutor;
        }

        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }

   }//end Fachada

}//end namespace SAFseg