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
        public clsTipoDocumento consultarEntidadTipoDocumento(SentenciaSQL sql)
        {
            m_clsTipoDocumentoDALC = new clsTipoDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsTipoDocumentoDALC.Consultar(sql);
        }

        public DataTable consultarDatosTipoDocumento(SentenciaSQL sql)
        {
            m_clsTipoDocumentoDALC = new clsTipoDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsTipoDocumentoDALC.datatableConsultar(sql);
        }

        public List<clsTipoDocumento> consultarListaTipoDocumento(SentenciaSQL sql)
        {
            m_clsTipoDocumentoDALC = new clsTipoDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsTipoDocumentoDALC.listConsultar(sql);
        }

        public int insertarTipoDocumento(clsTipoDocumento obj)
        {
            m_clsTipoDocumentoDALC = new clsTipoDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsTipoDocumentoDALC.Insertar(obj);
        }

        public int editarTipoDocumento(clsTipoDocumento obj, SentenciaSQL sql)
        {
            m_clsTipoDocumentoDALC = new clsTipoDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsTipoDocumentoDALC.Editar(obj, sql);
        }

        public int eliminarTipoDocumento(clsTipoDocumento obj, SentenciaSQL sql)
        {
            m_clsTipoDocumentoDALC = new clsTipoDocumentoDALC(m_EjecutorBaseDatos);
            return m_clsTipoDocumentoDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore