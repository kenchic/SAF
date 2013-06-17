///////////////////////////////////////////////////////////
//  EntidadDetalle.cs
//  Implementation of the Class EntidadDetalle
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:57:25 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using BaseDatos;

namespace SAFCore.DALC {

    internal abstract class EntidadDetalle<T> where T : ClaseBaseDetalle, new()
    {

		private Comandos m_ejecutor_base_datos;
		private string m_nombre_procedimiento;

		~EntidadDetalle(){
            Dispose(false);
		}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {

        }

		/// 
		/// <param name="ejecutorBaseDatos"></param>
		public EntidadDetalle(Comandos ejecutorBaseDatos){

		}

		public EntidadDetalle(){

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

	}//end EntidadDetalle

}//end namespace DALC