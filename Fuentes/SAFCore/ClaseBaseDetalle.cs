///////////////////////////////////////////////////////////
//  ClaseBaseDetalle.cs
//  Implementation of the Class ClaseBaseDetalle
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:42 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////


using System;
using SAFCore;
namespace SAFCore {
	public abstract class ClaseBaseDetalle {

		private int m_cantidad;
		private int m_id;
		public SAFCore.clsElemento m_clsElemento;
        
        ~ClaseBaseDetalle()
        {
            Dispose(false);
		}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

		public virtual void Dispose(bool disposing){
            
		}

		public ClaseBaseDetalle(){

		}

		/// 
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="activo"></param>
		public ClaseBaseDetalle(int id, string nombre, bool activo = true){

		}

		public int Cantidad{
			get{
				return m_cantidad;
			}
			set{
				m_cantidad = value;
			}
		}

		public int Id{
			get{
				return m_id;
			}
			set{
				m_id = value;
			}
		}

	}//end ClaseBaseDetalle

}//end namespace SAFCore