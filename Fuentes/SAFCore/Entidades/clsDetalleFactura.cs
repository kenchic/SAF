///////////////////////////////////////////////////////////
//  clsDetalleFactura.cs
//  Implementation of the Class clsDetalleFactura
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleFactura {

		#region Propiedades
		public Int32? Id;
public Int16? idElemento;
public Int32? idFactura;
public String Detalle;
public Byte? Dias;
public Int32? Cantidad;
public Int32? Valor;

		#endregion 
		
		#region Construtores
		public clsDetalleFactura(){
			
		}

		~clsDetalleFactura(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idElemento,idFactura,Detalle,Dias,Cantidad,Valor,
		}
		#endregion 

	}//end clsDetalleFactura

}//end namespace SAFCore