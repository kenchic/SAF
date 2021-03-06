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
        public clsProyecto consultarEntidadProyecto(SentenciaSQL sql)
        {
            m_clsProyectoDALC = new clsProyectoDALC(m_EjecutorBaseDatos);
            return m_clsProyectoDALC.Consultar(sql);
        }

        public DataTable consultarDatosProyecto(SentenciaSQL sql)
        {
            m_clsProyectoDALC = new clsProyectoDALC(m_EjecutorBaseDatos);
            return m_clsProyectoDALC.datatableConsultar(sql);
        }

        public List<clsProyecto> consultarListaProyecto(SentenciaSQL sql)
        {
            m_clsProyectoDALC = new clsProyectoDALC(m_EjecutorBaseDatos);
            return m_clsProyectoDALC.listConsultar(sql);
        }

        public int insertarProyecto(clsProyecto obj)
        {
            m_clsProyectoDALC = new clsProyectoDALC(m_EjecutorBaseDatos);
            return m_clsProyectoDALC.Insertar(obj);
        }

        public int editarProyecto(clsProyecto obj, SentenciaSQL sql)
        {
            m_clsProyectoDALC = new clsProyectoDALC(m_EjecutorBaseDatos);
            return m_clsProyectoDALC.Editar(obj, sql);
        }

        public int eliminarProyecto(clsProyecto obj, SentenciaSQL sql)
        {
            m_clsProyectoDALC = new clsProyectoDALC(m_EjecutorBaseDatos);
            return m_clsProyectoDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore