///////////////////////////////////////////////////////////
//  clsRemision.cs
//  Implementation of the Class clsRemision
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////




using SAFCore;
namespace SAFCore {
	public class clsRemision : ClaseBaseDocumento {

		private bool m_despachado;
		private bool m_equipoadecuado;
		private System.DateTime m_fechacreacion;
		private System.DateTime m_fechaentrega;
		private System.DateTime m_fechapedido;
		private System.DateTime m_hora;
		private double m_pesoequipo;
		private bool m_transporte;
		private double m_valortransporte;
		public SAFCore.clsConductor m_clsConductor;
		public SAFCore.clsProyectoAlquiler m_clsProyectoAlquiler;
		public SAFCore.clsProyectoVenta m_clsProyectoVenta;

		public clsRemision(){

		}

		~clsRemision(){

		}

		public override void Dispose(){

		}

		public bool Despachado{
			get{
				return m_despachado;
			}
			set{
				m_despachado = value;
			}
		}

		public bool EquipoAdecuado{
			get{
				return m_equipoadecuado;
			}
			set{
				m_equipoadecuado = value;
			}
		}

		public System.DateTime FechaCreacion{
			get{
				return m_fechacreacion;
			}
			set{
				m_fechacreacion = value;
			}
		}

		public System.DateTime FechaEntrega{
			get{
				return m_fechaentrega;
			}
			set{
				m_fechaentrega = value;
			}
		}

		public System.DateTime FechaPedido{
			get{
				return m_fechapedido;
			}
			set{
				m_fechapedido = value;
			}
		}

		public System.DateTime Hora{
			get{
				return m_hora;
			}
			set{
				m_hora = value;
			}
		}

		public double PesoEquipo{
			get{
				return m_pesoequipo;
			}
			set{
				m_pesoequipo = value;
			}
		}

		public bool Transporte{
			get{
				return m_transporte;
			}
			set{
				m_transporte = value;
			}
		}

		public double ValorTransporte{
			get{
				return m_valortransporte;
			}
			set{
				m_valortransporte = value;
			}
		}

	}//end clsRemision

}//end namespace SAFCore