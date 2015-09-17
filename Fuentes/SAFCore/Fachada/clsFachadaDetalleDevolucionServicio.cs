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
        #region DetalleDevolucionServicio
public clsDetalleDevolucionServicio consultarEntidadDetalleDevolucionServicio(SentenciaSQL sql){
m_clsDetalleDevolucionServicioDALC = new clsDetalleDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsDetalleDevolucionServicioDALC.Consultar(sql);
} 

public DataTable consultarDatosDetalleDevolucionServicio(SentenciaSQL sql){
m_clsDetalleDevolucionServicioDALC = new clsDetalleDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsDetalleDevolucionServicioDALC.datatableConsultar(sql);
} 

public List<clsDetalleDevolucionServicio> consultarListaDetalleDevolucionServicio(SentenciaSQL sql){
m_clsDetalleDevolucionServicioDALC = new clsDetalleDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsDetalleDevolucionServicioDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore