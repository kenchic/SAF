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
        #region ParametroSistema
public clsParametroSistema consultarEntidadParametroSistema(SentenciaSQL sql){
m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
return m_clsParametroSistemaDALC.Consultar(sql);
} 

public DataTable consultarDatosParametroSistema(SentenciaSQL sql){
m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
return m_clsParametroSistemaDALC.datatableConsultar(sql);
} 

public List<clsParametroSistema> consultarListaParametroSistema(SentenciaSQL sql){
m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
return m_clsParametroSistemaDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore