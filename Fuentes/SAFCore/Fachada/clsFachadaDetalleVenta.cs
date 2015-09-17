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
        #region DetalleVenta
public clsDetalleVenta consultarEntidadDetalleVenta(SentenciaSQL sql){
m_clsDetalleVentaDALC = new clsDetalleVentaDALC(m_EjecutorBaseDatos);
return m_clsDetalleVentaDALC.Consultar(sql);
} 

public DataTable consultarDatosDetalleVenta(SentenciaSQL sql){
m_clsDetalleVentaDALC = new clsDetalleVentaDALC(m_EjecutorBaseDatos);
return m_clsDetalleVentaDALC.datatableConsultar(sql);
} 

public List<clsDetalleVenta> consultarListaDetalleVenta(SentenciaSQL sql){
m_clsDetalleVentaDALC = new clsDetalleVentaDALC(m_EjecutorBaseDatos);
return m_clsDetalleVentaDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore