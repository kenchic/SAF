///////////////////////////////////////////////////////////
//  clsProveedor.cs
//  Implementation of the Class clsProveedor
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////




using SAFCore;
namespace SAFCore {
	public class clsProveedor : ClaseBase {

		private string m_direccion;
		private string m_identificacion;
		private string m_iniciales;
		private int m_telefono;

		public clsProveedor(){

		}

		~clsProveedor(){

		}

		public override void Dispose(){

		}

		public string Direccion{
			get{
				return m_direccion;
			}
			set{
				m_direccion = value;
			}
		}

		public string Identificacion{
			get{
				return m_identificacion;
			}
			set{
				m_identificacion = value;
			}
		}

		public string Iniciales{
			get{
				return m_iniciales;
			}
			set{
				m_iniciales = value;
			}
		}

		public int Ttelefono{
			get{
				return m_telefono;
			}
			set{
				m_telefono = value;
			}
		}

	}//end clsProveedor

}//end namespace SAFCore