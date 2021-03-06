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
        public clsPrivilegio consultarEntidadPrivilegio(SentenciaSQL sql)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.Consultar(sql);
        }

        public DataTable consultarDatosPrivilegio(SentenciaSQL sql)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.datatableConsultar(sql);
        }

        public List<clsPrivilegio> consultarListaPrivilegio(SentenciaSQL sql)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.listConsultar(sql);
        }

        public int insertarPrivilegio(clsPrivilegio obj)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.Insertar(obj);
        }

        public int editarPrivilegio(clsPrivilegio obj, SentenciaSQL sql)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.Editar(obj, sql);
        }

        public int eliminarPrivilegio(clsPrivilegio obj, SentenciaSQL sql)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore