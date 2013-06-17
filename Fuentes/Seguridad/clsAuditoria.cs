///////////////////////////////////////////////////////////
//  clsAuditoria.cs
//  Implementation of the Class clsAuditoria
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 12:02:40 p.m.
//  Original author: Administrador
///////////////////////////////////////////////////////////

namespace Seguridad {
	public class clsAuditoria: ClaseBase {

		private string m_detalle;
		private int m_eventoauditoria;
		private short m_fecha;
		private int m_id;
		private string m_ipterminal;
		private string m_seccion;
		private string m_titulo;
		private ClsUsuario m_usuario;
		public  ClsUsuario m_clsUsuario;

		public clsAuditoria(){

		}

		~clsAuditoria(){

		}

		public virtual void Dispose(){

		}

		public string Detalle{
			get{
				return m_detalle;
			}
			set{
				m_detalle = value;
			}
		}

		public int EventoAuditoria{
			get{
				return m_eventoauditoria;
			}
			set{
				m_eventoauditoria = value;
			}
		}

		public short Fecha{
			get{
				return m_fecha;
			}
			set{
				m_fecha = value;
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

		public string IpTerminal{
			get{
				return m_ipterminal;
			}
			set{
				m_ipterminal = value;
			}
		}

		public string Seccion{
			get{
				return m_seccion;
			}
			set{
				m_seccion = value;
			}
		}

		public string Titulo{
			get{
				return m_titulo;
			}
			set{
				m_titulo = value;
			}
		}

		public ClsUsuario Usuario{
			get{
				return m_usuario;
			}
			set{
				m_usuario = value;
			}
		}

	}//end clsAuditoria

}//end namespace Seguridad