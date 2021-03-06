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
        public clsDetalleDevolucionServicio consultarEntidadDetalleDevolucionServicio(SentenciaSQL sql)
        {
            m_clsDetalleDevolucionServicioDALC = new clsDetalleDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDevolucionServicioDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleDevolucionServicio(SentenciaSQL sql)
        {
            m_clsDetalleDevolucionServicioDALC = new clsDetalleDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDevolucionServicioDALC.datatableConsultar(sql);
        }

        public List<clsDetalleDevolucionServicio> consultarListaDetalleDevolucionServicio(SentenciaSQL sql)
        {
            m_clsDetalleDevolucionServicioDALC = new clsDetalleDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDevolucionServicioDALC.listConsultar(sql);
        }

        public int insertarDetalleDevolucionServicio(clsDetalleDevolucionServicio obj)
        {
            m_clsDetalleDevolucionServicioDALC = new clsDetalleDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDevolucionServicioDALC.Insertar(obj);
        }

        public int editarDetalleDevolucionServicio(clsDetalleDevolucionServicio obj, SentenciaSQL sql)
        {
            m_clsDetalleDevolucionServicioDALC = new clsDetalleDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDevolucionServicioDALC.Editar(obj, sql);
        }

        public int eliminarDetalleDevolucionServicio(clsDetalleDevolucionServicio obj, SentenciaSQL sql)
        {
            m_clsDetalleDevolucionServicioDALC = new clsDetalleDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleDevolucionServicioDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore