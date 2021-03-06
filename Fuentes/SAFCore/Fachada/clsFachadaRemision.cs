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
        public clsRemision consultarEntidadRemision(SentenciaSQL sql)
        {
            m_clsRemisionDALC = new clsRemisionDALC(m_EjecutorBaseDatos);
            return m_clsRemisionDALC.Consultar(sql);
        }

        public DataTable consultarDatosRemision(SentenciaSQL sql)
        {
            m_clsRemisionDALC = new clsRemisionDALC(m_EjecutorBaseDatos);
            return m_clsRemisionDALC.datatableConsultar(sql);
        }

        public List<clsRemision> consultarListaRemision(SentenciaSQL sql)
        {
            m_clsRemisionDALC = new clsRemisionDALC(m_EjecutorBaseDatos);
            return m_clsRemisionDALC.listConsultar(sql);
        }

        public int insertarRemision(clsRemision obj)
        {
            m_clsRemisionDALC = new clsRemisionDALC(m_EjecutorBaseDatos);
            return m_clsRemisionDALC.Insertar(obj);
        }

        public int editarRemision(clsRemision obj, SentenciaSQL sql)
        {
            m_clsRemisionDALC = new clsRemisionDALC(m_EjecutorBaseDatos);
            return m_clsRemisionDALC.Editar(obj, sql);
        }

        public int eliminarRemision(clsRemision obj, SentenciaSQL sql)
        {
            m_clsRemisionDALC = new clsRemisionDALC(m_EjecutorBaseDatos);
            return m_clsRemisionDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore