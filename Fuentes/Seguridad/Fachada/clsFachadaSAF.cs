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

    public partial class clsFachadaSAF
    {
        private Comandos m_EjecutorBaseDatos;
        #region Miembros
        private clsAuditoriaDALC m_clsAuditoriaDALC;
        private clsEventoAuditoriaDALC m_clsEventoAuditoriaDALC;
        private clsParametroDALC m_clsParametroDALC;
        private clsParametroSistemaDALC m_clsParametroSistemaDALC;
        private clsPrivilegioDALC m_clsPrivilegioDALC;
        private clsPrivilegioRolDALC m_clsPrivilegioRolDALC;
        private clsRolDALC m_clsRolDALC;
        private clsUsuarioDALC m_clsUsuarioDALC;        
        #endregion

        public clsFachadaSAF(ref Comandos ejecutor)
        {
            this.m_EjecutorBaseDatos = ejecutor;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #region Metodos
        #region Auditoria
        public clsAuditoria consultarEntidadAuditoria(List<ParametroBD> parametros)
        {
            m_clsAuditoriaDALC = new clsAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsAuditoriaDALC.Consultar(parametros);
        }

        public DataTable consultarDatosAuditoria(List<ParametroBD> parametros)
        {
            m_clsAuditoriaDALC = new clsAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsAuditoriaDALC.datatableConsultar(parametros);
        }

        public List<clsAuditoria> consultarListaAuditoria(List<ParametroBD> parametros)
        {
            m_clsAuditoriaDALC = new clsAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsAuditoriaDALC.listConsultar(parametros);
        }

        #endregion
        #region EventoAuditoria
        public clsEventoAuditoria consultarEntidadEventoAuditoria(List<ParametroBD> parametros)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.Consultar(parametros);
        }

        public DataTable consultarDatosEventoAuditoria(List<ParametroBD> parametros)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.datatableConsultar(parametros);
        }

        public List<clsEventoAuditoria> consultarListaEventoAuditoria(List<ParametroBD> parametros)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.listConsultar(parametros);
        }

        #endregion
        #region Parametro
        public clsParametro consultarEntidadParametro(List<ParametroBD> parametros)
        {
            m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
            return m_clsParametroDALC.Consultar(parametros);
        }

        public DataTable consultarDatosParametro(List<ParametroBD> parametros)
        {
            m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
            return m_clsParametroDALC.datatableConsultar(parametros);
        }

        public List<clsParametro> consultarListaParametro(List<ParametroBD> parametros)
        {
            m_clsParametroDALC = new clsParametroDALC(m_EjecutorBaseDatos);
            return m_clsParametroDALC.listConsultar(parametros);
        }

        #endregion
        #region ParametroSistema
        public clsParametroSistema consultarEntidadParametroSistema(List<ParametroBD> parametros)
        {
            m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
            return m_clsParametroSistemaDALC.Consultar(parametros);
        }

        public DataTable consultarDatosParametroSistema(List<ParametroBD> parametros)
        {
            m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
            return m_clsParametroSistemaDALC.datatableConsultar(parametros);
        }

        public List<clsParametroSistema> consultarListaParametroSistema(List<ParametroBD> parametros)
        {
            m_clsParametroSistemaDALC = new clsParametroSistemaDALC(m_EjecutorBaseDatos);
            return m_clsParametroSistemaDALC.listConsultar(parametros);
        }

        #endregion
        #region Privilegio
        public clsPrivilegio consultarEntidadPrivilegio(List<ParametroBD> parametros)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.Consultar(parametros);
        }

        public DataTable consultarDatosPrivilegio(List<ParametroBD> parametros)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.datatableConsultar(parametros);
        }

        public List<clsPrivilegio> consultarListaPrivilegio(List<ParametroBD> parametros)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.listConsultar(parametros);
        }

        #endregion
        #region PrivilegioRol
        public clsPrivilegioRol consultarEntidadPrivilegioRol(List<ParametroBD> parametros)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.Consultar(parametros);
        }

        public DataTable consultarDatosPrivilegioRol(List<ParametroBD> parametros)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.datatableConsultar(parametros);
        }

        public List<clsPrivilegioRol> consultarListaPrivilegioRol(List<ParametroBD> parametros)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.listConsultar(parametros);
        }

        #endregion
        #region Rol
        public clsRol consultarEntidadRol(List<ParametroBD> parametros)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.Consultar(parametros);
        }

        public DataTable consultarDatosRol(List<ParametroBD> parametros)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.datatableConsultar(parametros);
        }

        public List<clsRol> consultarListaRol(List<ParametroBD> parametros)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.listConsultar(parametros);
        }

        #endregion
        #region Usuario
        public clsUsuario consultarEntidadUsuario(List<ParametroBD> parametros)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.Consultar(parametros);
        }

        public DataTable consultarDatosUsuario(List<ParametroBD> parametros)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.datatableConsultar(parametros);
        }

        public List<clsUsuario> consultarListaUsuario(List<ParametroBD> parametros)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.listConsultar(parametros);
        }

        #endregion

        #endregion

    }//end DALC

}//end namespace SAFCore