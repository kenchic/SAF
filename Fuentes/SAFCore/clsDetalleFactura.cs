///////////////////////////////////////////////////////////
//  clsDetalleFactura.cs
//  Implementation of the Class clsDetalleFactura
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:43 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////




using SAFCore;
namespace SAFCore {
	public class clsDetalleFactura : ClaseBaseDetalle {

		private string m_detalle;
		private int m_dias;
		private int m_valor;
		public SAFCore.clsFactura m_clsFactura;

		public clsDetalleFactura(){

		}

		~clsDetalleFactura(){

		}

		public override void Dispose(){

		}

		public string Detalle{
			get{
				return m_detalle;
			}
			set{
				m_detalle = value;
			}
		}

		public int Dias{
			get{
				return m_dias;
			}
			set{
				m_dias = value;
			}
		}

		public int Valor{
			get{
				return m_valor;
			}
			set{
				m_valor = value;
			}
		}

	}//end clsDetalleFactura

}//end namespace SAFCore