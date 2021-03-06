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
        public clsDetalleReposicion consultarEntidadDetalleReposicion(SentenciaSQL sql)
        {
            m_clsDetalleReposicionDALC = new clsDetalleReposicionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleReposicionDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleReposicion(SentenciaSQL sql)
        {
            m_clsDetalleReposicionDALC = new clsDetalleReposicionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleReposicionDALC.datatableConsultar(sql);
        }

        public List<clsDetalleReposicion> consultarListaDetalleReposicion(SentenciaSQL sql)
        {
            m_clsDetalleReposicionDALC = new clsDetalleReposicionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleReposicionDALC.listConsultar(sql);
        }

        public int insertarDetalleReposicion(clsDetalleReposicion obj)
        {
            m_clsDetalleReposicionDALC = new clsDetalleReposicionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleReposicionDALC.Insertar(obj);
        }

        public int editarDetalleReposicion(clsDetalleReposicion obj, SentenciaSQL sql)
        {
            m_clsDetalleReposicionDALC = new clsDetalleReposicionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleReposicionDALC.Editar(obj, sql);
        }

        public int eliminarDetalleReposicion(clsDetalleReposicion obj, SentenciaSQL sql)
        {
            m_clsDetalleReposicionDALC = new clsDetalleReposicionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleReposicionDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore