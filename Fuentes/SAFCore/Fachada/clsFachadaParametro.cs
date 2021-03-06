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
        public clsParametro consultarEntidadParametro(SentenciaSQL sql)
        {
            m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
            return m_clsParametroDALC.Consultar(sql);
        }

        public DataTable consultarDatosParametro(SentenciaSQL sql)
        {
            m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
            return m_clsParametroDALC.datatableConsultar(sql);
        }

        public List<clsParametro> consultarListaParametro(SentenciaSQL sql)
        {
            m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
            return m_clsParametroDALC.listConsultar(sql);
        }

        public int insertarParametro(clsParametro obj)
        {
            m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
            return m_clsParametroDALC.Insertar(obj);
        }

        public int editarParametro(clsParametro obj, SentenciaSQL sql)
        {
            m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
            return m_clsParametroDALC.Editar(obj, sql);
        }

        public int eliminarParametro(clsParametro obj, SentenciaSQL sql)
        {
            m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
            return m_clsParametroDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore