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
        public clsGrupoElemento consultarEntidadGrupoElemento(SentenciaSQL sql)
        {
            m_clsGrupoElementoDALC = new clsGrupoElementoDALC(m_EjecutorBaseDatos);
            return m_clsGrupoElementoDALC.Consultar(sql);
        }

        public DataTable consultarDatosGrupoElemento(SentenciaSQL sql)
        {
            m_clsGrupoElementoDALC = new clsGrupoElementoDALC(m_EjecutorBaseDatos);
            return m_clsGrupoElementoDALC.datatableConsultar(sql);
        }

        public List<clsGrupoElemento> consultarListaGrupoElemento(SentenciaSQL sql)
        {
            m_clsGrupoElementoDALC = new clsGrupoElementoDALC(m_EjecutorBaseDatos);
            return m_clsGrupoElementoDALC.listConsultar(sql);
        }

        public int insertarGrupoElemento(clsGrupoElemento obj)
        {
            m_clsGrupoElementoDALC = new clsGrupoElementoDALC(m_EjecutorBaseDatos);
            return m_clsGrupoElementoDALC.Insertar(obj);
        }

        public int editarGrupoElemento(clsGrupoElemento obj, SentenciaSQL sql)
        {
            m_clsGrupoElementoDALC = new clsGrupoElementoDALC(m_EjecutorBaseDatos);
            return m_clsGrupoElementoDALC.Editar(obj, sql);
        }

        public int eliminarGrupoElemento(clsGrupoElemento obj, SentenciaSQL sql)
        {
            m_clsGrupoElementoDALC = new clsGrupoElementoDALC(m_EjecutorBaseDatos);
            return m_clsGrupoElementoDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore