using System;
using System.Data.Common;

namespace Datos
{
    /// <summary>
    /// Clase para crear y manejar la conexion con la Base de Datos
    /// </summary>
    public abstract class Conexion
    {
        #region "Miembros"
        protected string m_strconexion;
        protected string m_proveedor;
        protected DbConnection m_conexion;
        private const string DEFPROVEEDOR = "System.Data.SqlClient";
        #endregion

        #region "Constructores"
        /// <summary>
        /// COnstructor por defecto
        /// </summary>
        public Conexion()
        {
            m_strconexion = "";
            m_conexion = null;
            m_proveedor = DEFPROVEEDOR;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="strconexion">Cadena de conexion con la base de datos</param>
        /// <param name="proveedor">Proveedor de datos. Ej:System.Data.SqlClient</param>
        public Conexion(string strconexion, string proveedor)
        {
            if (string.IsNullOrEmpty(strconexion))
                strconexion = "";
            if (string.IsNullOrEmpty(proveedor))
                proveedor = DEFPROVEEDOR;
            m_strconexion = strconexion;
            m_proveedor = proveedor;
            m_conexion = this.crearConexion();
            m_conexion.ConnectionString = m_strconexion;
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Retorna la fabrica del proveedor
        /// </summary>
        /// <returns></returns>
        protected DbProviderFactory obtenerFabrica()
        {
            return DbProviderFactories.GetFactory(m_proveedor);
        }
        /// <summary>
        /// Retorna la nueva conexion
        /// </summary>
        /// <returns></returns>
        private DbConnection crearConexion()
        {
            return this.obtenerFabrica().CreateConnection();
        }
        /// <summary>
        /// Abre la conexion con la Base de Datos
        /// </summary>
        protected void abrir()
        {
            try
            {
                if (m_conexion.State == System.Data.ConnectionState.Closed)
                    this.m_conexion.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("No se logró abrir la conexión con la Base de Datos. " + ex.Message);
            }
        }
        /// <summary>
        /// Cierra la conexion con la Base de Datos
        /// </summary>
        protected void cerrar()
        {
            try
            {
                if (m_conexion.State != System.Data.ConnectionState.Closed)
                    this.m_conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("No se  logró cerrar la conexion con la Base de Datos. " + ex.Message);
            }
        }
        #endregion
    }
}
