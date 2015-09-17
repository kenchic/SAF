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
        #region DetalleFactura
public clsDetalleFactura consultarEntidadDetalleFactura(SentenciaSQL sql){
m_clsDetalleFacturaDALC = new clsDetalleFacturaDALC(m_EjecutorBaseDatos);
return m_clsDetalleFacturaDALC.Consultar(sql);
} 

public DataTable consultarDatosDetalleFactura(SentenciaSQL sql){
m_clsDetalleFacturaDALC = new clsDetalleFacturaDALC(m_EjecutorBaseDatos);
return m_clsDetalleFacturaDALC.datatableConsultar(sql);
} 

public List<clsDetalleFactura> consultarListaDetalleFactura(SentenciaSQL sql){
m_clsDetalleFacturaDALC = new clsDetalleFacturaDALC(m_EjecutorBaseDatos);
return m_clsDetalleFacturaDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore