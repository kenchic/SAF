///////////////////////////////////////////////////////////
//  clsDetalleListaPrecio.cs
//  Implementation of the Class clsDetalleListaPrecio
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:43 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////




using SAFCore;
namespace SAFCore {
	public class clsDetalleListaPrecio : ClaseBaseDetalle {

		private int m_precioalquiler;
		private int m_precioperdida;
		private int m_precioventa;
		public SAFCore.clsListaPrecio m_clsListaPrecio;

		public clsDetalleListaPrecio(){

		}

		~clsDetalleListaPrecio(){

		}

		public override void Dispose(){

		}

		public int PrecioAlquiler{
			get{
				return m_precioalquiler;
			}
			set{
				m_precioalquiler = value;
			}
		}

		public int PrecioPerdida{
			get{
				return m_precioperdida;
			}
			set{
				m_precioperdida = value;
			}
		}

		public int PrecioVenta{
			get{
				return m_precioventa;
			}
			set{
				m_precioventa = value;
			}
		}

	}//end clsDetalleListaPrecio

}//end namespace SAFCore