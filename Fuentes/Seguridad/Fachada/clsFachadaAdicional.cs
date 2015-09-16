///////////////////////////////////////////////////////////
//  clsFachadaSAF.cs
//  Implementation of the Class Fachada SAF
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using BaseDatos;

namespace SAFseg
{
    public partial class clsFachadaSAFSegAdicional
    {
        private Comandos m_EjecutorBaseDatos;
        #region Miembros
        private clsMenuAdicionalDALC m_clsMenuAdicionalDALC;
        #endregion

        public clsFachadaSAFSegAdicional(ref Comandos ejecutor)
        {
            this.m_EjecutorBaseDatos = ejecutor;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #region MenuRol
        public List<clsMenu> consultarListaMenuRol(SentenciaSQL sql)
        {
            m_clsMenuAdicionalDALC = new clsMenuAdicionalDALC(m_EjecutorBaseDatos);
            return m_clsMenuAdicionalDALC.listConsultar(sql);
        }

        public DataTable consultarDatosMenuRol(SentenciaSQL sql)
        {
            m_clsMenuAdicionalDALC = new clsMenuAdicionalDALC(m_EjecutorBaseDatos);
            return m_clsMenuAdicionalDALC.datatableConsultar(sql);
        }
        #endregion
    }
}
