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
        #region PrivilegioRol
public clsPrivilegioRol consultarEntidadPrivilegioRol(SentenciaSQL sql){
m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
return m_clsPrivilegioRolDALC.Consultar(sql);
} 

public DataTable consultarDatosPrivilegioRol(SentenciaSQL sql){
m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
return m_clsPrivilegioRolDALC.datatableConsultar(sql);
} 

public List<clsPrivilegioRol> consultarListaPrivilegioRol(SentenciaSQL sql){
m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
return m_clsPrivilegioRolDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore