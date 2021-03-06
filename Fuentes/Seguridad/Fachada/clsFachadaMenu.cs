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
        public clsMenu consultarEntidadMenu(SentenciaSQL sql)
        {
            m_clsMenuDALC = new clsMenuDALC(m_EjecutorBaseDatos);
            return m_clsMenuDALC.Consultar(sql);
        }

        public DataTable consultarDatosMenu(SentenciaSQL sql)
        {
            m_clsMenuDALC = new clsMenuDALC(m_EjecutorBaseDatos);
            return m_clsMenuDALC.datatableConsultar(sql);
        }

        public List<clsMenu> consultarListaMenu(SentenciaSQL sql)
        {
            m_clsMenuDALC = new clsMenuDALC(m_EjecutorBaseDatos);
            return m_clsMenuDALC.listConsultar(sql);
        }

        public int insertarMenu(clsMenu obj)
        {
            m_clsMenuDALC = new clsMenuDALC(m_EjecutorBaseDatos);
            return m_clsMenuDALC.Insertar(obj);
        }

        public int editarMenu(clsMenu obj, SentenciaSQL sql)
        {
            m_clsMenuDALC = new clsMenuDALC(m_EjecutorBaseDatos);
            return m_clsMenuDALC.Editar(obj, sql);
        }

        public int eliminarMenu(clsMenu obj, SentenciaSQL sql)
        {
            m_clsMenuDALC = new clsMenuDALC(m_EjecutorBaseDatos);
            return m_clsMenuDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore