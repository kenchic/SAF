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
        #region Venta
public clsVenta consultarEntidadVenta(SentenciaSQL sql){
m_clsVentaDALC = new clsVentaDALC(m_EjecutorBaseDatos);
return m_clsVentaDALC.Consultar(sql);
} 

public DataTable consultarDatosVenta(SentenciaSQL sql){
m_clsVentaDALC = new clsVentaDALC(m_EjecutorBaseDatos);
return m_clsVentaDALC.datatableConsultar(sql);
} 

public List<clsVenta> consultarListaVenta(SentenciaSQL sql){
m_clsVentaDALC = new clsVentaDALC(m_EjecutorBaseDatos);
return m_clsVentaDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore