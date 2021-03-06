///////////////////////////////////////////////////////////
//  clsFachada.cs
//  Implementation of the Class Fachada SAFseg
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using BaseDatos;

namespace SAFseg {

    public partial class clsFachadaSAFseg
    {
        #region Metodos
        public clsEventoAuditoria consultarEntidadEventoAuditoria(SentenciaSQL sql)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.Consultar(sql);
        }

        public DataTable consultarDatosEventoAuditoria(SentenciaSQL sql)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.datatableConsultar(sql);
        }

        public List<clsEventoAuditoria> consultarListaEventoAuditoria(SentenciaSQL sql)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.listConsultar(sql);
        }

        public int insertarEventoAuditoria(clsEventoAuditoria obj)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.Insertar(obj);
        }

        public int editarEventoAuditoria(clsEventoAuditoria obj, SentenciaSQL sql)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.Editar(obj, sql);
        }

        public int eliminarEventoAuditoria(clsEventoAuditoria obj, SentenciaSQL sql)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore