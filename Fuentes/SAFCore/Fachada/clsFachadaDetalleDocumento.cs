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
        #region DetalleDocumento
public clsDetalleDocumento consultarEntidadDetalleDocumento(SentenciaSQL sql){
m_clsDetalleDocumentoDALC = new clsDetalleDocumentoDALC(m_EjecutorBaseDatos);
return m_clsDetalleDocumentoDALC.Consultar(sql);
} 

public DataTable consultarDatosDetalleDocumento(SentenciaSQL sql){
m_clsDetalleDocumentoDALC = new clsDetalleDocumentoDALC(m_EjecutorBaseDatos);
return m_clsDetalleDocumentoDALC.datatableConsultar(sql);
} 

public List<clsDetalleDocumento> consultarListaDetalleDocumento(SentenciaSQL sql){
m_clsDetalleDocumentoDALC = new clsDetalleDocumentoDALC(m_EjecutorBaseDatos);
return m_clsDetalleDocumentoDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore