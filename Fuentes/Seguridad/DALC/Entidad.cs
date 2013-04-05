///////////////////////////////////////////////////////////
//  Entidad.cs
//  Implementation of the Class Entidad
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using Datos;

namespace Seguridad.DALC {


    internal abstract class Entidad<T> where T : ClaseBase, new()
    {
		private Comandos m_ejecutor_base_datos;
        private string m_nombre_procedimiento;

		~Entidad(){

		}

		public virtual void Dispose(){

		}

		/// 
		/// <param name="ejecutorBaseDatos"></param>
		public  Entidad(Comandos ejecutorBaseDatos){

		}

		public Entidad(){

		}

		/// 
		/// <param name="Id"></param>
        internal virtual T Consultar(int Id)
        {

			return null;
		}

        internal virtual List<T> ConsultarTodos()
        {

			return null;
		}

		/// 
		/// <param name="obj"></param>
        internal virtual int Editar(T obj)
        {

			return 0;
		}

		public Comandos Ejecutor_Base_Datos{
			get{
				return m_ejecutor_base_datos;
			}
			set{
				m_ejecutor_base_datos = value;
			}
		}

		/// 
		/// <param name="obj"></param>
        internal virtual int Eliminar(T obj)
        {

			return 0;
		}

		/// 
		/// <param name="obj"></param>
        internal virtual int Insertar(T obj)
        {

			return 0;
		}

		public string Nombre_Procedimiento{
			get{
				return m_nombre_procedimiento;
			}
			set{
				m_nombre_procedimiento = value;
			}
		}

	}//end Entidad

}//end namespace DALC