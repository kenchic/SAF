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
        #region Metodos
        #region Auditoria
public clsAuditoria consultarEntidadAuditoria(SentenciaSQL sql){
m_clsAuditoriaDALC = new clsAuditoriaDALC(m_EjecutorBaseDatos);
return m_clsAuditoriaDALC.Consultar(sql);
} 

public DataTable consultarDatosAuditoria(SentenciaSQL sql){
m_clsAuditoriaDALC = new clsAuditoriaDALC(m_EjecutorBaseDatos);
return m_clsAuditoriaDALC.datatableConsultar(sql);
} 

public List<clsAuditoria> consultarListaAuditoria(SentenciaSQL sql){
m_clsAuditoriaDALC = new clsAuditoriaDALC(m_EjecutorBaseDatos);
return m_clsAuditoriaDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore