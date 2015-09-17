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
        #region Bodega
public clsBodega consultarEntidadBodega(SentenciaSQL sql){
m_clsBodegaDALC = new clsBodegaDALC(m_EjecutorBaseDatos);
return m_clsBodegaDALC.Consultar(sql);
} 

public DataTable consultarDatosBodega(SentenciaSQL sql){
m_clsBodegaDALC = new clsBodegaDALC(m_EjecutorBaseDatos);
return m_clsBodegaDALC.datatableConsultar(sql);
} 

public List<clsBodega> consultarListaBodega(SentenciaSQL sql){
m_clsBodegaDALC = new clsBodegaDALC(m_EjecutorBaseDatos);
return m_clsBodegaDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore