///////////////////////////////////////////////////////////
//  clsElemento.cs
//  Implementation of the Class clsElemento
//  Generated by Enterprise Architect
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: kenchic
///////////////////////////////////////////////////////////




using SAFCore;
namespace SAFCore {
	public class clsElemento : ClaseBase {

		private byte m_activo;
		private int m_id;
		private decimal m_mt2;
		private string m_nombre;
		private decimal m_peso;
		private string m_referencia;
		private byte m_rotacion;
		public SAFCore.clsGrupoElemento m_clsGrupoElemento;
		public SAFCore.clsUnidadMedida m_clsUnidadMedida;

		public clsElemento(){

		}

		~clsElemento(){

		}

		public override void Dispose(){

		}

		public byte Activo{
			get{
				return Activo;
			}
			set{
				Activo = value;
			}
		}

		public clsGrupoElemento GrupoElemento{
			get{
				return GrupoElemento;
			}
			set{
				GrupoElemento = value;
			}
		}

		public int Id{
			get{
				return Id;
			}
			set{
				Id = value;
			}
		}

		public decimal Mt2{
			get{
				return Mt2;
			}
			set{
				Mt2 = value;
			}
		}

		public string Nombre{
			get{
				return Nombre;
			}
			set{
				Nombre = value;
			}
		}

		public decimal Peso{
			get{
				return Peso;
			}
			set{
				Peso = value;
			}
		}

		public string Referencia{
			get{
				return Referencia;
			}
			set{
				Referencia = value;
			}
		}

		public byte Rotacion{
			get{
				return Rotacion;
			}
			set{
				Rotacion = value;
			}
		}

		public clsUnidadMedida UnidadMedida{
			get{
				return UnidadMedida;
			}
			set{
				UnidadMedida = value;
			}
		}

	}//end clsElemento

}//end namespace SAFCore