///////////////////////////////////////////////////////////
//  ClaseBaseDocumento.cs
//  Implementation of the Class ClaseBaseDocumento
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:42 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////




namespace SAFCore {
	public abstract class ClaseBaseDocumento {

		private bool m_anulado;
		private int m_id;
		private int m_numero;



		~ClaseBaseDocumento(){

		}

		public virtual void Dispose(){

		}

		public ClaseBaseDocumento(){

		}

		/// 
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="activo"></param>
		public ClaseBaseDocumento(int id, string nombre, bool activo = true){

		}

		public bool Anulado{
			get{
				return m_anulado;
			}
			set{
				m_anulado = value;
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

		public int Numero{
			get{
				return m_numero;
			}
			set{
				m_numero = value;
			}
		}

	}//end ClaseBaseDocumento

}//end namespace SAFCore