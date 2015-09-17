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
        #region DetalleOrdenServicio
public clsDetalleOrdenServicio consultarEntidadDetalleOrdenServicio(SentenciaSQL sql){
m_clsDetalleOrdenServicioDALC = new clsDetalleOrdenServicioDALC(m_EjecutorBaseDatos);
return m_clsDetalleOrdenServicioDALC.Consultar(sql);
} 

public DataTable consultarDatosDetalleOrdenServicio(SentenciaSQL sql){
m_clsDetalleOrdenServicioDALC = new clsDetalleOrdenServicioDALC(m_EjecutorBaseDatos);
return m_clsDetalleOrdenServicioDALC.datatableConsultar(sql);
} 

public List<clsDetalleOrdenServicio> consultarListaDetalleOrdenServicio(SentenciaSQL sql){
m_clsDetalleOrdenServicioDALC = new clsDetalleOrdenServicioDALC(m_EjecutorBaseDatos);
return m_clsDetalleOrdenServicioDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore