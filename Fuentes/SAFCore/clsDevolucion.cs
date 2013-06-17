///////////////////////////////////////////////////////////
//  clsDevolucion.cs
//  Implementation of the Class clsDevolucion
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////




using SAFCore;
namespace SAFCore {
	public class clsDevolucion : ClaseBaseDocumento {

		private bool m_entregacliente;
		private bool m_entregaparcial;
		private System.DateTime m_fechaanunciada;
		private System.DateTime m_fechacreacion;
		private System.DateTime m_fecharecogida;
		private System.DateTime m_hora;
		private float m_pesoequipo;
		private enuTipoMantenimiento m_tipomantenimiento;
		private long m_valorequipo;
		private long m_valortransporte;
		public SAFCore.clsProyectoAlquiler m_clsProyectoAlquiler;
		public SAFCore.clsConductor m_clsConductor;

		public clsDevolucion(){

		}

		~clsDevolucion(){

		}

		public override void Dispose(bool disposing){

		}

		public bool EntregaParcial{
			get{
				return m_entregaparcial;
			}
			set{
				m_entregaparcial = value;
			}
		}

		public System.DateTime FechaAnunciada{
			get{
				return m_fechaanunciada;
			}
			set{
				m_fechaanunciada = value;
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

		public System.DateTime FechaRecogida{
			get{
				return m_fecharecogida;
			}
			set{
				m_fecharecogida = value;
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

		public float PesoEquipo{
			get{
				return m_pesoequipo;
			}
			set{
				m_pesoequipo = value;
			}
		}

		public enuTipoMantenimiento TipoMantenimiento{
			get{
				return m_tipomantenimiento;
			}
			set{
				m_tipomantenimiento = value;
			}
		}

		public long ValorEquipo{
			get{
				return m_valorequipo;
			}
			set{
				m_valorequipo = value;
			}
		}

		public long ValorTransporte{
			get{
				return m_valortransporte;
			}
			set{
				m_valortransporte = value;
			}
		}

	}//end clsDevolucion

}//end namespace SAFCore