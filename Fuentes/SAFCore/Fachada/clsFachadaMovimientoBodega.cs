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
        public clsMovimientoBodega consultarEntidadMovimientoBodega(SentenciaSQL sql)
        {
            m_clsMovimientoBodegaDALC = new clsMovimientoBodegaDALC(m_EjecutorBaseDatos);
            return m_clsMovimientoBodegaDALC.Consultar(sql);
        }

        public DataTable consultarDatosMovimientoBodega(SentenciaSQL sql)
        {
            m_clsMovimientoBodegaDALC = new clsMovimientoBodegaDALC(m_EjecutorBaseDatos);
            return m_clsMovimientoBodegaDALC.datatableConsultar(sql);
        }

        public List<clsMovimientoBodega> consultarListaMovimientoBodega(SentenciaSQL sql)
        {
            m_clsMovimientoBodegaDALC = new clsMovimientoBodegaDALC(m_EjecutorBaseDatos);
            return m_clsMovimientoBodegaDALC.listConsultar(sql);
        }

        public int insertarMovimientoBodega(clsMovimientoBodega obj)
        {
            m_clsMovimientoBodegaDALC = new clsMovimientoBodegaDALC(m_EjecutorBaseDatos);
            return m_clsMovimientoBodegaDALC.Insertar(obj);
        }

        public int editarMovimientoBodega(clsMovimientoBodega obj, SentenciaSQL sql)
        {
            m_clsMovimientoBodegaDALC = new clsMovimientoBodegaDALC(m_EjecutorBaseDatos);
            return m_clsMovimientoBodegaDALC.Editar(obj, sql);
        }

        public int eliminarMovimientoBodega(clsMovimientoBodega obj, SentenciaSQL sql)
        {
            m_clsMovimientoBodegaDALC = new clsMovimientoBodegaDALC(m_EjecutorBaseDatos);
            return m_clsMovimientoBodegaDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore