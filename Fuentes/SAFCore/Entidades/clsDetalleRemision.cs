///////////////////////////////////////////////////////////
//  clsDetalleRemision.cs
//  Implementation of the Class clsDetalleRemision
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleRemision {

		#region Propiedades
		public Int32? Id;
public Int32? idRemision;
public Int16? idElemento;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleRemision(){
			
		}

		~clsDetalleRemision(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idRemision,idElemento,Cantidad,
		}
		#endregion 

	}//end clsDetalleRemision

}//end namespace SAFCore