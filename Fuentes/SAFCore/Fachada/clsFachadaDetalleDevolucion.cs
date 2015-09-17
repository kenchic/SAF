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
        #region DetalleDevolucion
public clsDetalleDevolucion consultarEntidadDetalleDevolucion(SentenciaSQL sql){
m_clsDetalleDevolucionDALC = new clsDetalleDevolucionDALC(m_EjecutorBaseDatos);
return m_clsDetalleDevolucionDALC.Consultar(sql);
} 

public DataTable consultarDatosDetalleDevolucion(SentenciaSQL sql){
m_clsDetalleDevolucionDALC = new clsDetalleDevolucionDALC(m_EjecutorBaseDatos);
return m_clsDetalleDevolucionDALC.datatableConsultar(sql);
} 

public List<clsDetalleDevolucion> consultarListaDetalleDevolucion(SentenciaSQL sql){
m_clsDetalleDevolucionDALC = new clsDetalleDevolucionDALC(m_EjecutorBaseDatos);
return m_clsDetalleDevolucionDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore