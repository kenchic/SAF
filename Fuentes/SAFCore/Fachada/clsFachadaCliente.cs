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
        public clsCliente consultarEntidadCliente(SentenciaSQL sql)
        {
            m_clsClienteDALC = new clsClienteDALC(m_EjecutorBaseDatos);
            return m_clsClienteDALC.Consultar(sql);
        }

        public DataTable consultarDatosCliente(SentenciaSQL sql)
        {
            m_clsClienteDALC = new clsClienteDALC(m_EjecutorBaseDatos);
            return m_clsClienteDALC.datatableConsultar(sql);
        }

        public List<clsCliente> consultarListaCliente(SentenciaSQL sql)
        {
            m_clsClienteDALC = new clsClienteDALC(m_EjecutorBaseDatos);
            return m_clsClienteDALC.listConsultar(sql);
        }

        public int insertarCliente(clsCliente obj)
        {
            m_clsClienteDALC = new clsClienteDALC(m_EjecutorBaseDatos);
            return m_clsClienteDALC.Insertar(obj);
        }

        public int editarCliente(clsCliente obj, SentenciaSQL sql)
        {
            m_clsClienteDALC = new clsClienteDALC(m_EjecutorBaseDatos);
            return m_clsClienteDALC.Editar(obj, sql);
        }

        public int eliminarCliente(clsCliente obj, SentenciaSQL sql)
        {
            m_clsClienteDALC = new clsClienteDALC(m_EjecutorBaseDatos);
            return m_clsClienteDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore