///////////////////////////////////////////////////////////
//  clsFachada.cs
//  Implementation of the Class Fachada SAFcore
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using BaseDatos;

namespace SAFcore {

    public partial class clsFachadaSAFcore
    {
        #region Metodos
        #region Reposicion
public clsReposicion consultarEntidadReposicion(SentenciaSQL sql){
m_clsReposicionDALC = new clsReposicionDALC(m_EjecutorBaseDatos);
return m_clsReposicionDALC.Consultar(sql);
} 

public DataTable consultarDatosReposicion(SentenciaSQL sql){
m_clsReposicionDALC = new clsReposicionDALC(m_EjecutorBaseDatos);
return m_clsReposicionDALC.datatableConsultar(sql);
} 

public List<clsReposicion> consultarListaReposicion(SentenciaSQL sql){
m_clsReposicionDALC = new clsReposicionDALC(m_EjecutorBaseDatos);
return m_clsReposicionDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore