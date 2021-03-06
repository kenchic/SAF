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
        public clsCorte consultarEntidadCorte(SentenciaSQL sql)
        {
            m_clsCorteDALC = new clsCorteDALC(m_EjecutorBaseDatos);
            return m_clsCorteDALC.Consultar(sql);
        }

        public DataTable consultarDatosCorte(SentenciaSQL sql)
        {
            m_clsCorteDALC = new clsCorteDALC(m_EjecutorBaseDatos);
            return m_clsCorteDALC.datatableConsultar(sql);
        }

        public List<clsCorte> consultarListaCorte(SentenciaSQL sql)
        {
            m_clsCorteDALC = new clsCorteDALC(m_EjecutorBaseDatos);
            return m_clsCorteDALC.listConsultar(sql);
        }

        public int insertarCorte(clsCorte obj)
        {
            m_clsCorteDALC = new clsCorteDALC(m_EjecutorBaseDatos);
            return m_clsCorteDALC.Insertar(obj);
        }

        public int editarCorte(clsCorte obj, SentenciaSQL sql)
        {
            m_clsCorteDALC = new clsCorteDALC(m_EjecutorBaseDatos);
            return m_clsCorteDALC.Editar(obj, sql);
        }

        public int eliminarCorte(clsCorte obj, SentenciaSQL sql)
        {
            m_clsCorteDALC = new clsCorteDALC(m_EjecutorBaseDatos);
            return m_clsCorteDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore