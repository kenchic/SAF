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
        #region DetalleRepDevolucionServicio
public clsDetalleRepDevolucionServicio consultarEntidadDetalleRepDevolucionServicio(SentenciaSQL sql){
m_clsDetalleRepDevolucionServicioDALC = new clsDetalleRepDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsDetalleRepDevolucionServicioDALC.Consultar(sql);
} 

public DataTable consultarDatosDetalleRepDevolucionServicio(SentenciaSQL sql){
m_clsDetalleRepDevolucionServicioDALC = new clsDetalleRepDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsDetalleRepDevolucionServicioDALC.datatableConsultar(sql);
} 

public List<clsDetalleRepDevolucionServicio> consultarListaDetalleRepDevolucionServicio(SentenciaSQL sql){
m_clsDetalleRepDevolucionServicioDALC = new clsDetalleRepDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsDetalleRepDevolucionServicioDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore