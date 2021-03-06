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
        public clsDetalleMantenimiento consultarEntidadDetalleMantenimiento(SentenciaSQL sql)
        {
            m_clsDetalleMantenimientoDALC = new clsDetalleMantenimientoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleMantenimientoDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleMantenimiento(SentenciaSQL sql)
        {
            m_clsDetalleMantenimientoDALC = new clsDetalleMantenimientoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleMantenimientoDALC.datatableConsultar(sql);
        }

        public List<clsDetalleMantenimiento> consultarListaDetalleMantenimiento(SentenciaSQL sql)
        {
            m_clsDetalleMantenimientoDALC = new clsDetalleMantenimientoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleMantenimientoDALC.listConsultar(sql);
        }

        public int insertarDetalleMantenimiento(clsDetalleMantenimiento obj)
        {
            m_clsDetalleMantenimientoDALC = new clsDetalleMantenimientoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleMantenimientoDALC.Insertar(obj);
        }

        public int editarDetalleMantenimiento(clsDetalleMantenimiento obj, SentenciaSQL sql)
        {
            m_clsDetalleMantenimientoDALC = new clsDetalleMantenimientoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleMantenimientoDALC.Editar(obj, sql);
        }

        public int eliminarDetalleMantenimiento(clsDetalleMantenimiento obj, SentenciaSQL sql)
        {
            m_clsDetalleMantenimientoDALC = new clsDetalleMantenimientoDALC(m_EjecutorBaseDatos);
            return m_clsDetalleMantenimientoDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore