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
        public clsRol consultarEntidadRol(SentenciaSQL sql)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.Consultar(sql);
        }

        public DataTable consultarDatosRol(SentenciaSQL sql)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.datatableConsultar(sql);
        }

        public List<clsRol> consultarListaRol(SentenciaSQL sql)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.listConsultar(sql);
        }

        public int insertarRol(clsRol obj)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.Insertar(obj);
        }

        public int editarRol(clsRol obj, SentenciaSQL sql)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.Editar(obj, sql);
        }

        public int eliminarRol(clsRol obj, SentenciaSQL sql)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore