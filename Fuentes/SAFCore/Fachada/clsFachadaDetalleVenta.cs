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
        public clsDetalleVenta consultarEntidadDetalleVenta(SentenciaSQL sql)
        {
            m_clsDetalleVentaDALC = new clsDetalleVentaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleVentaDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleVenta(SentenciaSQL sql)
        {
            m_clsDetalleVentaDALC = new clsDetalleVentaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleVentaDALC.datatableConsultar(sql);
        }

        public List<clsDetalleVenta> consultarListaDetalleVenta(SentenciaSQL sql)
        {
            m_clsDetalleVentaDALC = new clsDetalleVentaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleVentaDALC.listConsultar(sql);
        }

        public int insertarDetalleVenta(clsDetalleVenta obj)
        {
            m_clsDetalleVentaDALC = new clsDetalleVentaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleVentaDALC.Insertar(obj);
        }

        public int editarDetalleVenta(clsDetalleVenta obj, SentenciaSQL sql)
        {
            m_clsDetalleVentaDALC = new clsDetalleVentaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleVentaDALC.Editar(obj, sql);
        }

        public int eliminarDetalleVenta(clsDetalleVenta obj, SentenciaSQL sql)
        {
            m_clsDetalleVentaDALC = new clsDetalleVentaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleVentaDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore