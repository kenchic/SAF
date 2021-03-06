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
        public clsProyectoAlquiler consultarEntidadProyectoAlquiler(SentenciaSQL sql)
        {
            m_clsProyectoAlquilerDALC = new clsProyectoAlquilerDALC(m_EjecutorBaseDatos);
            return m_clsProyectoAlquilerDALC.Consultar(sql);
        }

        public DataTable consultarDatosProyectoAlquiler(SentenciaSQL sql)
        {
            m_clsProyectoAlquilerDALC = new clsProyectoAlquilerDALC(m_EjecutorBaseDatos);
            return m_clsProyectoAlquilerDALC.datatableConsultar(sql);
        }

        public List<clsProyectoAlquiler> consultarListaProyectoAlquiler(SentenciaSQL sql)
        {
            m_clsProyectoAlquilerDALC = new clsProyectoAlquilerDALC(m_EjecutorBaseDatos);
            return m_clsProyectoAlquilerDALC.listConsultar(sql);
        }

        public int insertarProyectoAlquiler(clsProyectoAlquiler obj)
        {
            m_clsProyectoAlquilerDALC = new clsProyectoAlquilerDALC(m_EjecutorBaseDatos);
            return m_clsProyectoAlquilerDALC.Insertar(obj);
        }

        public int editarProyectoAlquiler(clsProyectoAlquiler obj, SentenciaSQL sql)
        {
            m_clsProyectoAlquilerDALC = new clsProyectoAlquilerDALC(m_EjecutorBaseDatos);
            return m_clsProyectoAlquilerDALC.Editar(obj, sql);
        }

        public int eliminarProyectoAlquiler(clsProyectoAlquiler obj, SentenciaSQL sql)
        {
            m_clsProyectoAlquilerDALC = new clsProyectoAlquilerDALC(m_EjecutorBaseDatos);
            return m_clsProyectoAlquilerDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore