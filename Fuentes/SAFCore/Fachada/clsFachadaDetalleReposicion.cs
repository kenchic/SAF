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
        #region DetalleReposicion
public clsDetalleReposicion consultarEntidadDetalleReposicion(SentenciaSQL sql){
m_clsDetalleReposicionDALC = new clsDetalleReposicionDALC(m_EjecutorBaseDatos);
return m_clsDetalleReposicionDALC.Consultar(sql);
} 

public DataTable consultarDatosDetalleReposicion(SentenciaSQL sql){
m_clsDetalleReposicionDALC = new clsDetalleReposicionDALC(m_EjecutorBaseDatos);
return m_clsDetalleReposicionDALC.datatableConsultar(sql);
} 

public List<clsDetalleReposicion> consultarListaDetalleReposicion(SentenciaSQL sql){
m_clsDetalleReposicionDALC = new clsDetalleReposicionDALC(m_EjecutorBaseDatos);
return m_clsDetalleReposicionDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore