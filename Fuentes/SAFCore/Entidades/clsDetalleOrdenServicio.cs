///////////////////////////////////////////////////////////
//  clsDetalleOrdenServicio.cs
//  Implementation of the Class clsDetalleOrdenServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleOrdenServicio {

		#region Propiedades
		public Int32? Id;
public Int32? idOrdenServicio;
public Int16? idElemento;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleOrdenServicio(){
			
		}

		~clsDetalleOrdenServicio(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idOrdenServicio,idElemento,Cantidad,
		}
		#endregion 

	}//end clsDetalleOrdenServicio

}//end namespace SAFCore