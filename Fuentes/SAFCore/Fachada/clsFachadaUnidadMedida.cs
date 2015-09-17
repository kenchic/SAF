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
        #region UnidadMedida
public clsUnidadMedida consultarEntidadUnidadMedida(SentenciaSQL sql){
m_clsUnidadMedidaDALC = new clsUnidadMedidaDALC(m_EjecutorBaseDatos);
return m_clsUnidadMedidaDALC.Consultar(sql);
} 

public DataTable consultarDatosUnidadMedida(SentenciaSQL sql){
m_clsUnidadMedidaDALC = new clsUnidadMedidaDALC(m_EjecutorBaseDatos);
return m_clsUnidadMedidaDALC.datatableConsultar(sql);
} 

public List<clsUnidadMedida> consultarListaUnidadMedida(SentenciaSQL sql){
m_clsUnidadMedidaDALC = new clsUnidadMedidaDALC(m_EjecutorBaseDatos);
return m_clsUnidadMedidaDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore