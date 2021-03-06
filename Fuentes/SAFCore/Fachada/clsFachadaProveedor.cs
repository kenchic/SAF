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
        public clsProveedor consultarEntidadProveedor(SentenciaSQL sql)
        {
            m_clsProveedorDALC = new clsProveedorDALC(m_EjecutorBaseDatos);
            return m_clsProveedorDALC.Consultar(sql);
        }

        public DataTable consultarDatosProveedor(SentenciaSQL sql)
        {
            m_clsProveedorDALC = new clsProveedorDALC(m_EjecutorBaseDatos);
            return m_clsProveedorDALC.datatableConsultar(sql);
        }

        public List<clsProveedor> consultarListaProveedor(SentenciaSQL sql)
        {
            m_clsProveedorDALC = new clsProveedorDALC(m_EjecutorBaseDatos);
            return m_clsProveedorDALC.listConsultar(sql);
        }

        public int insertarProveedor(clsProveedor obj)
        {
            m_clsProveedorDALC = new clsProveedorDALC(m_EjecutorBaseDatos);
            return m_clsProveedorDALC.Insertar(obj);
        }

        public int editarProveedor(clsProveedor obj, SentenciaSQL sql)
        {
            m_clsProveedorDALC = new clsProveedorDALC(m_EjecutorBaseDatos);
            return m_clsProveedorDALC.Editar(obj, sql);
        }

        public int eliminarProveedor(clsProveedor obj, SentenciaSQL sql)
        {
            m_clsProveedorDALC = new clsProveedorDALC(m_EjecutorBaseDatos);
            return m_clsProveedorDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore