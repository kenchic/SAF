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
        public clsReposicion consultarEntidadReposicion(SentenciaSQL sql)
        {
            m_clsReposicionDALC = new clsReposicionDALC(m_EjecutorBaseDatos);
            return m_clsReposicionDALC.Consultar(sql);
        }

        public DataTable consultarDatosReposicion(SentenciaSQL sql)
        {
            m_clsReposicionDALC = new clsReposicionDALC(m_EjecutorBaseDatos);
            return m_clsReposicionDALC.datatableConsultar(sql);
        }

        public List<clsReposicion> consultarListaReposicion(SentenciaSQL sql)
        {
            m_clsReposicionDALC = new clsReposicionDALC(m_EjecutorBaseDatos);
            return m_clsReposicionDALC.listConsultar(sql);
        }

        public int insertarReposicion(clsReposicion obj)
        {
            m_clsReposicionDALC = new clsReposicionDALC(m_EjecutorBaseDatos);
            return m_clsReposicionDALC.Insertar(obj);
        }

        public int editarReposicion(clsReposicion obj, SentenciaSQL sql)
        {
            m_clsReposicionDALC = new clsReposicionDALC(m_EjecutorBaseDatos);
            return m_clsReposicionDALC.Editar(obj, sql);
        }

        public int eliminarReposicion(clsReposicion obj, SentenciaSQL sql)
        {
            m_clsReposicionDALC = new clsReposicionDALC(m_EjecutorBaseDatos);
            return m_clsReposicionDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore