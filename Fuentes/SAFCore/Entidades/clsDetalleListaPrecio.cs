///////////////////////////////////////////////////////////
//  clsDetalleListaPrecio.cs
//  Implementation of the Class clsDetalleListaPrecio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleListaPrecio {

		#region Propiedades
		public Int32? Id;
public Byte? idListaPrecios;
public Int16? idElemento;
public Int32? PrecioAlquiler;
public Int32? PrecioVenta;
public Int32? PrecioPerdida;

		#endregion 
		
		#region Construtores
		public clsDetalleListaPrecio(){
			
		}

		~clsDetalleListaPrecio(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idListaPrecios,idElemento,PrecioAlquiler,PrecioVenta,PrecioPerdida,
		}
		#endregion 

	}//end clsDetalleListaPrecio

}//end namespace SAFCore