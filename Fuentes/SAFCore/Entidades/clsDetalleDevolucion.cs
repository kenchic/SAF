///////////////////////////////////////////////////////////
//  clsDetalleDevolucion.cs
//  Implementation of the Class clsDetalleDevolucion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleDevolucion {

		#region Propiedades
		public Int32? Id;
public Int32? idDevolucion;
public Int16? idElemento;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleDevolucion(){
			
		}

		~clsDetalleDevolucion(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idDevolucion,idElemento,Cantidad,
		}
		#endregion 

	}//end clsDetalleDevolucion

}//end namespace SAFCore