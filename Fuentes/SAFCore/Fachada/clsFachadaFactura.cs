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
        public clsFactura consultarEntidadFactura(SentenciaSQL sql)
        {
            m_clsFacturaDALC = new clsFacturaDALC(m_EjecutorBaseDatos);
            return m_clsFacturaDALC.Consultar(sql);
        }

        public DataTable consultarDatosFactura(SentenciaSQL sql)
        {
            m_clsFacturaDALC = new clsFacturaDALC(m_EjecutorBaseDatos);
            return m_clsFacturaDALC.datatableConsultar(sql);
        }

        public List<clsFactura> consultarListaFactura(SentenciaSQL sql)
        {
            m_clsFacturaDALC = new clsFacturaDALC(m_EjecutorBaseDatos);
            return m_clsFacturaDALC.listConsultar(sql);
        }

        public int insertarFactura(clsFactura obj)
        {
            m_clsFacturaDALC = new clsFacturaDALC(m_EjecutorBaseDatos);
            return m_clsFacturaDALC.Insertar(obj);
        }

        public int editarFactura(clsFactura obj, SentenciaSQL sql)
        {
            m_clsFacturaDALC = new clsFacturaDALC(m_EjecutorBaseDatos);
            return m_clsFacturaDALC.Editar(obj, sql);
        }

        public int eliminarFactura(clsFactura obj, SentenciaSQL sql)
        {
            m_clsFacturaDALC = new clsFacturaDALC(m_EjecutorBaseDatos);
            return m_clsFacturaDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore