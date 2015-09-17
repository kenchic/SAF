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
        #region Ciudad
public clsCiudad consultarEntidadCiudad(SentenciaSQL sql){
m_clsCiudadDALC = new clsCiudadDALC(m_EjecutorBaseDatos);
return m_clsCiudadDALC.Consultar(sql);
} 

public DataTable consultarDatosCiudad(SentenciaSQL sql){
m_clsCiudadDALC = new clsCiudadDALC(m_EjecutorBaseDatos);
return m_clsCiudadDALC.datatableConsultar(sql);
} 

public List<clsCiudad> consultarListaCiudad(SentenciaSQL sql){
m_clsCiudadDALC = new clsCiudadDALC(m_EjecutorBaseDatos);
return m_clsCiudadDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore