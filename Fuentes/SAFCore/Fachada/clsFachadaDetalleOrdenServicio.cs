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
        public clsDetalleOrdenServicio consultarEntidadDetalleOrdenServicio(SentenciaSQL sql)
        {
            m_clsDetalleOrdenServicioDALC = new clsDetalleOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleOrdenServicioDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleOrdenServicio(SentenciaSQL sql)
        {
            m_clsDetalleOrdenServicioDALC = new clsDetalleOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleOrdenServicioDALC.datatableConsultar(sql);
        }

        public List<clsDetalleOrdenServicio> consultarListaDetalleOrdenServicio(SentenciaSQL sql)
        {
            m_clsDetalleOrdenServicioDALC = new clsDetalleOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleOrdenServicioDALC.listConsultar(sql);
        }

        public int insertarDetalleOrdenServicio(clsDetalleOrdenServicio obj)
        {
            m_clsDetalleOrdenServicioDALC = new clsDetalleOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleOrdenServicioDALC.Insertar(obj);
        }

        public int editarDetalleOrdenServicio(clsDetalleOrdenServicio obj, SentenciaSQL sql)
        {
            m_clsDetalleOrdenServicioDALC = new clsDetalleOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleOrdenServicioDALC.Editar(obj, sql);
        }

        public int eliminarDetalleOrdenServicio(clsDetalleOrdenServicio obj, SentenciaSQL sql)
        {
            m_clsDetalleOrdenServicioDALC = new clsDetalleOrdenServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleOrdenServicioDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore