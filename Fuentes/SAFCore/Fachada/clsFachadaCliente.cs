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
        #region Cliente
public clsCliente consultarEntidadCliente(SentenciaSQL sql){
m_clsClienteDALC = new clsClienteDALC(m_EjecutorBaseDatos);
return m_clsClienteDALC.Consultar(sql);
} 

public DataTable consultarDatosCliente(SentenciaSQL sql){
m_clsClienteDALC = new clsClienteDALC(m_EjecutorBaseDatos);
return m_clsClienteDALC.datatableConsultar(sql);
} 

public List<clsCliente> consultarListaCliente(SentenciaSQL sql){
m_clsClienteDALC = new clsClienteDALC(m_EjecutorBaseDatos);
return m_clsClienteDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore