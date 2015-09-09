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
        private clsMenuDALC m_clsMenuDALC;
        private clsMenuRolDALC m_clsMenuRolDALC;
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
        public clsAuditoria consultarEntidadAuditoria(SentenciaSQL sql)
        {
            m_clsAuditoriaDALC = new clsAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsAuditoriaDALC.Consultar(sql);
        }

        public DataTable consultarDatosAuditoria(SentenciaSQL sql)
        {
            m_clsAuditoriaDALC = new clsAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsAuditoriaDALC.datatableConsultar(sql);
        }

        public List<clsAuditoria> consultarListaAuditoria(SentenciaSQL sql)
        {
            m_clsAuditoriaDALC = new clsAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsAuditoriaDALC.listConsultar(sql);
        }

        #endregion
        #region EventoAuditoria
        public clsEventoAuditoria consultarEntidadEventoAuditoria(SentenciaSQL sql)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.Consultar(sql);
        }

        public DataTable consultarDatosEventoAuditoria(SentenciaSQL sql)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.datatableConsultar(sql);
        }

        public List<clsEventoAuditoria> consultarListaEventoAuditoria(SentenciaSQL sql)
        {
            m_clsEventoAuditoriaDALC = new clsEventoAuditoriaDALC(m_EjecutorBaseDatos);
            return m_clsEventoAuditoriaDALC.listConsultar(sql);
        }

        #endregion
        #region Menu
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

        #endregion
        #region MenuRol
        public clsMenuRol consultarEntidadMenuRol(SentenciaSQL sql)
        {
            m_clsMenuRolDALC = new clsMenuRolDALC(m_EjecutorBaseDatos);
            return m_clsMenuRolDALC.Consultar(sql);
        }

        public DataTable consultarDatosMenuRol(SentenciaSQL sql)
        {
            m_clsMenuRolDALC = new clsMenuRolDALC(m_EjecutorBaseDatos);
            return m_clsMenuRolDALC.datatableConsultar(sql);
        }

        public List<clsMenuRol> consultarListaMenuRol(SentenciaSQL sql)
        {
            m_clsMenuRolDALC = new clsMenuRolDALC(m_EjecutorBaseDatos);
            return m_clsMenuRolDALC.listConsultar(sql);
        }

        #endregion
        #region Parametro
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

        #endregion
        #region ParametroSistema
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

        #endregion
        #region Privilegio
        public clsPrivilegio consultarEntidadPrivilegio(SentenciaSQL sql)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.Consultar(sql);
        }

        public DataTable consultarDatosPrivilegio(SentenciaSQL sql)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.datatableConsultar(sql);
        }

        public List<clsPrivilegio> consultarListaPrivilegio(SentenciaSQL sql)
        {
            m_clsPrivilegioDALC = new clsPrivilegioDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioDALC.listConsultar(sql);
        }

        #endregion
        #region PrivilegioRol
        public clsPrivilegioRol consultarEntidadPrivilegioRol(SentenciaSQL sql)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.Consultar(sql);
        }

        public DataTable consultarDatosPrivilegioRol(SentenciaSQL sql)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.datatableConsultar(sql);
        }

        public List<clsPrivilegioRol> consultarListaPrivilegioRol(SentenciaSQL sql)
        {
            m_clsPrivilegioRolDALC = new clsPrivilegioRolDALC(m_EjecutorBaseDatos);
            return m_clsPrivilegioRolDALC.listConsultar(sql);
        }

        #endregion
        #region Rol
        public clsRol consultarEntidadRol(SentenciaSQL sql)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.Consultar(sql);
        }

        public DataTable consultarDatosRol(SentenciaSQL sql)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.datatableConsultar(sql);
        }

        public List<clsRol> consultarListaRol(SentenciaSQL sql)
        {
            m_clsRolDALC = new clsRolDALC(m_EjecutorBaseDatos);
            return m_clsRolDALC.listConsultar(sql);
        }

        #endregion
        #region Usuario
        public clsUsuario consultarEntidadUsuario(SentenciaSQL sql)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.Consultar(sql);
        }

        public DataTable consultarDatosUsuario(SentenciaSQL sql)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.datatableConsultar(sql);
        }

        public List<clsUsuario> consultarListaUsuario(SentenciaSQL sql)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            return m_clsUsuarioDALC.listConsultar(sql);
        }

        #endregion

        #endregion

    }//end DALC

}//end namespace SAFCore