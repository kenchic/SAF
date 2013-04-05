///////////////////////////////////////////////////////////
//  clsProyecto.cs
//  Implementation of the Class clsProyecto
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////




using SAFCore;
namespace SAFCore {
	public class clsProyecto : ClaseBase {

		private string m_direccion;
		private enuEstadoProyecto m_estado;
		private System.DateTime m_fecha;
		private string m_formacontacto;
		private string m_identificacionresponsable;
		private string m_nombreresponsable;
		private string m_observaciones;
		private string m_sistemamedida;
		private string m_telefono;
		private string m_telefonoresponsable;
		private string m_tipo;
		public SAFCore.clsCliente m_clsCliente;
		public SAFCore.clsAgente m_clsAgente;

		public clsProyecto(){

		}

		~clsProyecto(){

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

		public enuEstadoProyecto Estado{
			get{
				return m_estado;
			}
			set{
				m_estado = value;
			}
		}

        public System.DateTime Fecha
        {
			get{
				return m_fecha;
			}
			set{
				m_fecha = value;
			}
		}

		public string FormaContacto{
			get{
				return m_formacontacto;
			}
			set{
				m_formacontacto = value;
			}
		}

		public string IdentificacionResponsable{
			get{
				return m_identificacionresponsable;
			}
			set{
				m_identificacionresponsable = value;
			}
		}

		public string NombreResponsable{
			get{
				return m_nombreresponsable;
			}
			set{
				m_nombreresponsable = value;
			}
		}

		public string Observaciones{
			get{
				return m_observaciones;
			}
			set{
				m_observaciones = value;
			}
		}

		public string SistemaMedida{
			get{
				return m_sistemamedida;
			}
			set{
				m_sistemamedida = value;
			}
		}

		public string Telefono{
			get{
				return m_telefono;
			}
			set{
				m_telefono = value;
			}
		}

		public string TelefonoResponsable{
			get{
				return m_telefonoresponsable;
			}
			set{
				m_telefonoresponsable = value;
			}
		}

		public string Tipo{
			get{
				return m_tipo;
			}
			set{
				m_tipo = value;
			}
		}

	}//end clsProyecto

}//end namespace SAFCore