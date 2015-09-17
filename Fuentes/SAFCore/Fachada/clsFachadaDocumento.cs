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
        #region Documento
public clsDocumento consultarEntidadDocumento(SentenciaSQL sql){
m_clsDocumentoDALC = new clsDocumentoDALC(m_EjecutorBaseDatos);
return m_clsDocumentoDALC.Consultar(sql);
} 

public DataTable consultarDatosDocumento(SentenciaSQL sql){
m_clsDocumentoDALC = new clsDocumentoDALC(m_EjecutorBaseDatos);
return m_clsDocumentoDALC.datatableConsultar(sql);
} 

public List<clsDocumento> consultarListaDocumento(SentenciaSQL sql){
m_clsDocumentoDALC = new clsDocumentoDALC(m_EjecutorBaseDatos);
return m_clsDocumentoDALC.listConsultar(sql);
} 

#endregion

        #endregion

   }//end DALC

}//end namespace SAFCore