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
        #region Mantenimiento
public clsMantenimiento consultarEntidadMantenimiento(SentenciaSQL sql){
m_clsMantenimientoDALC = new clsMantenimientoDALC(m_EjecutorBaseDatos);
return m_clsMantenimientoDALC.Consultar(sql);
} 

public DataTable consultarDatosMantenimiento(SentenciaSQL sql){
m_clsMantenimientoDALC = new clsMantenimientoDALC(m_EjecutorBaseDatos);
return m_clsMantenimientoDALC.datatableConsultar(sql);
} 

public List<clsMantenimiento> consultarListaMantenimiento(SentenciaSQL sql){
m_clsMantenimientoDALC = new clsMantenimientoDALC(m_EjecutorBaseDatos);
return m_clsMantenimientoDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore