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
        public clsProyectoVenta consultarEntidadProyectoVenta(SentenciaSQL sql)
        {
            m_clsProyectoVentaDALC = new clsProyectoVentaDALC(m_EjecutorBaseDatos);
            return m_clsProyectoVentaDALC.Consultar(sql);
        }

        public DataTable consultarDatosProyectoVenta(SentenciaSQL sql)
        {
            m_clsProyectoVentaDALC = new clsProyectoVentaDALC(m_EjecutorBaseDatos);
            return m_clsProyectoVentaDALC.datatableConsultar(sql);
        }

        public List<clsProyectoVenta> consultarListaProyectoVenta(SentenciaSQL sql)
        {
            m_clsProyectoVentaDALC = new clsProyectoVentaDALC(m_EjecutorBaseDatos);
            return m_clsProyectoVentaDALC.listConsultar(sql);
        }

        public int insertarProyectoVenta(clsProyectoVenta obj)
        {
            m_clsProyectoVentaDALC = new clsProyectoVentaDALC(m_EjecutorBaseDatos);
            return m_clsProyectoVentaDALC.Insertar(obj);
        }

        public int editarProyectoVenta(clsProyectoVenta obj, SentenciaSQL sql)
        {
            m_clsProyectoVentaDALC = new clsProyectoVentaDALC(m_EjecutorBaseDatos);
            return m_clsProyectoVentaDALC.Editar(obj, sql);
        }

        public int eliminarProyectoVenta(clsProyectoVenta obj, SentenciaSQL sql)
        {
            m_clsProyectoVentaDALC = new clsProyectoVentaDALC(m_EjecutorBaseDatos);
            return m_clsProyectoVentaDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore