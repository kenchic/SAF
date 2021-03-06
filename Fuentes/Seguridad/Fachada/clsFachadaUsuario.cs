///////////////////////////////////////////////////////////
//  clsFachada.cs
//  Implementation of the Class Fachada SAFseg
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using BaseDatos;

namespace SAFseg {

    public partial class clsFachadaSAFseg
    {
        #region Metodos
        public clsUsuario consultarEntidadUsuario(SentenciaSQL sql)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.Consultar(sql);
        }

        public DataTable consultarDatosUsuario(SentenciaSQL sql)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.datatableConsultar(sql);
        }

        public List<clsUsuario> consultarListaUsuario(SentenciaSQL sql)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.listConsultar(sql);
        }

        public int insertarUsuario(clsUsuario obj)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.Insertar(obj);
        }

        public int editarUsuario(clsUsuario obj, SentenciaSQL sql)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.Editar(obj, sql);
        }

        public int eliminarUsuario(clsUsuario obj, SentenciaSQL sql)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore