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
        public clsDetalleDocumento consultarEntidadDetalleDocumento(SentenciaSQL sql)
        {
            m_clsDetalleDocumentoDALC = new clsDetalleDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDocumentoDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleDocumento(SentenciaSQL sql)
        {
            m_clsDetalleDocumentoDALC = new clsDetalleDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDocumentoDALC.datatableConsultar(sql);
        }

        public List<clsDetalleDocumento> consultarListaDetalleDocumento(SentenciaSQL sql)
        {
            m_clsDetalleDocumentoDALC = new clsDetalleDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDocumentoDALC.listConsultar(sql);
        }

        public int insertarDetalleDocumento(clsDetalleDocumento obj)
        {
            m_clsDetalleDocumentoDALC = new clsDetalleDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDocumentoDALC.Insertar(obj);
        }

        public int editarDetalleDocumento(clsDetalleDocumento obj, SentenciaSQL sql)
        {
            m_clsDetalleDocumentoDALC = new clsDetalleDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDocumentoDALC.Editar(obj, sql);
        }

        public int eliminarDetalleDocumento(clsDetalleDocumento obj, SentenciaSQL sql)
        {
            m_clsDetalleDocumentoDALC = new clsDetalleDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDocumentoDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore