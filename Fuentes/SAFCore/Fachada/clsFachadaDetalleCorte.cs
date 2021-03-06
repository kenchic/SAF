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
        public clsDetalleCorte consultarEntidadDetalleCorte(SentenciaSQL sql)
        {
            m_clsDetalleCorteDALC = new clsDetalleCorteDALC(m_EjecutorBaseDatos);
            return m_clsDetalleCorteDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleCorte(SentenciaSQL sql)
        {
            m_clsDetalleCorteDALC = new clsDetalleCorteDALC(m_EjecutorBaseDatos);
            return m_clsDetalleCorteDALC.datatableConsultar(sql);
        }

        public List<clsDetalleCorte> consultarListaDetalleCorte(SentenciaSQL sql)
        {
            m_clsDetalleCorteDALC = new clsDetalleCorteDALC(m_EjecutorBaseDatos);
            return m_clsDetalleCorteDALC.listConsultar(sql);
        }

        public int insertarDetalleCorte(clsDetalleCorte obj)
        {
            m_clsDetalleCorteDALC = new clsDetalleCorteDALC(m_EjecutorBaseDatos);
            return m_clsDetalleCorteDALC.Insertar(obj);
        }

        public int editarDetalleCorte(clsDetalleCorte obj, SentenciaSQL sql)
        {
            m_clsDetalleCorteDALC = new clsDetalleCorteDALC(m_EjecutorBaseDatos);
            return m_clsDetalleCorteDALC.Editar(obj, sql);
        }

        public int eliminarDetalleCorte(clsDetalleCorte obj, SentenciaSQL sql)
        {
            m_clsDetalleCorteDALC = new clsDetalleCorteDALC(m_EjecutorBaseDatos);
            return m_clsDetalleCorteDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore