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
        public clsElemento consultarEntidadElemento(SentenciaSQL sql)
        {
            m_clsElementoDALC = new clsElementoDALC(m_EjecutorBaseDatos);
            return m_clsElementoDALC.Consultar(sql);
        }

        public DataTable consultarDatosElemento(SentenciaSQL sql)
        {
            m_clsElementoDALC = new clsElementoDALC(m_EjecutorBaseDatos);
            return m_clsElementoDALC.datatableConsultar(sql);
        }

        public List<clsElemento> consultarListaElemento(SentenciaSQL sql)
        {
            m_clsElementoDALC = new clsElementoDALC(m_EjecutorBaseDatos);
            return m_clsElementoDALC.listConsultar(sql);
        }

        public int insertarElemento(clsElemento obj)
        {
            m_clsElementoDALC = new clsElementoDALC(m_EjecutorBaseDatos);
            return m_clsElementoDALC.Insertar(obj);
        }

        public int editarElemento(clsElemento obj, SentenciaSQL sql)
        {
            m_clsElementoDALC = new clsElementoDALC(m_EjecutorBaseDatos);
            return m_clsElementoDALC.Editar(obj, sql);
        }

        public int eliminarElemento(clsElemento obj, SentenciaSQL sql)
        {
            m_clsElementoDALC = new clsElementoDALC(m_EjecutorBaseDatos);
            return m_clsElementoDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore