///////////////////////////////////////////////////////////
//  clsFachadaSAF.cs
//  Implementation of the Class Fachada SAF
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using BaseDatos;

namespace SAFCore {

    public partial class clsFachadaSAF
    {
        private Comandos m_EjecutorBaseDatos;
        #region Miembros
        private clsAuditoriaDALC m_clsAuditoriaDALC;
private clsEventoAuditoriaDALC m_clsEventoAuditoriaDALC;
private clsParametroDALC m_clsParametroDALC;
private clsParametroSistemaDALC m_clsParametroSistemaDALC;
private clsPrivilegioDALC m_clsPrivilegioDALC;
private clsPrivilegioRolDALC m_clsPrivilegioRolDALC;
private clsRolDALC m_clsRolDALC;
private clsUsuarioDALC m_clsUsuarioDALC;

        #endregion

        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	
        #region Metodos

	#region Auditoria
public clsAuditoria consultarEntidadAuditoria(Dictionary<string, string> parametro){
return null;
} 

public clsAuditoria consultarDatosAuditoria(Dictionary<string, string> parametro){
return null;
} 

public clsAuditoria consultarListaAuditoria(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region EventoAuditoria
public clsEventoAuditoria consultarEntidadEventoAuditoria(Dictionary<string, string> parametro){
return null;
} 

public clsEventoAuditoria consultarDatosEventoAuditoria(Dictionary<string, string> parametro){
return null;
} 

public clsEventoAuditoria consultarListaEventoAuditoria(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Parametro
public clsParametro consultarEntidadParametro(Dictionary<string, string> parametro){
return null;
} 

public clsParametro consultarDatosParametro(Dictionary<string, string> parametro){
return null;
} 

public clsParametro consultarListaParametro(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region ParametroSistema
public clsParametroSistema consultarEntidadParametroSistema(Dictionary<string, string> parametro){
return null;
} 

public clsParametroSistema consultarDatosParametroSistema(Dictionary<string, string> parametro){
return null;
} 

public clsParametroSistema consultarListaParametroSistema(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Privilegio
public clsPrivilegio consultarEntidadPrivilegio(Dictionary<string, string> parametro){
return null;
} 

public clsPrivilegio consultarDatosPrivilegio(Dictionary<string, string> parametro){
return null;
} 

public clsPrivilegio consultarListaPrivilegio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region PrivilegioRol
public clsPrivilegioRol consultarEntidadPrivilegioRol(Dictionary<string, string> parametro){
return null;
} 

public clsPrivilegioRol consultarDatosPrivilegioRol(Dictionary<string, string> parametro){
return null;
} 

public clsPrivilegioRol consultarListaPrivilegioRol(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Rol
public clsRol consultarEntidadRol(Dictionary<string, string> parametro){
return null;
} 

public clsRol consultarDatosRol(Dictionary<string, string> parametro){
return null;
} 

public clsRol consultarListaRol(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Usuario
public clsUsuario consultarEntidadUsuario(Dictionary<string, string> parametro){
return null;
} 

public clsUsuario consultarDatosUsuario(Dictionary<string, string> parametro){
return null;
} 

public clsUsuario consultarListaUsuario(Dictionary<string, string> parametro){
return null;
} 

#endregion


        #endregion

   }//end DALC

}//end namespace SAFCore