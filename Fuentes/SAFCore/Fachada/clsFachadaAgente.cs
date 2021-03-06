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
        public clsAgente consultarEntidadAgente(SentenciaSQL sql)
        {
            m_clsAgenteDALC = new clsAgenteDALC(m_EjecutorBaseDatos);
            return m_clsAgenteDALC.Consultar(sql);
        }

        public DataTable consultarDatosAgente(SentenciaSQL sql)
        {
            m_clsAgenteDALC = new clsAgenteDALC(m_EjecutorBaseDatos);
            return m_clsAgenteDALC.datatableConsultar(sql);
        }

        public List<clsAgente> consultarListaAgente(SentenciaSQL sql)
        {
            m_clsAgenteDALC = new clsAgenteDALC(m_EjecutorBaseDatos);
            return m_clsAgenteDALC.listConsultar(sql);
        }

        public int insertarAgente(clsAgente obj)
        {
            m_clsAgenteDALC = new clsAgenteDALC(m_EjecutorBaseDatos);
            return m_clsAgenteDALC.Insertar(obj);
        }

        public int editarAgente(clsAgente obj, SentenciaSQL sql)
        {
            m_clsAgenteDALC = new clsAgenteDALC(m_EjecutorBaseDatos);
            return m_clsAgenteDALC.Editar(obj, sql);
        }

        public int eliminarAgente(clsAgente obj, SentenciaSQL sql)
        {
            m_clsAgenteDALC = new clsAgenteDALC(m_EjecutorBaseDatos);
            return m_clsAgenteDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore