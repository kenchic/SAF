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
        public clsParametroSistema consultarEntidadParametroSistema(SentenciaSQL sql)
        {
            m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
            return m_clsParametroSistemaDALC.Consultar(sql);
        }

        public DataTable consultarDatosParametroSistema(SentenciaSQL sql)
        {
            m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
            return m_clsParametroSistemaDALC.datatableConsultar(sql);
        }

        public List<clsParametroSistema> consultarListaParametroSistema(SentenciaSQL sql)
        {
            m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
            return m_clsParametroSistemaDALC.listConsultar(sql);
        }

        public int insertarParametroSistema(clsParametroSistema obj)
        {
            m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
            return m_clsParametroSistemaDALC.Insertar(obj);
        }

        public int editarParametroSistema(clsParametroSistema obj, SentenciaSQL sql)
        {
            m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
            return m_clsParametroSistemaDALC.Editar(obj, sql);
        }

        public int eliminarParametroSistema(clsParametroSistema obj, SentenciaSQL sql)
        {
            m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
            return m_clsParametroSistemaDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore