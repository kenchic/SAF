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
        public clsListaPrecio consultarEntidadListaPrecio(SentenciaSQL sql)
        {
            m_clsListaPrecioDALC = new clsListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsListaPrecioDALC.Consultar(sql);
        }

        public DataTable consultarDatosListaPrecio(SentenciaSQL sql)
        {
            m_clsListaPrecioDALC = new clsListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsListaPrecioDALC.datatableConsultar(sql);
        }

        public List<clsListaPrecio> consultarListaListaPrecio(SentenciaSQL sql)
        {
            m_clsListaPrecioDALC = new clsListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsListaPrecioDALC.listConsultar(sql);
        }

        public int insertarListaPrecio(clsListaPrecio obj)
        {
            m_clsListaPrecioDALC = new clsListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsListaPrecioDALC.Insertar(obj);
        }

        public int editarListaPrecio(clsListaPrecio obj, SentenciaSQL sql)
        {
            m_clsListaPrecioDALC = new clsListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsListaPrecioDALC.Editar(obj, sql);
        }

        public int eliminarListaPrecio(clsListaPrecio obj, SentenciaSQL sql)
        {
            m_clsListaPrecioDALC = new clsListaPrecioDALC(m_EjecutorBaseDatos);
            return m_clsListaPrecioDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore