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
        public clsContrato consultarEntidadContrato(SentenciaSQL sql)
        {
            m_clsContratoDALC = new clsContratoDALC(m_EjecutorBaseDatos);
            return m_clsContratoDALC.Consultar(sql);
        }

        public DataTable consultarDatosContrato(SentenciaSQL sql)
        {
            m_clsContratoDALC = new clsContratoDALC(m_EjecutorBaseDatos);
            return m_clsContratoDALC.datatableConsultar(sql);
        }

        public List<clsContrato> consultarListaContrato(SentenciaSQL sql)
        {
            m_clsContratoDALC = new clsContratoDALC(m_EjecutorBaseDatos);
            return m_clsContratoDALC.listConsultar(sql);
        }

        public int insertarContrato(clsContrato obj)
        {
            m_clsContratoDALC = new clsContratoDALC(m_EjecutorBaseDatos);
            return m_clsContratoDALC.Insertar(obj);
        }

        public int editarContrato(clsContrato obj, SentenciaSQL sql)
        {
            m_clsContratoDALC = new clsContratoDALC(m_EjecutorBaseDatos);
            return m_clsContratoDALC.Editar(obj, sql);
        }

        public int eliminarContrato(clsContrato obj, SentenciaSQL sql)
        {
            m_clsContratoDALC = new clsContratoDALC(m_EjecutorBaseDatos);
            return m_clsContratoDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore