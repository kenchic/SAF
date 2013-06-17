///////////////////////////////////////////////////////////
//  clsFactura.cs
//  Implementation of the Class clsFactura
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////

namespace SAFCore {
	public class clsFactura : ClaseBaseDocumento {

		private byte m_dcto;
	    private System.DateTime m_fechaemision;
		private System.DateTime m_fechavencimiento;
		private byte m_iva;
		private double m_parcialtotal;
		private string m_son;
		private double m_subtotal;
		private enuTipoFactura m_tipo;
		private double m_total;

		public clsFactura(){

		}

		~clsFactura(){

		}

		public override void Dispose(bool disposing){

		}

        public byte Dcto
        {
			get{
				return m_dcto;
			}
			set{
				m_dcto = value;
			}
		}

		public System.DateTime FechaEmision{
			get{
				return m_fechaemision;
			}
			set{
				m_fechaemision = value;
			}
		}

		public System.DateTime FechaVencimiento{
			get{
				return m_fechavencimiento;
			}
			set{
				m_fechavencimiento = value;
			}
		}

        public byte Iva
        {
			get{
				return m_iva;
			}
			set{
				m_iva = value;
			}
		}

		public double ParcialTotal{
			get{
				return m_parcialtotal;
			}
			set{
				m_parcialtotal = value;
			}
		}

		public string Son{
			get{
				return m_son;
			}
			set{
				m_son = value;
			}
		}

		public double SubTotal{
			get{
				return m_subtotal;
			}
			set{
				m_subtotal = value;
			}
		}

		public enuTipoFactura Tipo{
			get{
				return m_tipo;
			}
			set{
				m_tipo = value;
			}
		}

		public double Total{
			get{
				return m_total;
			}
			set{
				m_total = value;
			}
		}

	}//end clsFactura

}//end namespace SAFCore