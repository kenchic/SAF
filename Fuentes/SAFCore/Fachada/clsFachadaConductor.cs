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
        public clsConductor consultarEntidadConductor(SentenciaSQL sql)
        {
            m_clsConductorDALC = new clsConductorDALC(m_EjecutorBaseDatos);
            return m_clsConductorDALC.Consultar(sql);
        }

        public DataTable consultarDatosConductor(SentenciaSQL sql)
        {
            m_clsConductorDALC = new clsConductorDALC(m_EjecutorBaseDatos);
            return m_clsConductorDALC.datatableConsultar(sql);
        }

        public List<clsConductor> consultarListaConductor(SentenciaSQL sql)
        {
            m_clsConductorDALC = new clsConductorDALC(m_EjecutorBaseDatos);
            return m_clsConductorDALC.listConsultar(sql);
        }

        public int insertarConductor(clsConductor obj)
        {
            m_clsConductorDALC = new clsConductorDALC(m_EjecutorBaseDatos);
            return m_clsConductorDALC.Insertar(obj);
        }

        public int editarConductor(clsConductor obj, SentenciaSQL sql)
        {
            m_clsConductorDALC = new clsConductorDALC(m_EjecutorBaseDatos);
            return m_clsConductorDALC.Editar(obj, sql);
        }

        public int eliminarConductor(clsConductor obj, SentenciaSQL sql)
        {
            m_clsConductorDALC = new clsConductorDALC(m_EjecutorBaseDatos);
            return m_clsConductorDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore