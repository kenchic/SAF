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
        #region ListaPrecio
public clsListaPrecio consultarEntidadListaPrecio(SentenciaSQL sql){
m_clsListaPrecioDALC = new clsListaPrecioDALC(m_EjecutorBaseDatos);
return m_clsListaPrecioDALC.Consultar(sql);
} 

public DataTable consultarDatosListaPrecio(SentenciaSQL sql){
m_clsListaPrecioDALC = new clsListaPrecioDALC(m_EjecutorBaseDatos);
return m_clsListaPrecioDALC.datatableConsultar(sql);
} 

public List<clsListaPrecio> consultarListaListaPrecio(SentenciaSQL sql){
m_clsListaPrecioDALC = new clsListaPrecioDALC(m_EjecutorBaseDatos);
return m_clsListaPrecioDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore