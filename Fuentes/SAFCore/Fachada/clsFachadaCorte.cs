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
        #region Corte
public clsCorte consultarEntidadCorte(SentenciaSQL sql){
m_clsCorteDALC = new clsCorteDALC(m_EjecutorBaseDatos);
return m_clsCorteDALC.Consultar(sql);
} 

public DataTable consultarDatosCorte(SentenciaSQL sql){
m_clsCorteDALC = new clsCorteDALC(m_EjecutorBaseDatos);
return m_clsCorteDALC.datatableConsultar(sql);
} 

public List<clsCorte> consultarListaCorte(SentenciaSQL sql){
m_clsCorteDALC = new clsCorteDALC(m_EjecutorBaseDatos);
return m_clsCorteDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore