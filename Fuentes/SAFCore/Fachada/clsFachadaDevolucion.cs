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
        #region Devolucion
public clsDevolucion consultarEntidadDevolucion(SentenciaSQL sql){
m_clsDevolucionDALC = new clsDevolucionDALC(m_EjecutorBaseDatos);
return m_clsDevolucionDALC.Consultar(sql);
} 

public DataTable consultarDatosDevolucion(SentenciaSQL sql){
m_clsDevolucionDALC = new clsDevolucionDALC(m_EjecutorBaseDatos);
return m_clsDevolucionDALC.datatableConsultar(sql);
} 

public List<clsDevolucion> consultarListaDevolucion(SentenciaSQL sql){
m_clsDevolucionDALC = new clsDevolucionDALC(m_EjecutorBaseDatos);
return m_clsDevolucionDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore