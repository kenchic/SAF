///////////////////////////////////////////////////////////
//  clsVenta.cs
//  Implementation of the Class clsVenta
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsVenta {

		#region Propiedades
		public Int32? Id;
public Int32? idRemision;
public Int32? Numero;

		#endregion 
		
		#region Construtores
		public clsVenta(){
			
		}

		~clsVenta(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idRemision,Numero,
		}
		#endregion 

	}//end clsVenta

}//end namespace SAFCore