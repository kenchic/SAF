///////////////////////////////////////////////////////////
//  clsFachadaClaseBase.cs
//  Implementation of the Class clsFachadaClaseBase
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using BaseDatos;


namespace Seguridad.DALC {
	public class clsFachadaClaseBase {

        #region Miembros
		private clsEventoAuditoriaDALC m_clsEventoAuditoriaDALC;
		private clsPrivilegioDALC m_clsPrivilegioDALC;
		private clsPrivilegioRolDALC m_clsPrivilegioRolDALC;
		private clsRolDALC m_clsRolDALC;
		private clsUsuarioDALC m_clsUsuarioDALC;
        private Comandos m_EjecutorBaseDatos ;
        #endregion

        #region Constructores
        public clsFachadaClaseBase(Comandos ejecutor)
        {
            m_EjecutorBaseDatos = ejecutor;
        }

		~clsFachadaClaseBase(){

		}

		public virtual void Dispose(){

		}
        #endregion

        #region Usuario
        public List<clsUsuario> ConsultarUsuarios()
        {

            return null;
        }

        public clsUsuario ConsultarUsuariosAutenticacion(string usuario, string clave)
        {
            m_clsUsuarioDALC = new clsUsuarioDALC(m_EjecutorBaseDatos);
            m_clsUsuarioDALC.NombreProcedimiento = "SP_USUARIOS";
            var fabrica = new clsFabricaUsuario();
            var parametros = new Dictionary<string, string>();
            parametros.Add("Usuario",usuario);
            parametros.Add("Clave",clave);
            var usuarios = m_clsUsuarioDALC.ConsultarPorParametros(parametros, fabrica);
            if (usuarios.Count > 0)
                return usuarios[0];
            return null;
        }

        /// 
        /// <param name="obj"></param>
        public int EditarUsuario(clsUsuario obj)
        {

            return 0;
        }

        /// 
        /// <param name="obj"></param>
        public int EliminarUsuario(clsUsuario obj)
        {

            return 0;
        }

        /// 
        /// <param name="obj"></param>
        public int InsertarUsuario(clsUsuario obj)
        {

            return 0;
        }
        #endregion

		/// 
		/// <param name="Id"></param>
		public Seguridad.clsEventoAuditoria ConsultarEventoAuditoria(int Id){

			return null;
		}

		public List<clsEventoAuditoria> ConsultarEventosAuditorias(){

			return null;
		}

		/// 
		/// <param name="Id"></param>
		public Seguridad.clsPrivilegio ConsultarPrivilegio(int Id){

			return null;
		}

		/// 
		/// <param name="Id"></param>
		public Seguridad.clsPrivilegioRol ConsultarPrivilegioRol(int Id){

			return null;
		}

		public List<clsPrivilegio> ConsultarPrivilegios(){

			return null;
		}

		public List<clsPrivilegioRol> ConsultarPrivilegiosRoles(){

			return null;
		}

		/// 
		/// <param name="Id"></param>
		public Seguridad.clsRol ConsultarRol(int Id){

			return null;
		}

		public List<clsRol> ConsultarRoles(){

			return null;
		}

		/// 
		/// <param name="Id"></param>
		public Seguridad.clsUsuario ConsultarUsuario(int Id){

			return null;
		}


        /// 
		/// <param name="obj"></param>
		public int EditarEventoAuditoria(clsEventoAuditoria obj){

			return 0;
		}

		/// 
		/// <param name="obj"></param>
		public int EditarPrivilegio(clsPrivilegio obj){

			return 0;
		}

		/// 
		/// <param name="obj"></param>
		public int EditarPrivilegioRol(clsPrivilegioRol obj){

			return 0;
		}

		/// 
		/// <param name="obj"></param>
		public int EditarRol(clsRol obj){

			return 0;
		}

		

		/// 
		/// <param name="obj"></param>
		public int EliminarEventoAuditoria(clsEventoAuditoria obj){

			return 0;
		}

		/// 
		/// <param name="obj"></param>
		public int EliminarPrivilegio(clsPrivilegio obj){

			return 0;
		}

		/// 
		/// <param name="obj"></param>
		public int EliminarPrivilegioRol(clsPrivilegioRol obj){

			return 0;
		}

		/// 
		/// <param name="obj"></param>
		public int EliminarRol(clsRol obj){

			return 0;
		}

		

		/// 
		/// <param name="obj"></param>
		public int InsertarEventoAuditoria(clsEventoAuditoria obj){

			return 0;
		}

		/// 
		/// <param name="obj"></param>
		public int InsertarPrivilegio(clsPrivilegio obj){

			return 0;
		}

		/// 
		/// <param name="obj"></param>
		public int InsertarPrivilegioRol(clsPrivilegioRol obj){

			return 0;
		}

		/// 
		/// <param name="obj"></param>
		public int InsertarRol(clsRol obj){

			return 0;
		}

		

	}//end clsFachadaClaseBase

}//end namespace DALC