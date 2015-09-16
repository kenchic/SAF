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
        #region Parametro
public clsParametro consultarEntidadParametro(SentenciaSQL sql){
m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
return m_clsParametroDALC.Consultar(sql);
} 

public DataTable consultarDatosParametro(SentenciaSQL sql){
m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
return m_clsParametroDALC.datatableConsultar(sql);
} 

public List<clsParametro> consultarListaParametro(SentenciaSQL sql){
m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
return m_clsParametroDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore