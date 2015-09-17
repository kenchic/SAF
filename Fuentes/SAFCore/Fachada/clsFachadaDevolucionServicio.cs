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
        #region DevolucionServicio
public clsDevolucionServicio consultarEntidadDevolucionServicio(SentenciaSQL sql){
m_clsDevolucionServicioDALC = new clsDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsDevolucionServicioDALC.Consultar(sql);
} 

public DataTable consultarDatosDevolucionServicio(SentenciaSQL sql){
m_clsDevolucionServicioDALC = new clsDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsDevolucionServicioDALC.datatableConsultar(sql);
} 

public List<clsDevolucionServicio> consultarListaDevolucionServicio(SentenciaSQL sql){
m_clsDevolucionServicioDALC = new clsDevolucionServicioDALC(m_EjecutorBaseDatos);
return m_clsDevolucionServicioDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore