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
        public clsDetalleListaPrecio consultarEntidadDetalleListaPrecio(SentenciaSQL sql)
        {
            m_clsDetalleListaPrecioDALC = new clsDetalleListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleListaPrecioDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleListaPrecio(SentenciaSQL sql)
        {
            m_clsDetalleListaPrecioDALC = new clsDetalleListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleListaPrecioDALC.datatableConsultar(sql);
        }

        public List<clsDetalleListaPrecio> consultarListaDetalleListaPrecio(SentenciaSQL sql)
        {
            m_clsDetalleListaPrecioDALC = new clsDetalleListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleListaPrecioDALC.listConsultar(sql);
        }

        public int insertarDetalleListaPrecio(clsDetalleListaPrecio obj)
        {
            m_clsDetalleListaPrecioDALC = new clsDetalleListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleListaPrecioDALC.Insertar(obj);
        }

        public int editarDetalleListaPrecio(clsDetalleListaPrecio obj, SentenciaSQL sql)
        {
            m_clsDetalleListaPrecioDALC = new clsDetalleListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleListaPrecioDALC.Editar(obj, sql);
        }

        public int eliminarDetalleListaPrecio(clsDetalleListaPrecio obj, SentenciaSQL sql)
        {
            m_clsDetalleListaPrecioDALC = new clsDetalleListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsDetalleListaPrecioDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore