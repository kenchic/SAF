///////////////////////////////////////////////////////////
//  clsDetalleVenta.cs
//  Implementation of the Class clsDetalleVenta
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleVenta {

		#region Propiedades
		public Int32? Id;
public Int16? idElemento;
public Int32? idVenta;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleVenta(){
			
		}

		~clsDetalleVenta(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idElemento,idVenta,Cantidad,
		}
		#endregion 

	}//end clsDetalleVenta

}//end namespace SAFCore