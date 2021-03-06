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
        public clsPrivilegioRol consultarEntidadPrivilegioRol(SentenciaSQL sql)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.Consultar(sql);
        }

        public DataTable consultarDatosPrivilegioRol(SentenciaSQL sql)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.datatableConsultar(sql);
        }

        public List<clsPrivilegioRol> consultarListaPrivilegioRol(SentenciaSQL sql)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.listConsultar(sql);
        }

        public int insertarPrivilegioRol(clsPrivilegioRol obj)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.Insertar(obj);
        }

        public int editarPrivilegioRol(clsPrivilegioRol obj, SentenciaSQL sql)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.Editar(obj, sql);
        }

        public int eliminarPrivilegioRol(clsPrivilegioRol obj, SentenciaSQL sql)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore