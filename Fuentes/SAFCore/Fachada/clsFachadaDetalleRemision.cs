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
        public clsDetalleRemision consultarEntidadDetalleRemision(SentenciaSQL sql)
        {
            m_clsDetalleRemisionDALC = new clsDetalleRemisionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleRemisionDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleRemision(SentenciaSQL sql)
        {
            m_clsDetalleRemisionDALC = new clsDetalleRemisionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleRemisionDALC.datatableConsultar(sql);
        }

        public List<clsDetalleRemision> consultarListaDetalleRemision(SentenciaSQL sql)
        {
            m_clsDetalleRemisionDALC = new clsDetalleRemisionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleRemisionDALC.listConsultar(sql);
        }

        public int insertarDetalleRemision(clsDetalleRemision obj)
        {
            m_clsDetalleRemisionDALC = new clsDetalleRemisionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleRemisionDALC.Insertar(obj);
        }

        public int editarDetalleRemision(clsDetalleRemision obj, SentenciaSQL sql)
        {
            m_clsDetalleRemisionDALC = new clsDetalleRemisionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleRemisionDALC.Editar(obj, sql);
        }

        public int eliminarDetalleRemision(clsDetalleRemision obj, SentenciaSQL sql)
        {
            m_clsDetalleRemisionDALC = new clsDetalleRemisionDALC(m_EjecutorBaseDatos);
            return m_clsDetalleRemisionDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore