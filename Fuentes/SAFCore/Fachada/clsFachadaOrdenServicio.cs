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
        public clsOrdenServicio consultarEntidadOrdenServicio(SentenciaSQL sql)
        {
            m_clsOrdenServicioDALC = new clsOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsOrdenServicioDALC.Consultar(sql);
        }

        public DataTable consultarDatosOrdenServicio(SentenciaSQL sql)
        {
            m_clsOrdenServicioDALC = new clsOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsOrdenServicioDALC.datatableConsultar(sql);
        }

        public List<clsOrdenServicio> consultarListaOrdenServicio(SentenciaSQL sql)
        {
            m_clsOrdenServicioDALC = new clsOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsOrdenServicioDALC.listConsultar(sql);
        }

        public int insertarOrdenServicio(clsOrdenServicio obj)
        {
            m_clsOrdenServicioDALC = new clsOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsOrdenServicioDALC.Insertar(obj);
        }

        public int editarOrdenServicio(clsOrdenServicio obj, SentenciaSQL sql)
        {
            m_clsOrdenServicioDALC = new clsOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsOrdenServicioDALC.Editar(obj, sql);
        }

        public int eliminarOrdenServicio(clsOrdenServicio obj, SentenciaSQL sql)
        {
            m_clsOrdenServicioDALC = new clsOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsOrdenServicioDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore