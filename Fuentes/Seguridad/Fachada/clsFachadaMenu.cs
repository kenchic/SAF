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
        #region Menu
public clsMenu consultarEntidadMenu(SentenciaSQL sql){
m_clsMenuDALC = new clsMenuDALC(m_EjecutorBaseDatos);
return m_clsMenuDALC.Consultar(sql);
} 

public DataTable consultarDatosMenu(SentenciaSQL sql){
m_clsMenuDALC = new clsMenuDALC(m_EjecutorBaseDatos);
return m_clsMenuDALC.datatableConsultar(sql);
} 

public List<clsMenu> consultarListaMenu(SentenciaSQL sql){
m_clsMenuDALC = new clsMenuDALC(m_EjecutorBaseDatos);
return m_clsMenuDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore