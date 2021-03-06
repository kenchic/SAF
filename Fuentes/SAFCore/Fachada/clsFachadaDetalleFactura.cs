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
        public clsDetalleFactura consultarEntidadDetalleFactura(SentenciaSQL sql)
        {
            m_clsDetalleFacturaDALC = new clsDetalleFacturaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleFacturaDALC.Consultar(sql);
        }

        public DataTable consultarDatosDetalleFactura(SentenciaSQL sql)
        {
            m_clsDetalleFacturaDALC = new clsDetalleFacturaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleFacturaDALC.datatableConsultar(sql);
        }

        public List<clsDetalleFactura> consultarListaDetalleFactura(SentenciaSQL sql)
        {
            m_clsDetalleFacturaDALC = new clsDetalleFacturaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleFacturaDALC.listConsultar(sql);
        }

        public int insertarDetalleFactura(clsDetalleFactura obj)
        {
            m_clsDetalleFacturaDALC = new clsDetalleFacturaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleFacturaDALC.Insertar(obj);
        }

        public int editarDetalleFactura(clsDetalleFactura obj, SentenciaSQL sql)
        {
            m_clsDetalleFacturaDALC = new clsDetalleFacturaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleFacturaDALC.Editar(obj, sql);
        }

        public int eliminarDetalleFactura(clsDetalleFactura obj, SentenciaSQL sql)
        {
            m_clsDetalleFacturaDALC = new clsDetalleFacturaDALC(m_EjecutorBaseDatos);
            return m_clsDetalleFacturaDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore