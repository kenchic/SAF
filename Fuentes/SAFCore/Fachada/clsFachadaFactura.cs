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
        #region Factura
public clsFactura consultarEntidadFactura(SentenciaSQL sql){
m_clsFacturaDALC = new clsFacturaDALC(m_EjecutorBaseDatos);
return m_clsFacturaDALC.Consultar(sql);
} 

public DataTable consultarDatosFactura(SentenciaSQL sql){
m_clsFacturaDALC = new clsFacturaDALC(m_EjecutorBaseDatos);
return m_clsFacturaDALC.datatableConsultar(sql);
} 

public List<clsFactura> consultarListaFactura(SentenciaSQL sql){
m_clsFacturaDALC = new clsFacturaDALC(m_EjecutorBaseDatos);
return m_clsFacturaDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore