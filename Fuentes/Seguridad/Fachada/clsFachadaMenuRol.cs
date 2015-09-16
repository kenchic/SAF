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
        #region MenuRol
public clsMenuRol consultarEntidadMenuRol(SentenciaSQL sql){
m_clsMenuRolDALC = new clsMenuRolDALC(m_EjecutorBaseDatos);
return m_clsMenuRolDALC.Consultar(sql);
} 

public DataTable consultarDatosMenuRol(SentenciaSQL sql){
m_clsMenuRolDALC = new clsMenuRolDALC(m_EjecutorBaseDatos);
return m_clsMenuRolDALC.datatableConsultar(sql);
} 

public List<clsMenuRol> consultarListaMenuRol(SentenciaSQL sql){
m_clsMenuRolDALC = new clsMenuRolDALC(m_EjecutorBaseDatos);
return m_clsMenuRolDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore