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
        #region RepDevolucionServicio
public clsRepDevolucionServicio consultarEntidadRepDevolucionServicio(SentenciaSQL sql){
m_clsRepDevolucionServicioDALC = new clsRepDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsRepDevolucionServicioDALC.Consultar(sql);
} 

public DataTable consultarDatosRepDevolucionServicio(SentenciaSQL sql){
m_clsRepDevolucionServicioDALC = new clsRepDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsRepDevolucionServicioDALC.datatableConsultar(sql);
} 

public List<clsRepDevolucionServicio> consultarListaRepDevolucionServicio(SentenciaSQL sql){
m_clsRepDevolucionServicioDALC = new clsRepDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsRepDevolucionServicioDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore